using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmplePoligonul
{
    class Muchie
    {
        private int ySup; // y-ul superior
        private float xIntersectie, dxScan;
        private Muchie next;

        private System.Windows.Forms.Timer timer;

        public Muchie()
        {
            timer = new System.Windows.Forms.Timer();
        }
        // insereaza muchia in lista in ordinea crescatoare a campului xIntersectie
        void InsereazaMuchie(Muchie lista, Muchie muchie)
        {
            Muchie p, q = lista;
            p = q.next;
            while (p != null)
            {
                if (muchie.xIntersectie < p.xIntersectie)
                    p = null;
                else
                {
                    q = p;
                    p = p.next;
                }
            }
            muchie.next = q.next;
            q.next = muchie;
        }

        // pt un index, returneaza coordonata y a urmatoarei linii neorizontale
        int yNext(int k, int cnt, Point[] puncte)
        {
            int j;
            if (k + 1 > cnt - 1)
                j = 0;
            else
                j = k + 1;
            while (puncte[k].Y == puncte[j].Y)
                if (j + 1 > cnt - 1)
                    j = 0;
                else
                    j++;
            return puncte[j].Y;
        }

        // pastreaza coordonata y a punctului de start al muchiei si inversul pantei (1/m) pt fiecare muchie
        // ajusteaza si pastreaza coordonata y a punctului final pt muchiile care sunt membrul inferior 
        // dintr-o pereche de muchii monoton crescatoare sau descrescatoare
        void AjusteazaMuchie(Point inf, Point sup, int yComp, Muchie muchie, Muchie[] muchii)
        {
            muchie.dxScan = (float)(sup.X - inf.X) / (sup.Y - inf.Y);
            muchie.xIntersectie = inf.X;
            if (sup.Y < yComp)
                muchie.ySup = sup.Y - 1;
            else
                muchie.ySup = sup.Y;
            InsereazaMuchie(muchii[inf.Y], muchie);
        }

        void ConstruiesteListaMuchii(int cnt, Point[] puncte, Muchie[] muchii)
        {
            Muchie muchie;
            Point p1, p2;
            int i, yPrev = puncte[cnt - 2].Y;
            p1 = new Point();
            p1.X = puncte[cnt - 1].X;
            p1.Y = puncte[cnt - 1].Y;

            for (i = 0; i < cnt; i++)
            {
                p2 = puncte[i];
                if (p1.Y != p2.Y)
                { // linie care nu e orizontala adica
                    muchie = new Muchie();
                    if (p1.Y < p2.Y) // muchie care se duce in sus
                        AjusteazaMuchie(p1, p2, yNext(i, cnt, puncte), muchie, muchii);
                    else // muchie descrescatoare
                        AjusteazaMuchie(p2, p1, yPrev, muchie, muchii);
                }
                yPrev = p1.Y;
                p1 = p2;
            }
        }

        void ConstruiesteListaActiva(int scan, Muchie activa, Muchie[] muchii)
        {
            Muchie p, q;

            if (scan >= 0 && scan < 410)
                p = muchii[scan].next;
            else
                p = muchii[409].next;

            while (p != null)
            {
                q = p.next;
                InsereazaMuchie(activa, p);
                p = q;
            }
        }

        void FillScan(int scan, Muchie activa, Bitmap b, Color c)
        {
            Muchie p1, p2;
            int i;

            p1 = activa.next;
            while (p1 != null)
            {
                p2 = p1.next;
                for (i = (int)p1.xIntersectie; i < p2.xIntersectie; i++)
                {
                    b.SetPixel(i, scan, c);
                    Task.Delay(1000); //as vrea sa vad fiecare linie
                }

                p1 = p2.next;

            }
        }

        void StergeDupa(Muchie q)
        {
            Muchie p = q.next;
            q.next = p.next;
            p = null;
        }

        // stergem muchii complete, update xIntersectie pt muchiile incomplet procesate
        void UpdateListaActiva(int scan, Muchie activa)
        {
            Muchie q = activa, p = activa.next;
            while (p != null)
                if (scan >= p.ySup)
                {
                    p = p.next;
                    StergeDupa(q);
                }
                else
                {
                    p.xIntersectie += p.dxScan;
                    q = p;
                    p = p.next;
                }
        }

        void ResorteazaListaActiva(Muchie activa)
        {
            Muchie q, p = activa.next;
            activa.next = null;
            while (p != null)
            {
                q = p.next;
                InsereazaMuchie(activa, p);
                p = q;
            }
        }

        // functie ce efectiv umple poligonul
        int scan;
        Muchie activa;
        Muchie[] muchii;
        Bitmap bitm; //aici am imaginea pe care o actualizez
        Color cl;
        PictureBox pb;
        public void ScanFill(int cnt, Point[] puncte, Bitmap bmp, Color c, int windowHeight, PictureBox box)
        {
            bitm = bmp;
            pb = box;
            // bmp.Save("e:\\test.bmp");
            cl = c;
            muchii = new Muchie[windowHeight];
            int i;

            for (i = 0; i < windowHeight; i++)
            {
                muchii[i] = new Muchie();
                muchii[i].next = null;
            }

            ConstruiesteListaMuchii(cnt, puncte, muchii);
            activa = new Muchie();
            activa.next = null;
            scan = 0;

            //for (scan = 0; scan < windowHeight; scan++)
            //{

            //    ConstruiesteListaActiva(scan, activa, muchii);
            //    if (activa.next != null)
            //    {
            //        FillScan(scan, activa, bmp, c);
            //        UpdateListaActiva(scan, activa);
            //        ResorteazaListaActiva(activa);
            //      //  Task.Delay(1000);
            //    }

            //}
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (scan == bitm.Width - 2)
            {
                timer.Stop();
                timer.Enabled = false;
            }


            ConstruiesteListaActiva(scan, activa, muchii);
            if (activa.next != null)
            {
                FillScan(scan, activa, bitm, cl);
                UpdateListaActiva(scan, activa);
                ResorteazaListaActiva(activa);
                pb.Image = bitm;
                pb.Refresh();
                // Task.Delay(1000);
            }
            scan++;
        }

    }


}
