using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private int baslamaNoktasi = 12;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            btnbaslat.Click += Click;
            btnsifirla.Click += Click;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] AtlarınLokasyonu = Hareketettir();
            int ondekiAt = AtlarınLokasyonu.Max();
            string bilgi = string.Empty;
            string sonuc = string.Empty;

            for (int i = 0; i < AtlarınLokasyonu.Length; i++)
            {
             
                if (ondekiAt.Equals(AtlarınLokasyonu[i]))
                {
                    bilgi = $"{i + 1}. At önde";
                    if (AtlarınLokasyonu[i] >= lblFinish.Left)
                    {
                        sonuc = $"{i + 1}. At kazandı";
                    }
                }
            }
            lblCanliDurum.Text = bilgi;
            if (!string.IsNullOrEmpty(sonuc))
            {
                timer1.Stop();
                MessageBox.Show(sonuc);

            }
        }

        private int[] Hareketettir()
        {
            pbAt1.Left += rnd.Next(1, 15);
            pbAt2.Left += rnd.Next(1, 15);
            pbAt3.Left += rnd.Next(1, 15);
            return new int[] {pbAt1.Right,pbAt2.Right, pbAt3.Right};
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            object tag = btn.Tag;

            switch (tag)
            {
                case "Baslat":  Baslat();
                    break;
                case "Sifirla": Sifirla();
                    break;  
            }
        }

        private void Sifirla()
        {
            pbAt1.Left = pbAt2.Left = pbAt3.Left = baslamaNoktasi;
            lblCanliDurum.Text=string.Empty;
            btnbaslat.Enabled = true;
            timer1.Stop();
        }

        private void Baslat()
        {
            timer1.Start();
            btnbaslat.Enabled = false;  
        }
    }
}
