using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            
            textBox1.AppendText("Odabrali ste :" + Environment.NewLine);
            if (Dorucak.Checked)
                textBox1.AppendText("dorucak" + Environment.NewLine);
            if (Rucak.Checked)
                textBox1.AppendText("rucak" + Environment.NewLine);
            if (Vecera.Checked)
                textBox1.AppendText("vecera" + Environment.NewLine);



        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
           
                if (textBox1.Visible == false)
                    textBox1.Visible = true;
                else
                    textBox1.Visible = false;
            

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
