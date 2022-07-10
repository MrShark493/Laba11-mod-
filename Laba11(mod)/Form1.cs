using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba11_mod_
{
    public partial class Form1 : Form
    {
        //Global Var
        Bitmap bmp;
        Graphics Graph;
        Pen blackpen;
        Pen redpen;
        TGraphic Graphic;
        TGraphArrow ArrowX;
        TGraphArrow ArrowY;
        double[] DotX;
        double[] DotY;
        Double B = 50;
        Double H = 3;

        static double Function(double X, double M = 2, double T = 300, double R = 8.31) // сама функция
        {
            return (Math.Exp((M * X * X) / (2 * R * T)));
        }

        static double Function_Derivative(double X0, double Epsilon = 0.01)
        {
            double X1 = X0 + Epsilon;
            double X2 = X0 - Epsilon;
            double Y1 = Function(X1);
            double Y2 = Function(X2);

            return ((Y1 - Y2) / (X1 - X2));
        }

        public Form1()
        {
            InitializeComponent();
            ComponentInitializer();
            VarInitialize();
        }

        private void ComponentInitializer()
        {
            Frame.Width = 500;
            Frame.Height = 500;
        }

        private void VarInitialize()
        {
            bmp = new Bitmap(Frame.Width, Frame.Height);
            Graph = Graphics.FromImage(bmp);
            blackpen = new Pen(Color.Black);
            blackpen.Width = 2;
            redpen = new Pen(Color.Red);
            redpen.Width = 2;

            Graphic = new TGraphic(Frame.Width / 2, Frame.Height / 2, Frame.Width / 2, Frame.Height / 2);
            ArrowY = new TGraphArrow(10, 15, false);
            ArrowX = new TGraphArrow(Frame.Width - 15, Frame.Height / 2, true);

            DotX = new double[Frame.Width];
            DotY = new double[Frame.Width];

            Dot_Prep();
        }

        private void Dot_Prep()
        {
            double X = 0;
            double B = 50;
            int i = 0;
            while (X < B)
            {
                DotX[i] = X;
                DotY[i] = Function(X);

                X += B / Frame.Height;
                i += 1;
            }

            string path = @"E:\log.txt";
            string text = String.Empty;

            StreamWriter sw = new StreamWriter(path, false);
            for (i = 0; i < 500; i++)
            {
                text = "DotX[" + Convert.ToString(i) + "] = " + Convert.ToString(DotX[i]) + "  | |  " + "DotY[" + Convert.ToString(i) + "] = " + Convert.ToString(DotY[i]);
                sw.WriteLine(text);
            }

            sw.Close();
        }

        private void Graphic_Render()
        {
            Graph.Clear(Color.White);

            Graph.DrawLine(blackpen, Graphic.OXS, Graphic.OXE);
            Graph.DrawLine(blackpen, Graphic.OYS, Graphic.OYE);

            Arrows_render();
            Markup_render();
            Function_render();

            Frame.Image = bmp;
        }

        private void Arrows_render()
        {
            Graph.DrawLine(blackpen, ArrowX.Head1, ArrowX.Head2);
            Graph.DrawLine(blackpen, ArrowX.Head2, ArrowX.Head3);
            Graph.DrawLine(blackpen, ArrowX.Head3, ArrowX.Head1);

            Graph.DrawLine(blackpen, ArrowY.Head1, ArrowY.Head2);
            Graph.DrawLine(blackpen, ArrowY.Head2, ArrowY.Head3);
            Graph.DrawLine(blackpen, ArrowY.Head3, ArrowY.Head1);
        }

        private void Markup_render()
        {
            int N = Frame.Width / 10;
            int GY = Frame.Height / 2;
            int GX = 10;
            int L = 3;

            string str = string.Empty;
            Font DrawFont = new Font("Arial", 6);
            int StrX;
            int StrY;
            Double Number;

            for (int i = 1; i < N; i++)
            {
                Graph.DrawLine(blackpen, 10 * i, GY + L, 10 * i, GY - L);

                if (i % 5 == 0)
                {
                    StrX = (10 * i) - 5;
                    StrY = GY + L + 5;
                    Number = (B / Frame.Width) * (10 * i);
                    str = Convert.ToString(Math.Round(Number, 3));
                    Graph.DrawString(str, DrawFont, Brushes.Black, StrX, StrY);
                }
            }

            for (int i = 1; i < N / 2; i++)
            { 
                Graph.DrawLine(blackpen, GX - L, GY - (10 * i), GX + L, GY - (10 * i));
                StrX = GX + 3 * L;
                StrY = GY - (10 * i) - (Font.Height / 2);
                Number = (H / GY) * (10 * i);
                str = Convert.ToString(Math.Round(Number, 3));
                Graph.DrawString(str, DrawFont, Brushes.Black, StrX, StrY);

                Graph.DrawLine(blackpen, GX - L, GY + (10 * i), GX + L, GY + (10 * i));
                StrX = GX + 3 * L;
                StrY = GY + (10 * i) - (Font.Height / 2 + 1);
                Number = (-1) * Number;
                str = Convert.ToString(Math.Round(Number, 3));
                Graph.DrawString(str, DrawFont, Brushes.Black, StrX, StrY);
            }
        }

        private void Function_render()
        {
            int[] FrX = new int[Frame.Width];
            int[] FrY = new int[Frame.Width];

            Double X;
            Double Y;

            for (int i = 0; i <= Frame.Width - 1; i++)
            {
                X = DotX[i];
                Y = DotY[i];

                X = 15 + X * (Frame.Width / B);
                X = Math.Round(X);
                FrX[i] = Convert.ToInt32(X);

                Y = (Frame.Height / 2) - Y * (Frame.Height / (2 * H));
                Y = Math.Round(Y);
                FrY[i] = Convert.ToInt32(Y); // <== тут проблема

            }


            string path = @"E:\logFrXY.txt";
            string text = String.Empty;

            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < 500; i++)
            {
                text = "FrX[" + Convert.ToString(i) + "] = " + Convert.ToString(FrX[i]) + "  | |  " + "FrY[" + Convert.ToString(i) + "] = " + Convert.ToString(FrY[i]);
                sw.WriteLine(text);
            }

            sw.Close();

            for (int i = 1; i <= 499; i++)
            {
                if ((FrX[i] > 0 && FrX[i] < 500) && (FrY[i] > 0 && FrY[i] < 500))
                {
                    Graph.DrawLine(redpen, FrX[i - 1], FrY[i - 1], FrX[i], FrY[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bisection_RB.Enabled = true;
            Newton_RB.Enabled = true;
        }

        static double Bisection(double N, double BorderA = 0, double BorderB = 100, double E = 0.001)
        {
            double C;

            while (((Function(BorderA) > N) && (Function(BorderB) > N)) || ((Function(BorderA) < N) && (Function(BorderB) < N)))
            {
                if ((Function(BorderA) > N) && (Function(BorderB) > N))
                {
                    BorderA += -100;
                }

                if ((Function(BorderA) < N) && (Function(BorderB) < N))
                {
                    BorderB += 100;
                }
            }

            C = (BorderA + BorderB) / 2;

            while ((Function(C) > E + N) || (Function(C) < N - E))
            {
                if (Function(C) > N)
                {
                    BorderB = C;
                }

                if (Function(C) < N)
                {
                    BorderA = C;
                }

                C = (BorderA + BorderB) / 2;
            }

            return C;
        }

        static double Newton(double Y, double Epsilon = 0.001)
        {
            double X0 = 10000000;
            double X1 = 100;

            while (Math.Abs(X1 - X0) > Epsilon)
            {
                X0 = X1;
                X1 = X0 - ((Function(X0) - Y) / Function_Derivative(X0));
            }

            return X1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Graphic_Render();

            double Answer = 228;

            if (Bisection_RB.Checked == true)
            {
                Answer = Bisection(Convert.ToDouble(NTBox.Text));
            }

            if (Newton_RB.Checked == true)
            {
                Answer = Newton(Convert.ToDouble(NTBox.Text));
            }

            FinalTBox.Text = Convert.ToString(Math.Round(Answer, 3));
        }

        private void NTBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void NTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)8;
            }
        }
    }
}
