using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gün_saat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime gun1 = dateTimePicker1.Value;
            DateTime gun2 = dateTimePicker2.Value;


            System.TimeSpan zaman;
            zaman = gun2.Subtract(gun1);

            //gün yazdırıyoruz
            int gun = Convert.ToInt32(zaman.TotalDays);
            label4gun.Text = gun.ToString("N") + "  " + "Gün Nefes alıyorsun   ";

            //ay yazdırıyorsun
            int ay = Convert.ToInt32(zaman.TotalDays) / 30;
            label5Ay.Text = ay.ToString("N") + "  " + " Ay Nefes Alıyorsun ";

            //saat yazdırıyoruz
            int saat = Convert.ToInt32(zaman.TotalHours);
            label5saat.Text = saat.ToString("N") + "  " + "Saat Nefes Alıyorsun   ";

            //dakika yazdıyoruz
            int dakika = Convert.ToInt32(zaman.TotalMinutes);
            label8dakika.Text = dakika.ToString("N") + "  " + "Dakika Nefes Alıyorsun  ";

            //saniye yazdıryoruz
            int saniye = Convert.ToInt32(zaman.TotalSeconds);
            label10saniye.Text = saniye.ToString("N") + "  " + "Saniye Nefes Alıyorsun   ";




        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
