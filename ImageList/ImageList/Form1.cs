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
    public partial class FormImageList : Form
    {
        public int brojac = 1;
        public FormImageList()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];

        }
        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            if (brojac % 2 == 0)
                pictureBox1.Image = imageList1.Images[0];

            else

                pictureBox1.Image = imageList1.Images[1];
            brojac++;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
