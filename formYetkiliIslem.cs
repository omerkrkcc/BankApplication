using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaDeneme2
{
     partial class formYetkiliIslem : Form
    {
        Banka banka;
        public formYetkiliIslem(Banka banka)
        {
            this.banka = banka;
            InitializeComponent();
        }

        private void txtPersonelAdi_KeyPress(object sender,KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txtPersonelSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string Ad = txtPersonelAdi.Text;
            string Soyad = txtPersonelSoyadi.Text;
            string personelNumarasi = txtPersonelNumarasi.Text;
            string Sifre = txtPersonelSifre.Text;

            txtPersonelAdi.Clear();
            txtPersonelSoyadi.Clear();
            txtPersonelSifre.Clear();
            txtPersonelNumarasi.Clear();

            banka.PersonelEkle(Ad, Soyad, personelNumarasi, Sifre);
            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.Personeller;

            string rapor = personelNumarasi + " numara adına sahip personel bankaya eklenmiştir.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            string personelNumarasi = txtPersonelNo.Text;
            txtPersonelNo.Clear();
            banka.PersonelSil(personelNumarasi);

            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.Personeller;

            string rapor = personelNumarasi + " numara adına sahip personel bankadan silindi.";
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);
        }

        private void btnBankaIslemListele_Click(object sender, EventArgs e)
        {
            dataGridBankaIslem.DataSource = null;
            dataGridBankaIslem.DataSource = banka.BankaRaporListesi;
            lblToplamPara.Text = "Banka toplam para " + banka.toplamPara + " TL";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }

        private void btnGerıDonn_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }

        private void btnGeriDonnn_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }
    }

}
