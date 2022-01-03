using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private char _islem;
        private bool _ekrantemilzenecekmi;
        private int _ilkgirilensayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void EkranTemizle()
        {
            if (_ekrantemilzenecekmi==true)
            {
                label1.Text = "";
                _ekrantemilzenecekmi = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text=="0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EkranTemizle();
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemilzenecekmi = true;
            _ilkgirilensayı = Convert.ToInt32(label1.Text);
            EkranTemizle();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(label1.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkgirilensayı + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkgirilensayı - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkgirilensayı * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkgirilensayı / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemilzenecekmi = true;
            _ilkgirilensayı = Convert.ToInt32(label1.Text);
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemilzenecekmi = true;
            _ilkgirilensayı = Convert.ToInt32(label1.Text);
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemilzenecekmi = true;
            _ilkgirilensayı = Convert.ToInt32(label1.Text);
            
        }
    }
}
