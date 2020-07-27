using System;
using System.IO;
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
    public partial class Password : Form
    {
        private string clave;
        private StreamWriter streamwriter;
        public Password()
        {
            InitializeComponent();
            streamwriter = new StreamWriter(@"C:\Users\vloxo\Documents\clave.txt", false);
            this.clave = "123abc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=clave)
            {
                label2.Text = "Clave incorrecta";
                this.BackColor = System.Drawing.SystemColors.Menu;
                return;
            }
            label2.Text = "Clave correcta";
            streamwriter.WriteLine("Clave: "+textBox1.Text);
            streamwriter.Close();
            this.BackColor = System.Drawing.SystemColors.Desktop;
        }
    }
}
