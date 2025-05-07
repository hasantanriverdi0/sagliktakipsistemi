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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text.Trim();
            string telefonNo = textBox2.Text.Trim();

            // Telefon numarasının doğru formatta olduğuna bak
            if (adSoyad == "" || telefonNo.Length != 10)
            {
                MessageBox.Show("Lütfen geçerli bir Ad Soyad ve 10 haneli telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giriş başarılıysa anasayfaya geçiş yap
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
