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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void pnl_veri_Click(object sender, EventArgs e)
        {
            veri veriForm = new veri();
            veriForm.Show();
            this.Hide();
        }

        private void pnl_diyet_Click(object sender, EventArgs e)
        {
            diyet diyetForm = new diyet();
            diyetForm.Show();
            this.Hide();
        }

        private void pnl_egzersiz_Click(object sender, EventArgs e)
        {
            egzersiz egzersizForm = new egzersiz();
            egzersizForm.Show();
            this.Hide();
        }

        private void pnl_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
