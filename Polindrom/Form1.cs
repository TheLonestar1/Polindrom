using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        void Check()
        {
            string text = textBox1.Text;
            char[] obrtext = text.ToArray();
            Array.Reverse(obrtext);
            string final = new string(obrtext);
            if (text == final)
                label1.Text = "Это полиндром";
            else
                label1.Text = "Это не полиндром" + final;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
