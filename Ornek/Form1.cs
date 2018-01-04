using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ornek
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int sayi = 0;
                while (true)
                {
                    Random rnd = new Random();
                    sayi = rnd.Next(10);
                    bool durum = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (dizi[j] == sayi)
                        {
                            durum = true;
                        }
                    }

                    if (!durum)
                    {
                        break;
                    }

                }

                dizi[i] = sayi;
            }
            int sayac = 0;
            foreach (Button btn in panel1.Controls )
            {
                btn.Text = dizi[sayac].ToString();
                sayac++;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AnaForm frm = (AnaForm)Application.OpenForms[0];
            string metin = frm.txtMetinKutusu.Text;
            metin += "0";
            frm.txtMetinKutusu.Text = metin;
        }
    }
}
