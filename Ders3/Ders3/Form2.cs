using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class Form2 : Form
    {
        Form1 anaEkran;

        public Form2(Form1 parametredenGelenEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenEkran;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, textBox2.Text);
            anaEkran.Form2(kitap);

            anaEkran.Show();
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
