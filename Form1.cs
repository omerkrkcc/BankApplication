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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banka banka = new Banka();
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            formAnaGirisEkrani formAnaGiris = new formAnaGirisEkrani(banka);
            formAnaGiris.TopLevel = false;
            panel1.Controls.Add(formAnaGiris);
            formAnaGiris.Show();
            formAnaGiris.Dock = DockStyle.Fill;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
