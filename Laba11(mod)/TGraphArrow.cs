using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Laba11_mod_
{
    class TGraphArrow
    {
        public Point Head1;
        public Point Head2;
        public Point Head3;

        public Point Landing;

        public TGraphArrow(int X, int Y, Boolean OX, int W = 10, int H = 10)
        {
            this.Landing.X = X;
            this.Landing.Y = Y;

            if (OX == false)
            {
                this.Head1.X = X - (W / 2);
                this.Head1.Y = Y;

                this.Head2.X = X + (W / 2);
                this.Head2.Y = Y;

                this.Head3.X = X;
                this.Head3.Y = Y - H;
            }
            else
            {
                this.Head1.X = X;
                this.Head1.Y = Y - (H / 2);

                this.Head2.X = X;
                this.Head2.Y = Y + (H / 2);

                this.Head3.X = X + W;
                this.Head3.Y = Y;
            }
        }
    }
}
