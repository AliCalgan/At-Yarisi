using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreÜretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sifreUzunlugu, sifreSayisi;
        bool buyukHarfVarMi, kuyukHarfVarMi, rakamHarfVarMi, ozelKarakterHarfVarMi;
        string sifre = string.Empty;    
        Random rnd= new Random();
        StringBuilder sb = new StringBuilder();

        private void btnSifreUret_Click(object sender, EventArgs e)
        {
            buyukHarfVarMi = chkbuyukHarf.Checked;
            kuyukHarfVarMi = chkkucukHarf.Checked;
            rakamHarfVarMi=chkrakam.Checked;
            ozelKarakterHarfVarMi = chkOzelKarakter.Checked;

            sifreUzunlugu = (int)nudSifreUzunlugu.Value;
            sifreSayisi = (int)nudSifreSayisi.Value;

            if (!(buyukHarfVarMi || kuyukHarfVarMi || ozelKarakterHarfVarMi || rakamHarfVarMi))
            {
                MessageBox.Show("Lütfen parametre seçiniz");
                return;
            }

            EkleBuyukHarf(buyukHarfVarMi);
            EkleKucukHarf(kuyukHarfVarMi);
            EkleRakam(rakamHarfVarMi);
            EkleOzelKarakter(ozelKarakterHarfVarMi);
            sifreOlustur(sifreUzunlugu, sifreSayisi);

        }

        private void EkleKucukHarf(bool kuyukHarfVarMi)
        {
            if (kuyukHarfVarMi)
            {
                for (char i = (char)97; i < 123; i++)
                {
                    sb.Append(i);
                }

            }
        }

        private void EkleBuyukHarf(bool buyukHarfVarMi)
        {
            if (buyukHarfVarMi)
            {
                for (char i = (char)65; i < 91; i++)
                {
                    sb.Append(i);
                }

            }
        }

        private void EkleRakam(bool rakamHarfVarMi)
        {
            if (rakamHarfVarMi)
            {
                for (char i = (char)48; i < 58; i++)
                {
                    sb.Append(i);
                }             

            }
        }

        private void sifreOlustur(int sifreUzunlugu, int sifreSayisi)
        {
            string randomchar = sb.ToString();
            string sifre = sb.ToString();
            int randomuzunluk = randomchar.Length;
            for (int i = 0; i < sifreSayisi; i++)
            {
                sb.Clear();
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sb.Append(randomchar[rnd.Next(0, randomuzunluk)]);
                }
                sifre = sb.ToString();
                lbSifre.Items.Add(sifre);   

            }
        }

        private void EkleOzelKarakter(bool ozelKarakterHarfVarMi)
        {
            if (ozelKarakterHarfVarMi)
            {
                for (char i = (char)33; i < 48; i++)
                {
                    sb.Append(i);
                }
                for (char i = (char)58; i < 65; i++)
                {
                    sb.Append(i);
                }

            }
        }


    }
}
