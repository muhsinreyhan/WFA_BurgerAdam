using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BurgerAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] menuler = { "Whooper", "King Chicken", "Steak House" };
        decimal[] fiyatlar = { 10, 7, 13 };

        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboBox içerisinde dataSource özelliği object tipinde bütün nesneleri kabul eder. Bu yüzden form açıldığında tanımladığımız menüleri datasource'a aktardık.

            cmbMenu.DataSource = menuler;
        }
        decimal toplamFiyat;

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            decimal siparisFiyat = 0;
            string siparisBilgileri = string.Empty;

            siparisFiyat += fiyatlar[cmbMenu.SelectedIndex];
            siparisBilgileri += cmbMenu.SelectedItem + " ";

            if (rbKing.Checked)
            {
                siparisFiyat += 3;
                siparisBilgileri += rbKing.Text;
            }
            else if (rbBuyuk.Checked)
            {
                siparisFiyat += 2;
                siparisBilgileri += rbBuyuk.Text;
            }
            else
            {
                siparisBilgileri += rbOrta.Text;
            }

            string ekstraBilgileri = "(";

            foreach (CheckBox item in gbEkstra.Controls)
            {
                if (item.Checked)
                {
                    siparisFiyat += 0.5m;
                    ekstraBilgileri += item.Text + " ";
                }
            }
            ekstraBilgileri += ")";

            siparisBilgileri += ekstraBilgileri + " ";

            siparisFiyat *= nudAdet.Value;
            siparisBilgileri += "Adet: " + nudAdet.Value + " ";
            siparisBilgileri += "Toplam Tutar: " + siparisFiyat.ToString("C2");

            listBox1.Items.Add(siparisBilgileri);

            toplamFiyat += siparisFiyat;
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Toplam Sipariş Sayısı:{0}\nToplam Sipariş Tutarı:{1:C2}", listBox1.Items.Count, toplamFiyat));
        }
    }
}
