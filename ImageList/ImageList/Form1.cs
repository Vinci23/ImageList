using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public int brojac = 1;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = imageList.Images[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPromijeni1_Click(object sender, EventArgs e)
        {
            if (brojac % 2 == 0)
                pictureBox2.Image = imageList.Images[0];
            else
                pictureBox2.Image = imageList.Images[1];
            brojac++;
        }
    }
}
