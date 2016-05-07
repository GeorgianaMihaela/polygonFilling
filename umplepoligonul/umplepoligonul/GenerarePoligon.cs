using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmplePoligonul
{
    class GenerarePoligon
    {
        private static Random rand = new Random();
        public Point[] GenereazaPoligonRandom(int nrVarfuri, Rectangle laturi)
        {
            // alegem raze aleatoare
            double[] raze = new double[nrVarfuri];
            const double razaMin = 0.5;
            const double razaMax = 1.0;
            int i;
            for (i = 0; i < nrVarfuri; i++)
            {
                raze[i] = rand.NextDouble() * (razaMax - razaMin) + razaMin;
            }

            // alegem masuri aleatoare pt unghiuri
            double[] masUnghiuri = new double[nrVarfuri];
            const double minMas = 1.0;
            const double maxMas = 10.0;
            double masTotala = 0;
            for (i = 0; i < nrVarfuri; i++)
            {
                masUnghiuri[i] = rand.NextDouble() * (maxMas - minMas) + minMas;
                masTotala += masUnghiuri[i];
            }

            // conevrtim masurile in fractiuni ale lui 2*pi radiani
            double[] unghiuri = new double[nrVarfuri];
            double rad = 2 * Math.PI / masTotala;
            for (i = 0; i < nrVarfuri; i++)
            {
                unghiuri[i] = masUnghiuri[i] * rad;
            }

            // calculam locatia punctelor pe ecran
            Point[] puncte = new Point[nrVarfuri];
            float rx = laturi.Width / 2f;
            float ry = laturi.Height / 2f;
            float cx = (laturi.Location.X + rx);
            float cy = (laturi.Location.Y + ry);

            double fi = 0;
            for (i = 0; i < nrVarfuri; i++)
            {
                puncte[i] = new Point((int)cx + (int)(rx * raze[i] * Math.Cos(fi)), (int)cy + (int)(ry * raze[i] * Math.Sin(fi)));
                fi += unghiuri[i];

            }

            return puncte;
        }
    }
}
