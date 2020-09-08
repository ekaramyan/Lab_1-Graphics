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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 1);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(myPen, 10, 10, pictureBox1.Size.Width - 12,
            pictureBox1.Size.Height - 12);
            g.Dispose();
        }
    }
}
