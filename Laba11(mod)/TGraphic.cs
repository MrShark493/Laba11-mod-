using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;

namespace Laba11_mod_
{
    class TGraphic
    {
        public int W;
        public int H;

        public Point GeomCentre;
        public Point OXS; // OX start
        public Point OXE; // OX end
        public Point OYS;
        public Point OYE;

        public TGraphic(int GX, int GY, double X, double Y)
        {
            this.W = Convert.ToInt32(X);
            this.H = Convert.ToInt32(Y);

            this.GeomCentre.X = 15;
            this.GeomCentre.Y = GY;

            this.OXS.X = GX - W;
            this.OXS.Y = GY;

            this.OXE.X = GX + W;
            this.OXE.Y = GY;

            this.OYS.X = 10;
            this.OYS.Y = GY + H;

            this.OYE.X = 10;
            this.OYE.Y = GY - H;
        }
    }
}
