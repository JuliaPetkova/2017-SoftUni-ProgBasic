using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n1 = decimal.Parse(this.textBox1.Text);
            var n2 = decimal.Parse(this.textBox2.Text);
            var suma = n1 + n2;
            textBox3.Text = suma.ToString();
        }
    }
}
