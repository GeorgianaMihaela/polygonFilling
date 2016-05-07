using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmplePoligonul
{
    class BoundaryFill
    {
        // boundary fill cu 4 puncteStiva vecine
        public void BoundaryFill4(int x, int y, Color fill, Color boundary, Bitmap bmp, PictureBox pb)
        {
            Stack<Point> puncteStiva = new Stack<Point>();
            Point punctInitial = new Point(x, y);
            int x1;
            int y1;
            Color crt;

            puncteStiva.Push(punctInitial); // adaugam punctul initial in stiva

            while (puncteStiva.Count > 0)
            {
                Point punctCrt = puncteStiva.Pop(); // scoatem punctul curent din stiva
                x1 = punctCrt.X;
                y1 = punctCrt.Y;

                crt = bmp.GetPixel(x1, y1);

                if (crt.ToArgb() != fill.ToArgb() && crt.ToArgb() != boundary.ToArgb())
                {

                    bmp.SetPixel(x1, y1, fill);

                    puncteStiva.Push(new Point(x1 + 1, y1)); // dreapta
                    puncteStiva.Push(new Point(x1 - 1, y1)); // stanga
                    puncteStiva.Push(new Point(x1, y1 + 1)); // sus
                    puncteStiva.Push(new Point(x1, y1 - 1)); // jos

                    pb.Image = bmp;
                    pb.Refresh();
                }
            }
            // timerBoundary4.Enabled = true;
            //  timerBoundary4.Interval = 1;
            //  timerBoundary4.Tick += timerBoundary4_Tick;
        }

        //private void timerBoundary4_Tick(object sender, EventArgs args)
        //{
        //    if (puncteStiva.Count == 0)
        //    {
        //        timerBoundary4.Stop();
        //        timerBoundary4.Enabled = false;
        //    }

        //}

        //  crt = bmp.GetPixel(x, y);
        // asa recursiv da stack overflow
        //if (crt != boundary && crt != fill)
        //{
        //    bmp.SetPixel(x, y, fill);
        //    BoundaryFill4(x + 1, y, fill, boundary, bmp);
        //    BoundaryFill4(x - 1, y, fill, boundary, bmp);
        //    BoundaryFill4(x, y + 1, fill, boundary, bmp);
        //    BoundaryFill4(x, y - 1, fill, boundary, bmp);
        //}


        public void BoundaryFill8(int x, int y, Color fill, Color boundary, Bitmap bmp, PictureBox pb)
        {
            Stack<Point> puncteStiva = new Stack<Point>();
            Point punctIntit = new Point(x, y);
            puncteStiva.Push(punctIntit); // adaugam punctul initial in stiva

            int x1, y1;
            Color crt;

            while (puncteStiva.Count > 0)
            {
                Point punctCrt = puncteStiva.Pop(); // scoatem punctul curent din stiva
                x1 = punctCrt.X;
                y1 = punctCrt.Y;

                crt = bmp.GetPixel(x1, y1);

                if (crt.ToArgb() != boundary.ToArgb() && crt.ToArgb() != fill.ToArgb())
                {
                    bmp.SetPixel(x1, y1, fill);
                    puncteStiva.Push(new Point(x1, y1 + 1)); // nord
                    puncteStiva.Push(new Point(x1 + 1, y1 + 1)); // nord-est
                    puncteStiva.Push(new Point(x1 + 1, y1)); // est
                    puncteStiva.Push(new Point(x1 + 1, y1 - 1)); // sud-est
                    puncteStiva.Push(new Point(x1, y1 - 1)); // sud
                    puncteStiva.Push(new Point(x1 - 1, y1 - 1)); // sud-vest
                    puncteStiva.Push(new Point(x1 - 1, y1)); // vest
                    puncteStiva.Push(new Point(x1 - 1, y1 + 1)); // nord-vest
                }

                pb.Image = bmp;
                pb.Refresh();
            }
            // timerBoundary8.Enabled = true;
            // timerBoundary8.Interval = 1;
            // timerBoundary8.Tick += timerBoundary8_Tick;

            // asa va da stack overflow
            //crt = bmp.GetPixel(x, y);

            //if (crt != boundary && crt != fill)
            //{
            //    bmp.SetPixel(x, y, fill);
            //    BoundaryFill8(x + 1, y, fill, boundary, bmp);
            //    BoundaryFill8(x + 1, y + 1, fill, boundary, bmp);
            //    BoundaryFill8(x, y + 1, fill, boundary, bmp);
            //    BoundaryFill8(x - 1, y + 1, fill, boundary, bmp);
            //    BoundaryFill8(x - 1, y, fill, boundary, bmp);
            //    BoundaryFill8(x - 1, y - 1, fill, boundary, bmp);
            //    BoundaryFill8(x, y - 1, fill, boundary, bmp);
            //    BoundaryFill8(x + 1, y - 1, fill, boundary, bmp);
            //}
        }

        //private void timerBoundary8_Tick(object sender, EventArgs ev)
        //{
        //    if (puncteStiva.Count == 0)
        //    {
        //        timerBoundary8.Stop();
        //        timerBoundary8.Enabled = false;

        //    }

        //}

        // flood-fill cu 4 puncteStiva
        public void FloodFill4(int x, int y, Color fill, Color veche, Bitmap bmp, PictureBox box)
        {
            Stack<Point> puncteStiva = new Stack<Point>();
            puncteStiva.Push(new Point(x, y)); // adaugam punctul initial in stiva; 
            Color crt;
            int x1, y1;
            //   timerFlood4.Enabled = true;
            //  timerFlood4.Interval = 1;
            //  timerFlood4.Tick += timerFlood4_Tick;
            while (puncteStiva.Count > 0)
            {
                Point pcrt = puncteStiva.Pop();
                x1 = pcrt.X;
                y1 = pcrt.Y;
                crt = bmp.GetPixel(x1, y1);

                if (crt.ToArgb() == veche.ToArgb())
                {
                    bmp.SetPixel(x1, y1, fill);
                    puncteStiva.Push(new Point(x1, y1 - 1)); // jos
                    puncteStiva.Push(new Point(x1 - 1, y1)); // stanga
                    puncteStiva.Push(new Point(x1, y1 + 1)); // sus
                    puncteStiva.Push(new Point(x1 + 1, y1)); // dreapta
                }

                box.Image = bmp;
                box.Refresh();
            }
        }


        // flood fill cu 8 puncteStiva
        public void FloodFill8(int x, int y, Color fill, Color veche, Bitmap bmp, PictureBox box)
        {
            Stack<Point> puncteStiva = new Stack<Point>();
            puncteStiva.Push(new Point(x, y)); // adaugam punctul initial in stiva; 

            //timerFlood8.Enabled = true;
            //timerFlood8.Interval = 1;
            //timerFlood8.Tick += timerFlood8_Tick;
            int x1, y1;
            Color crt;

            while (puncteStiva.Count > 0)
            {
                Point pcrt = puncteStiva.Pop();
                x1 = pcrt.X;
                y1 = pcrt.Y;
                crt = bmp.GetPixel(x1, y1);

                if (crt.ToArgb() == veche.ToArgb())
                {
                    bmp.SetPixel(x1, y1, fill);
                    puncteStiva.Push(new Point(x1, y1 + 1));
                    puncteStiva.Push(new Point(x1, y1 - 1));
                    puncteStiva.Push(new Point(x1 + 1, y1));
                    puncteStiva.Push(new Point(x1 - 1, y1));

                    // diagonale
                    puncteStiva.Push(new Point(x1 - 1, y1 + 1));
                    puncteStiva.Push(new Point(x1 - 1, y1 - 1));
                    puncteStiva.Push(new Point(x1 + 1, y1 + 1));
                    puncteStiva.Push(new Point(x1 + 1, y1 - 1));
                }

                box.Image = bmp;
                box.Refresh();
            }
        }
    }
}
