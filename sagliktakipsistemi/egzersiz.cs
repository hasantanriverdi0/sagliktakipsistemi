using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sagliktakipsistemi
{
    public partial class egzersiz : Form
    {
        private Dictionary<string, string> egzersizler;

        public egzersiz()
        {
            InitializeComponent();
        }

        private void egzersiz_Load(object sender, EventArgs e)
        {
            // Egzersiz isimleri ve açıklamaları
            egzersizler = new Dictionary<string, string>
            {
                { "Koşu", "Koşu, tüm vücudu çalıştıran, kalp ve akciğer kapasitesini artırır." },
                { "Yüzme", "Yüzme, düşük etkili bir egzersiz olup tüm kasları çalıştırır." },
                { "Bisiklet", "Bisiklet sürmek, bacak kaslarını güçlendirir ve kalp sağlığını destekler." },
                { "Yoga", "Yoga, esnekliği ve zihinsel rahatlamayı artırır." },
                { "Pilates", "Pilates, core kaslarını güçlendirir ve vücut duruşunu düzeltir." },
                { "Ağırlık Antrenmanı", "Kas kütlesini artırır ve metabolizmayı hızlandırır." },
                { "Zumba", "Zumba, müzik eşliğinde yapılan enerjik bir kardiyo egzersizidir." },
                { "HIT", "Kısa süreli yüksek yoğunluklu egzersizlerle yapılan antrenmandır." },
                { "Doğa Yürüyüşü", "Hem kondisyonu geliştirir hem de doğada zaman geçirerek zihni rahatlatır." },
                { "İp Atlama", "İp atlama, yüksek kalori yaktıran etkili bir kardiyo egzersizidir." }
            };

            // comboBox'a egzersizleri ekleyelim
            comboBox1.Items.AddRange(egzersizler.Keys.ToArray());

            // Seçim değişince açıklama gelsin
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();

            // Favorilendi mi diye kontrol ediyoruz
            string temizIsim = secilen.Replace(" (Favorilendi)", "");

            if (egzersizler.ContainsKey(temizIsim))
            {
                label2.MaximumSize = new Size(350, 0);
                label2.AutoSize = true;
                label2.TextAlign = ContentAlignment.TopLeft;
                label2.Text = egzersizler[temizIsim];
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Favorile
            if (comboBox1.SelectedItem != null)
            {
                string secilen = comboBox1.SelectedItem.ToString();

                if (!secilen.EndsWith("(Favorilendi)"))
                {
                    // Seçilen öğeyi güncelle
                    int index = comboBox1.SelectedIndex;
                    comboBox1.Items[index] = secilen + " (Favorilendi)";
                    comboBox1.SelectedIndex = index; // Seçimi koru
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir egzersiz seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            // Favoriyi kaldır
            if (comboBox1.SelectedItem != null)
            {
                string secilen = comboBox1.SelectedItem.ToString();

                if (secilen.EndsWith("(Favorilendi)"))
                {
                    int index = comboBox1.SelectedIndex;
                    string temizIsim = secilen.Replace(" (Favorilendi)", "");
                    comboBox1.Items[index] = temizIsim;
                    comboBox1.SelectedIndex = index; // Seçimi koru
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir egzersiz seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Anasayfaya dön
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}
