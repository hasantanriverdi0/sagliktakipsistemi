using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sagliktakipsistemi
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Boy;
            textBox2.Text = Properties.Settings.Default.Kilo;
            textBox3.Text = Properties.Settings.Default.Yas;

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string boy = textBox1.Text;
            string kilo = textBox2.Text;
            string yas = textBox3.Text;

            // Verilerin boş olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(boy) || string.IsNullOrWhiteSpace(kilo) || string.IsNullOrWhiteSpace(yas))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verileri kalıcı olarak kaydet
            Properties.Settings.Default.Boy = boy;
            Properties.Settings.Default.Kilo = kilo;
            Properties.Settings.Default.Yas = yas;
            Properties.Settings.Default.Save();

            // Veri.cs sayfasına dön
            veri veriForm = new veri();
            veriForm.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            veri veriForm = new veri();
            veriForm.Show();
            this.Hide();
        }
    }
}
