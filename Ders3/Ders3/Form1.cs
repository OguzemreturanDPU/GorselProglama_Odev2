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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 kitapEkle = new Form2(this);
            kitapEkle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Tutunamayanlar");
            //listBox1.Items.Add("Tehlikeli Oyunlar");
            button1.Enabled = false;
            button2.Enabled = false;
        }

        public void Form2(Kitap kitap)
        {
            listBox1.Items.Add(kitap);
        }

        public void Form3(Kitap kitap)
        {
            listBox1.Items[listBox1.SelectedIndex] = kitap;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = (Kitap)listBox1.Items[listBox1.SelectedIndex];
            Form3 kitapDuzenle = new Form3(this, kitap);
            kitapDuzenle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlgili kitabı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void üyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
