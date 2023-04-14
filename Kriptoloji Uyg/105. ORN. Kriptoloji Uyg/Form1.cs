using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _105.ORN.Kriptoloji_Uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            char[] alfabe = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'İ', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

            char[] a = new char[100];
            int[] sifre = new int[100];
            string b = richTextBox1.Text;
            int sayi = b.Length;
            int katsayi = Convert.ToInt32(metroTextBox2.Text);
            int fazla = Convert.ToInt32(metroTextBox3.Text);

            for (int i = 0; i < sayi; i++)
            {
                a[i] = Convert.ToChar(b.Substring(i, 1));
            }

            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    if (a[i] == alfabe[j])
                    {
                        sifre[i] = j;
                    }
                }
            }

            for (int i = 0; i < sayi; i++)
            {
                sifre[i] = ((sifre[i] * katsayi) + fazla) % 29;
                richTextBox2.Text += sifre[i] + " - ";
            }
            richTextBox2.Text += "\n";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            char[] a = new char[100];
            string b = richTextBox3.Text;
            int sayi = b.Length;
            int mod = Convert.ToInt32(metroTextBox1.Text);

            for (int i = 0; i < sayi; i++)
            {
                a[i] = Convert.ToChar(b.Substring(i, 1));
            }

            int adet = 0;
            char[,] dizi = new char[100, mod];

            for (int i = 0; i < sayi/mod; i++)
            {
                for (int j = 0; j < mod; j++)
                {
                    dizi[i, j] = a[adet];
                    adet++;
                }
            }

            for (int j = 0; j < mod; j++)
            {
                for (int i = 0; i < sayi/mod; i++)
                {
                    richTextBox4.Text += dizi[i, j] + " - ";
                }
                richTextBox4.Text += "\n";
            }


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int[] sifre = new int[100];
            char[] a = new char[100];
            string b = richTextBox2.Text;
            int sayi = b.Length;
            //int katsayi = Convert.ToInt32(metroTextBox2.Text);
            //int fazla = Convert.ToInt32(metroTextBox3.Text);

            for (int i = 0; i < sayi; i++)
            {
                a[i] = Convert.ToChar(b.Substring(i, 1));
            }

            int k = 0;
            int l = 0;
            while (k < sayi && l < sayi)
            {
                if (a[l] == '-')
                {
                    k++;
                    l++;
                }
                else
                {
                    sifre[k] = a[l];
                    l++;
                }
            }

            for (int i = 0; i < sayi; i++)
            {
                richTextBox1.Text += sifre[i].ToString() + "\n";
            }
        }

       
    }
}
