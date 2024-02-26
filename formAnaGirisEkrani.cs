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
     partial class formAnaGirisEkrani : Form
    {
        Banka banka;
        public formAnaGirisEkrani(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void btnMusteriGirisi_Click(object sender, EventArgs e)
        {
            string musteriNumarasi = txtNo.Text;
            string sifre = txtSifre.Text;
            foreach (BireyselMusteri bireyselMusteri in banka.BireyselMusteriler)
            {
                if (musteriNumarasi == bireyselMusteri.ID && sifre == bireyselMusteri.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    formMusteriIslem formMusteri = new formMusteriIslem(banka, bireyselMusteri);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz sayın " + bireyselMusteri.Ad + " " + bireyselMusteri.Soyad);

                }
            }
            foreach (TicariMusteri ticariMusteri in banka.TicariMusteriler)
            {
                if (musteriNumarasi == ticariMusteri.ID && sifre == ticariMusteri.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    formMusteriIslem formMusteri = new formMusteriIslem(banka, ticariMusteri);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz sayın " + ticariMusteri.Ad + " " + ticariMusteri.Soyad);

                }
            }
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            string kullaniciNumarasi = txtNo.Text;
            string sifre = txtSifre.Text;

            foreach (Personel personel in banka.Personeller)
            {
                if (kullaniciNumarasi == personel.ID && sifre == personel.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = form1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();
                    formPersonelIslem formPersonel = new formPersonelIslem(banka);
                    formPersonel.TopLevel = false;
                    panel1.Controls.Add(formPersonel);
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show("Hoşgeldiniz Sayın " + personel.Ad + " " + personel.Soyad);
                }

            }
        }

        private void btnYetkiliGirisi_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            formYetkiliIslem formYetkili = new formYetkiliIslem(banka);
            formYetkili.TopLevel = false;
            panel1.Controls.Add(formYetkili);
            formYetkili.Show();
            formYetkili.Dock = DockStyle.Fill;
        }
    }
}
