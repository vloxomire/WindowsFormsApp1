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
    public partial class _6SumaRadioButton : Form
    {
        public _6SumaRadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            if (radioButton1.Checked)
            {
                resultado = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            }
            else 
            {
                resultado= int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            }
            Text = resultado.ToString();
        }

        private void _6SumaRadioButton_Load(object sender, EventArgs e)
        {

        }
    }
}
