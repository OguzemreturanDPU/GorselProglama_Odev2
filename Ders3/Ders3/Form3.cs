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
    public partial class Form3 : Form
    {
        Form1 anaEkran;

        public Form3(Form1 parametredenGelenAnaEkran, Kitap kitap)
        {
            InitializeComponent();

            anaEkran = parametredenGelenAnaEkran;

            textBox1.Text = kitap.Ad;
            textBox2.Text = kitap.Yazar;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, textBox2.Text);
            anaEkran.Form3(kitap);
            anaEkran.Show();
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }

        public Form3(Form1 parametredenGelenEkran2)
        {
        }
    }
}
