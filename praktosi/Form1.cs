using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktosi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, k;
            a = Convert.ToInt32(textA.Text);
            b = Convert.ToInt32(textB.Text);
            k = Convert.ToInt32(textK.Text);

            var price = Math.Ceiling((a * b) / 12.0f);

            resultText.Text = (price * k).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float s, d;
            float r = Convert.ToSingle(textR.Text);
            s = (float)(Math.PI * Math.Pow(r, 2));
            d = (float)(2 * Math.PI * r);
            textS.Text = s.ToString();
            textD.Text = d.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
