using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Hatirlaticim
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:
** ÖĞRENCİ ADI............:Bedirhan YİBER   
** ÖĞRENCİ NUMARASI.......:b191200031
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            button1.Enabled = true;
            if(dateTimePicker1.Value<=DateTime.Now)
            {
                timer1.Stop();
                SoundPlayer player = new SoundPlayer();
                string sarkiyol = Application.StartupPath + "//alarm.wav";
                player.SoundLocation = sarkiyol;
                player.Play();
                a = 1;
            }
            button2.Enabled = true;
            if(a==1)
            { 
               frmMesaj frm = new frmMesaj();
                frm.StartPosition = FormStartPosition.Manual;
                    frm.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);
                frm.mesaj = mesaj;
                frm.ShowDialog();

            
            }
        }
        public String mesaj = "";
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            mesaj = textBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Enabled = false;


        }

    }
}
