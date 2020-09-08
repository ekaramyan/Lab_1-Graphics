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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Task_1_click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();

            settingsForm.Show();
        }

        private void Task_2_click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();

            settingsForm.Show();
        }
    }
}
