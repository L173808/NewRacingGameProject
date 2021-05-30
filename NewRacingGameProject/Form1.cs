using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewRacingGameProject
{
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 10)
            {
                y = y + 10;

            }
            else {
                timer1.Stop();
                Racing obj = new Racing();
                obj.Visible = true;

            }
        }
    }
}
