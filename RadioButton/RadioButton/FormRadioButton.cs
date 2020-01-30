using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class FormRadioButton : Form
    {
        public FormRadioButton()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormRadioButton_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked)
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            else if (radioButtonAutobus.Checked)
                textBox1.Text = "Odabrali ste prijevoz autobusom.";
            else if (radioButtonVlastiti.Checked)
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            else
            {
                // u slucaju da nista nije odabrano
                MessageBox.Show("Odaberite tip prijevoza.");
                return;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
