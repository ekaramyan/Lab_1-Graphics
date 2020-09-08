using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Получаем объект Graphics
            Graphics g = e.Graphics;
            // Линия
            g.DrawLine(Pens.Red, 10, 5, 110, 15);
            // Эллипс
            g.DrawEllipse(Pens.Blue, 10, 20, 110, 45);
            // Прямоугольник
            g.DrawRectangle(Pens.Green, 10, 70, 110, 45);
            // Закрашенный эллипс
            g.FillEllipse(Brushes.Blue, 130, 20, 110, 45);
            // Закрашенный прямоугольник
            g.FillRectangle(Brushes.Green, 130, 70, 110, 45);
            base.OnPaint(e);
        }
    }
}
