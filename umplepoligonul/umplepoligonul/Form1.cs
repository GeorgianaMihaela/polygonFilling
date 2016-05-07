using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmplePoligonul
{
    public partial class UmplePoligon : Form
    {
        private FileDialog preiaPoli; // dialog ce permite preluarea poligonului din fisier
        private ColorDialog colorD; // pt alegerea culorii de umplere
        private Bitmap bmp; // cu asta desenam poligonul
        private Point[] puncte; // punctele care formeaza poligonul

        private Color c;  // culoarea folosita pt umplere
        //  private Color culoareContur; 
        private ContextMenuStrip meniuAlg; // alegem ce algoritm folosim pt umplere
        private int alfa, red, green, blue; // necesare pt obtinerea culorii anterioare

        private bool bculoareApasat; // verficam daca am apasat pe culoare ca sa apara colod dialog
        private bool bfisierApasat; // daca am apasat pe butonul din fisier
        private bool bgenereazaApasat; // daca am apasat pe genereaza

        // necesare pentru preluarea imaginii din fisier
        private Bitmap poligonFisier; // poligonul din fisier
        // private double prag;
        //  private Color cwhite = Color.FromArgb(255, 0, 0, 0);
        //  private Color cblack = Color.FromArgb(255, 255, 255, 255);
        private bool umpleFisier; // true daca umplem poligonul din fisier

        private bool umpleGeneratScan; // true daca umplem poligonul generat cu scanline
        // se face true cand apasam pe meniul cu scanline
        private bool umpleGeneratBound4; // true daca umplem poligonul generat cu boundaryfill cu 4 puncteStiva
        // se face true cand apasam pe submeniul boundary fill cu 4 puncteStiva 

        private bool umpleGeneratBound8; // treu daca umplem poligon cu alg boundary fill
        // cu 8 puncteStiva

        private bool umpleGeneratflood4; // true daca apas pe meniul care umple poli generat cu flood fill
        //cu 4 puncteStiva
        private bool umpleGeneratflood8;

        private Color culoareContur;

        private bool fisBoundary4, fisBoundary8, fisFlood4, fisFlood8;

        public UmplePoligon()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            numere.Value = 4; // default 4 laturi pt poligon
            // prag = 0.5; // inre negru si alb pt imaginea binara
            grosime.Value = 1; // default 1 pixel pt desenare
            c = Color.Chocolate; // default
            this.Icon = new Icon(@"E:\Calculatoare III\Sesiune-comunicari\cover-doc.ico");
        }

        private void fiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scanLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            umpleGeneratScan = true;
            umpleGeneratBound4 = false;
            pictureBox1.MouseMove += pictureBox_MouseMove;
            pictureBox1.MouseClick += pictureBox_MouseClick;
        }

        // boundaryFill cu 4 puncte
        private void cu4PuncteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgenereazaApasat)
            {
                umpleGeneratBound4 = true;
                umpleGeneratBound8 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
                if (!bfisierApasat)
                {
                    pictureBox1.MouseMove += pictureBox_MouseMove;
                    //  bfisierApasat = false;
                }
            }
            else if (bfisierApasat)
            {
                fisBoundary4 = true;
                fisBoundary8 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
            }
        }

        // boundary fill cu 8 puncte
        private void cu8PuncteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgenereazaApasat)
            {
                umpleGeneratBound8 = true;
                umpleGeneratBound4 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
                if (!bfisierApasat)
                { // daca nu iau polgon din fisier
                    pictureBox1.MouseMove += pictureBox_MouseMove;
                    //  bfisierApasat = false;
                }
            }
            else if (bfisierApasat)
            {
                fisBoundary8 = true;
                fisBoundary4 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
            }
        }

        // flood fill cu 4 puncte
        private void cu4PuncteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bgenereazaApasat)
            {
                umpleGeneratflood4 = true;
                umpleGeneratflood8 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
                if (!bfisierApasat)
                { // daca nu iau polgon din fisier
                    pictureBox1.MouseMove += pictureBox_MouseMove;
                    //  bfisierApasat = false;
                }
            }
            else if (bfisierApasat)
            {
                fisFlood4 = true;
                fisFlood8 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
            }
        }

        // flood fill cu 8 puncte
        private void cu8PuncteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bgenereazaApasat)
            {
                umpleGeneratflood8 = true;
                umpleGeneratflood4 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
                if (!bfisierApasat)
                { // daca nu iau polgon din fisier
                    pictureBox1.MouseMove += pictureBox_MouseMove;
                    //  bfisierApasat = false;
                }
            }
            else if (bfisierApasat)
            {
                fisFlood8 = true;
                fisFlood4 = false;
                pictureBox1.MouseClick += pictureBox_MouseClick;
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preiaPoli = new SaveFileDialog();
            preiaPoli.InitialDirectory = @"E:\";
            preiaPoli.Title = "Salveaza poligonul";
            preiaPoli.DefaultExt = ".PNG";
            preiaPoli.CheckPathExists = true;
            preiaPoli.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF";

            if (preiaPoli.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(preiaPoli.FileName);
                MessageBox.Show("Imagine salvata cu succes");
            }
            else if (preiaPoli.ShowDialog() == DialogResult.Cancel)
            {
                pictureBox1.Image = null;
                genereaza.Enabled = true;
                numere.Enabled = true;
                numere.Visible = true;
            }
        }


        private void dinfis_Click(object sender, EventArgs e)
        {
            bfisierApasat = true; // am apasat pe din fisier
            umpleFisier = true; // umplem poligon din fisier
            lvarfuri.Enabled = false;
            numere.Enabled = false;

            // nu putem umple cu scanline
            scanLineToolStripMenuItem.Enabled = false;
            //umple.Enabled = true;
            umpleGeneratBound8 = false;
            umpleGeneratBound4 = false;
            umpleGeneratScan = false;

            // deschidem un file dialog
            preiaPoli = new OpenFileDialog();
            preiaPoli.InitialDirectory = @"E:\";
            preiaPoli.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF";

            if (preiaPoli.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(preiaPoli.FileName); // preluam efectiv imaginea
                poligonFisier = new Bitmap(img);

                pictureBox1.Image = poligonFisier;
                // punem imaginea in centrul picture box
                // pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; asta face o translatie si nu mai 
                // e vazuta ok pozitia mouse-ului

            }
        }

        private void genereaza_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            bgenereazaApasat = true; // am apasat pe butonul genereaza
            dinfis.Enabled = false;
            numere.Enabled = true;
            numere.Visible = true;
            lvarfuri.Enabled = true;
            lvarfuri.Visible = true;
            okgen.Visible = true;
            bculoare.Visible = true;
             grosime.Visible = true;
            lgrosime.Visible = true;
            umpleFisier = false;
        }

        private void bculoare_Click(object sender, EventArgs e)
        {
            colorD = new ColorDialog();
            colorD.ShowDialog();
            c = colorD.Color;
            culoareContur = colorD.Color;
            bculoare.BackColor = c;
            bculoareApasat = true;
        }

        private void okgen_Click(object sender, EventArgs e)
        {
            if (bgenereazaApasat)
            { // daca am apsat pe butonul genereaza
                GenerarePoligon gp = new GenerarePoligon();
                Rectangle r = new Rectangle(50, 50, 300, 300);
                int nr = (int)numere.Value;
                puncte = gp.GenereazaPoligonRandom(nr, r);
                if (bculoareApasat)
                {
                    c = colorD.Color;
                    bculoareApasat = false;
                }

                Graphics g = Graphics.FromImage(bmp);
                // for (int i = 1; i <= grosime.Value; i++)
                //   g.DrawPolygon(new Pen(c), puncte);
                int i;
                Pen pen = new Pen(c);
                pen.Width = (int)grosime.Value;
                for (i = 0; i < puncte.Length - 1; i++)
                    g.DrawLine(pen, puncte[i], puncte[i + 1]);
                g.DrawLine(pen, puncte[i], puncte[0]);

                pictureBox1.Image = bmp;
                // bmp.Save(@"e:\bmp-contur");
                //bgenereazaApasat = false;
            }
        }

        // verificam daca cursorul se afla in interiorul poligonului
        private bool CursorInInterior(Point[] poligon, Point punctVerificat)
        {
            Point p1, p2;
            int i;
            bool inauntru = false;
            if (poligon != null && poligon.Length < 3)
                return inauntru;

            Point punctVechi = new Point(poligon[poligon.Length - 1].X, poligon[poligon.Length - 1].Y);
            for (i = 0; i < poligon.Length; i++)
            {
                Point punctNou = new Point(poligon[i].X, poligon[i].Y);
                if (punctNou.X > punctVechi.X)
                {
                    p1 = punctVechi;
                    p2 = punctNou;
                }
                else
                {
                    p1 = punctNou;
                    p2 = punctVechi;
                }

                if ((punctNou.X < punctVerificat.X) == (punctVerificat.X <= punctVechi.X) && ((long)punctVerificat.Y - (long)p1.Y) * (p2.X - p1.X) < ((long)p2.Y - (long)p1.Y) * ((long)punctVerificat.X - p1.X))
                {
                    inauntru = !inauntru;
                }

                punctVechi = punctNou;
            }

            return inauntru;
        }

        // modificam cursorul daca punctul e in interiorul poligonului
        private void pictureBox_MouseMove(object sender, MouseEventArgs ev)
        {
            if (umpleGeneratScan || umpleGeneratBound4 || umpleGeneratBound8 || umpleGeneratflood4 || umpleGeneratflood8)
            {
                Cursor curs;
                if (CursorInInterior(puncte, ev.Location))
                    curs = Cursors.Cross;
                else
                    curs = Cursors.Default;
                // update cursor
                if (this.Cursor != curs)
                    this.Cursor = curs;
            }
        }

        // aici umplem poligonul cu alg scanline si
        // facem poligonul sa revina la culoarea anterioara cu click dreapta
        private void pictureBox_MouseClick(object sender, MouseEventArgs ev)
        {

            Muchie m = new Muchie();
            Color r = Color.Black;
            BoundaryFill bf = new BoundaryFill();

            switch (ev.Button)
            {
                case MouseButtons.Left:
                    if (umpleGeneratScan)
                    {
                        if (CursorInInterior(puncte, ev.Location))
                        {
                            statusLabel.Enabled = true;
                            statusLabel.Visible = true;
                            statusLabel.Text = "Se umple poligon generat cu Scan-Line";

                            colorD = new ColorDialog();
                            colorD.ShowDialog();
                            r = colorD.Color;
                            statusLabel.ForeColor = r;

                            m.ScanFill((int)numere.Value, puncte, bmp, r, pictureBox1.Height, pictureBox1);
                            pictureBox1.Image = bmp;
                            pictureBox1.Refresh();

                            if (bmp != null)
                            {
                                alfa = bmp.GetPixel(ev.Location.X, ev.Location.Y).A;
                                green = bmp.GetPixel(ev.Location.X, ev.Location.Y).G;
                                red = bmp.GetPixel(ev.Location.X, ev.Location.Y).R;
                                blue = bmp.GetPixel(ev.Location.X, ev.Location.Y).B;
                            }
                        }


                    }
                    else if (umpleGeneratBound4 && CursorInInterior(puncte, ev.Location))
                    {
                        statusLabel.Enabled = true;
                        statusLabel.Visible = true;
                        statusLabel.Text = "Se umple poligon generat cu Boundary-Fill 4";

                        colorD = new ColorDialog();
                        colorD.ShowDialog();
                        r = colorD.Color;
                        statusLabel.ForeColor = r;

                        bf.BoundaryFill4(ev.Location.X, ev.Location.Y, r, culoareContur, bmp, pictureBox1);
                        umpleGeneratBound4 = false;
                        pictureBox1.Image = bmp;
                        pictureBox1.Refresh();
                    }
                    else if (umpleGeneratBound8 && CursorInInterior(puncte, ev.Location))
                    {
                        statusLabel.Enabled = true;
                        statusLabel.Visible = true;
                        statusLabel.Text = "Se umple poligon generat cu Boundary-Fill 8";

                        colorD = new ColorDialog();
                        colorD.ShowDialog();
                        r = colorD.Color;
                        statusLabel.ForeColor = r;

                        bf.BoundaryFill8(ev.Location.X, ev.Location.Y, r, culoareContur, bmp, pictureBox1);
                        umpleGeneratBound8 = false;
                        pictureBox1.Image = bmp;
                    }

                    else if (umpleGeneratflood4 && CursorInInterior(puncte, ev.Location))
                    {
                        statusLabel.Enabled = true;
                        statusLabel.Visible = true;
                        statusLabel.Text = "Se umple poligon generat cu Flood-Fill 4";

                        colorD = new ColorDialog();
                        colorD.ShowDialog();
                        r = colorD.Color;
                        statusLabel.ForeColor = r;

                        bf.FloodFill4(ev.Location.X, ev.Location.Y, r, bmp.GetPixel(ev.Location.X, ev.Location.Y), bmp, pictureBox1);
                        umpleGeneratflood4 = false;
                        pictureBox1.Image = bmp;
                    }

                    else if (umpleGeneratflood8 && CursorInInterior(puncte, ev.Location))
                    {
                        statusLabel.Enabled = true;
                        statusLabel.Visible = true;
                        statusLabel.Text = "Se umple poligon generat cu Flood-Fill 8";

                        colorD = new ColorDialog();
                        colorD.ShowDialog();
                        r = colorD.Color;
                        statusLabel.ForeColor = r;

                        bf.FloodFill8(ev.Location.X, ev.Location.Y, r, bmp.GetPixel(ev.Location.X, ev.Location.Y), bmp, pictureBox1);
                        umpleGeneratflood8 = false;
                        pictureBox1.Image = bmp;
                    }

                    else if (bfisierApasat)
                    {
                        if (fisBoundary4)
                        {
                            statusLabel.Enabled = true;
                            statusLabel.Visible = true;
                            statusLabel.Text = "Se umple poligon din fisier cu Boundary-Fill 4";

                            colorD = new ColorDialog();
                            colorD.ShowDialog();
                            r = colorD.Color;
                            statusLabel.ForeColor = r;
                            
                            Bitmap bitm = new Bitmap(pictureBox1.Image);
                            bf.BoundaryFill4(ev.Location.X, ev.Location.Y, r, Color.Black, bitm, pictureBox1);
                            pictureBox1.Image = bitm;
                            fisBoundary4 = false;
                        }
                        else if (fisBoundary8)
                        {
                            colorD = new ColorDialog();
                            colorD.ShowDialog();
                            r = colorD.Color;
                            
                            statusLabel.Enabled = true;
                            statusLabel.Visible = true;
                            statusLabel.ForeColor = r;
                            statusLabel.Text = "Se umple poligon din fisier cu Boundary-Fill 8";

                            Bitmap bitm = new Bitmap(pictureBox1.Image);
                            bf.BoundaryFill8(ev.Location.X, ev.Location.Y, r, Color.Black, bitm, pictureBox1);
                            pictureBox1.Image = bitm;
                            fisBoundary8 = false;
                        }
                        else if (fisFlood4)
                        {
                            statusLabel.Enabled = true;
                            statusLabel.Visible = true;
                           
                            statusLabel.ForeColor = r;
                            statusLabel.Text = "Se umple poligon din fisier cu Flood-Fill 4";

                            colorD = new ColorDialog();
                            colorD.ShowDialog();
                            r = colorD.Color;

                            Bitmap bitm = new Bitmap(pictureBox1.Image);
                            bf.FloodFill4(ev.Location.X, ev.Location.Y, r, bitm.GetPixel(ev.Location.X, ev.Location.Y), bitm, pictureBox1);
                            pictureBox1.Image = bitm;
                            fisFlood4 = false;
                        }
                        else if (fisFlood8)
                        {
                            
                            statusLabel.Enabled = true;
                            statusLabel.Visible = true;
                            statusLabel.Text = "Se umple poligon din fisier cu Flood-Fill 8";

                            colorD = new ColorDialog();
                            colorD.ShowDialog();
                            r = colorD.Color;
                            statusLabel.ForeColor = colorD.Color;

                            Bitmap bitm = new Bitmap(pictureBox1.Image);
                            bf.FloodFill8(ev.Location.X, ev.Location.Y, r, bitm.GetPixel(ev.Location.X, ev.Location.Y), bitm, pictureBox1);
                            pictureBox1.Image = bitm;
                            fisFlood8 = false;
                        }
                        bfisierApasat = false;
                    }

                    break;

                case MouseButtons.Right:
                    if (umpleGeneratScan)
                    {
                        if (CursorInInterior(puncte, ev.Location))
                        {
                            m.ScanFill((int)numere.Value, puncte, bmp, c, pictureBox1.Height, pictureBox1);
                            pictureBox1.Image = bmp;
                            pictureBox1.Invalidate();
                        }
                        umpleGeneratScan = false;
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        // boundary fill cu 4 puncteStiva vecine
        //    public void BoundaryFill4(int x, int y, Color fill, Color boundary)
        //    {
        //        Stack<Point> puncteStiva = new Stack<Point>();
        //        Point punctInitial = new Point(x, y);
        //        int x1;
        //        int y1;
        //        Color crt;
        //        Point punctCrt;

        //        puncteStiva.Push(punctInitial); // adaugam punctul initial in stiva

        //        while (puncteStiva.Count > 0)
        //        {
        //            punctCrt = puncteStiva.Pop(); // scoatem punctul curent din stiva
        //            x1 = punctCrt.X;
        //            y1 = punctCrt.Y;
        //            crt = bmp.GetPixel(x1, y1);

        //            if (crt.ToArgb() != fill.ToArgb() && crt.ToArgb() != boundary.ToArgb())
        //            {
        //                bmp.SetPixel(x1, y1, fill);
        //                puncteStiva.Push(new Point(x1 + 1, y1)); // dreapta
        //                puncteStiva.Push(new Point(x1 - 1, y1)); // stanga
        //                puncteStiva.Push(new Point(x1, y1 + 1)); // sus
        //                puncteStiva.Push(new Point(x1, y1 - 1)); // jos

        //                pictureBox1.Image = bmp;
        //                pictureBox1.Refresh();
        //            }
        //        }
        //        // timerBoundary4.Enabled = true;
        //        //  timerBoundary4.Interval = 1;
        //        //  timerBoundary4.Tick += timerBoundary4_Tick;
        //    }

        // obs: unele portiuni de cod au fost scrise de 2 ori, cand se puteau scrie o singura data :(
        // aplicatia sigur va fi imbunatatita :)
    }
}
