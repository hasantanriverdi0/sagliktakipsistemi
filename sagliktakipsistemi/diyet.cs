using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sagliktakipsistemi
{
    public partial class diyet : Form
    {
        private Dictionary<string, string> diyetler;
        private Dictionary<string, bool> favoriDurumu;

        public diyet()
        {
            InitializeComponent();
        }

        private void diyet_Load(object sender, EventArgs e)
        {
            // Diyetleri ve açıklamalarını dictionary'e ekliyoruz
            diyetler = new Dictionary<string, string>
            {
                { "Akdeniz Diyeti", "Akdeniz diyeti, özellikle zeytinyağı, sebzeler, meyveler, balık ve deniz ürünleri gibi sağlıklı besinlerle beslenmeyi hedefler. " +
                                     "Bu diyette kırmızı et yerine tavuk ve balık gibi daha sağlıklı protein kaynakları tercih edilir. " +
                                     "Karbonhidratlar ise tam tahıllı ürünlerden sağlanır ve sağlıklı yağlar, yani zeytinyağı, bolca tüketilir. " +
                                     "Kalp sağlığını korumaya ve uzun ömür sağlamaya yardımcı olur." },
                { "Vegan Diyeti", "Vegan diyeti, tamamen bitkisel kaynaklardan beslenmeyi amaçlayan bir diyettir. Bu diyette et, süt ürünleri ve diğer hayvansal gıdalar tüketilmez." +
                                  " Meyve, sebze, baklagiller, tahıllar ve tohumlar gibi bitkisel gıdalarla beslenilir. Protein ihtiyacı baklagiller ve tohumlardan karşılanır." +
                                  " Bu diyet, hayvan haklarına duyarlı ve çevre dostu bir beslenme biçimidir." },
                { "Düşük Karbonhidrat Diyeti", "Düşük karbonhidrat diyeti, karbonhidrat alımını sınırlayarak daha çok protein ve yağ alımına odaklanır. Bu diyette şeker ve işlenmiş gıdalar minimize edilir." +
                                               " Genellikle kilo kaybı amacıyla tercih edilir ve kan şekerini dengelemede etkilidir." +
                                               " Düşük karbonhidrat diyeti, vücutta yağ yakımını hızlandırarak hızlı kilo kaybı sağlar." },
                { "Yüksek Protein Diyeti", "Yüksek protein diyeti, vücuda daha fazla protein sağlamayı amaçlayan bir diyettir. Vücut, proteinleri kas gelişimi ve onarımında kullanır." +
                                           " Bu diyette kırmızı et, tavuk, balık, yumurta, süt ürünleri gibi protein açısından zengin gıdalar tüketilir." +
                                           " Bu diyette karbonhidratlar sınırlıdır ve kilo kaybı süreci hızlanır." },
                { "Akşam Yemeği Diyeti", "Akşam yemeği diyeti, özellikle akşam yemeğinde ağır yemeklerden kaçınmayı hedefler. Hafif, sindirimi kolay yemekler tercih edilir." +
                                         " Genellikle protein ağırlıklı ve düşük karbonhidratlı öğünler içerir. Bu diyet, sindirimi rahatlatır ve gece boyu vücudun dinlenmesine olanak tanır." },
                { "Zayıflama Diyeti", "Zayıflama diyeti, vücudun fazla yağlarını kaybetmesine yardımcı olan dengeli bir beslenme planıdır. " +
                                      "Bu diyette kalori açığı oluşturulur, yani vücuda harcadığından daha az kalori verilir. " +
                                      "Sebzeler, meyveler, düşük kalorili protein kaynakları ve tam tahıllar bu diyette öne çıkar." },
                { "Paleo Diyeti", "Paleo diyeti, evrimsel olarak insanın beslenmesine uygun olduğu düşünülen gıdaları içerir. Bu diyette, işlenmiş gıdalardan, tahıllardan ve süt ürünlerinden kaçınılır." +
                                  " Et, balık, yumurta, sebzeler, meyveler ve bazı tohumlar ana besin kaynaklarıdır. Bu diyette modern işlenmiş gıdalardan uzak durulur." },
                { "Detoks Diyeti", "Detoks diyeti, vücudun toksinlerden arınmasına yardımcı olmak için yapılan bir diyettir. Bu diyette genellikle bol su, meyve ve sebze ağırlıklı beslenme önerilir." +
                                   " Çeşitli detoks çayları, sebze suları ve sindirimi kolay gıdalar kullanılarak vücudun temizlenmesi hedeflenir." },
                { "Düşük Yağ Diyeti", "Düşük yağ diyeti, vücudun fazla yağlardan uzak durmasını sağlamak amacıyla düşük yağlı gıdaların tercih edildiği bir diyettir." +
                                     " Bu diyette özellikle doymuş yağlar sınırlanır, sebzeler, meyveler ve tam tahıllar ön planda tutulur." +
                                     " Kalp sağlığını destekler ve kilo kaybı sürecine yardımcı olur." },
                { "Karışık Diyet", "Karışık diyet, çeşitli gıda gruplarını bir arada tüketmeyi amaçlayan dengeli bir diyettir. " +
                                   "Bunda, et, süt ürünleri, sebzeler, meyveler, tahıllar ve baklagiller yer alır. Düşük kalorili, dengeli bir şekilde tüm besin gruplarını içerir." +
                                   " Hem sağlıklı beslenmeyi sağlar hem de çeşitli gıda gruplarını bir arada sunar." }
            };

            favoriDurumu = new Dictionary<string, bool>();
            foreach (var diyet in diyetler.Keys)
            {
                favoriDurumu[diyet] = false;
            }

            GuncelleComboBox();
        }

        private void GuncelleComboBox()
        {
            int eskiIndex = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();
            foreach (var diyet in diyetler.Keys)
            {
                string gosterim = favoriDurumu[diyet] ? $"{diyet} (Kaydedildi)" : diyet;
                comboBox1.Items.Add(gosterim);
            }

            if (eskiIndex >= 0 && eskiIndex < comboBox1.Items.Count)
            {
                comboBox1.SelectedIndex = eskiIndex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedDiyet = comboBox1.SelectedItem.ToString();

                if (selectedDiyet.Contains("(Kaydedildi)"))
                {
                    selectedDiyet = selectedDiyet.Replace(" (Kaydedildi)", "");
                }

                if (diyetler.ContainsKey(selectedDiyet))
                {
                    label2.MaximumSize = new Size(350, 0);
                    label2.AutoSize = true;
                    label2.TextAlign = ContentAlignment.TopLeft;
                    label2.Text = diyetler[selectedDiyet];
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Favoriye ekle
            if (comboBox1.SelectedItem != null)
            {
                string selectedDiyet = comboBox1.SelectedItem.ToString();
                if (selectedDiyet.Contains("(Kaydedildi)"))
                {
                    selectedDiyet = selectedDiyet.Replace(" (Kaydedildi)", "");
                }

                if (favoriDurumu.ContainsKey(selectedDiyet))
                {
                    favoriDurumu[selectedDiyet] = true;
                    GuncelleComboBox();
                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            // Favoriden çıkar
            if (comboBox1.SelectedItem != null)
            {
                string selectedDiyet = comboBox1.SelectedItem.ToString();
                if (selectedDiyet.Contains("(Kaydedildi)"))
                {
                    selectedDiyet = selectedDiyet.Replace(" (Kaydedildi)", "");
                }

                if (favoriDurumu.ContainsKey(selectedDiyet))
                {
                    favoriDurumu[selectedDiyet] = false;
                    GuncelleComboBox();
                }
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}
