using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturoPol
{
    public partial class Grafika : Form
    {
        public Grafika()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }

        private void Grafika_Load(object sender, EventArgs e)
        {

        }

        private void Grafika_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen olowek = new Pen(Color.Black);
            Brush pedzel = new SolidBrush(Color.Red);

            e.Graphics.FillRectangle(Brushes.Aquamarine, 0, 0, 200, 1500); //niebo
            e.Graphics.FillRectangle(Brushes.Orange, 100, 200, 200, 150); //ok - budynek
            e.Graphics.FillRectangle(Brushes.White, 130, 225, 30, 30);  // ok -okno L 
            e.Graphics.FillRectangle(Brushes.White, 245, 225, 30, 30);  // ok - okno P 
            e.Graphics.FillRectangle(Brushes.Black, 175, 240, 50, 140);  // ok - drzwi 
            e.Graphics.FillRectangle(Brushes.Red, 185, 310, 30, 70);  // ok - drzwi 

            //g.DrawLine(olowek, 2, 2, 400, 450);
            //  g.DrawLine(olowek, 100, 100, 200, 150);         
            g.FillEllipse(Brushes.Yellow, 400, 10, 50, 50); //ok
            //g.DrawArc(olowek, 400, 100, 50, 50, 0, -90);

            //string a = "Abstrakcyjny obraz";

            Font czcionka = new Font("arial", 16);
            SolidBrush pedzel1 = new SolidBrush(Color.Black);
            PointF punkt = new PointF(150.0F, 150.0F);

            //e.Graphics.DrawString(a, czcionka, pedzel1, punkt);


        }
    }
}
