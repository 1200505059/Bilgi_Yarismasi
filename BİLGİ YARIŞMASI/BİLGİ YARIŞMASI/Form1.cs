namespace BİLGİ_YARIŞMASI
{
    public partial class Form1 : Form
    {
        int soruNo = 0;
        int dogrusay = 0;
        int yanlissay = 0;
        int cevap = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void sonraki_Click(object sender, EventArgs e)

        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            cevap++;
            sonraki.Text = "SONRAKİ";

            if (cevap > 9)
            {
                sonraki.BackColor = Color.Black;
                button1.Text = "SONUÇ";
                sonraki.Enabled = false;
                button1.Enabled = true;
                button1.BackColor = Color.LimeGreen;
            }

            pictureBox1.Visible = false;
            joker1.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            soruNo++;
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;

            if (soruNo == 1)
            {
                richTextBox1.Text = " Ülkemizde 2017 yılında asgari ücret ne kadardı?";
                btnA.Text = "1400 TL";
                btnB.Text = "1850 TL";
                btnC.Text = "2250 TL";
                btnD.Text = "1600 TL";
                label1.Text = "1400 TL";
            }

            if (soruNo == 2)
            {
                richTextBox1.Text = " Futbol maçlarında oynanan topun FİFA kurallarına göre" +
                    " ağırlığı kaç gram olmalıdır?";
                btnA.Text = "454";
                btnB.Text = "453";
                btnC.Text = "452";
                btnD.Text = "455";
                label1.Text = "452";
            }

            if (soruNo == 3)
            {
                richTextBox1.Text = " Gemlerin baş kısmının adı nedir?";
                btnA.Text = "Sancak";
                btnB.Text = "İskele";
                btnC.Text = "Dümen";
                btnD.Text = "Pruva";
                label1.Text = "Pruva";
            }

            if (soruNo == 4)
            {
                richTextBox1.Text = " İslami yılbaşı hangi ay ile başlar?";
                btnA.Text = "Muharrem";
                btnB.Text = "Recep";
                btnC.Text = "Şaban";
                btnD.Text = "Şevval";
                label1.Text = "Muharrem";
            }

            if (soruNo == 5)
            {
                richTextBox1.Text = " Aya ilk defa hangi yılda ayak basılmıştır ?";
                btnA.Text = "1966";
                btnB.Text = "1929";
                btnC.Text = "1959";
                btnD.Text = "1969";
                label1.Text = "1969";
            }

            if (soruNo == 6)
            {
                richTextBox1.Text = " Voleybol nerde icat edildi?";
                btnA.Text = "İspanya";
                btnB.Text = "Brezilya";
                btnC.Text = "Amerika";
                btnD.Text = "İngiltere";
                label1.Text = "Amerika";
            }

            if (soruNo == 7)
            {
                richTextBox1.Text = "Avrupa şampiyonu ilk Türk boksör kimdir?";
                btnA.Text = "Abdullah Tomba";
                btnB.Text = "Cemal Kamacı";
                btnC.Text = "Malik Beyleroğlu";
                btnD.Text = "Sıtkı Piran";
                label1.Text = "Cemal Kamacı";
            }

            if (soruNo == 8)
            {
                richTextBox1.Text = " Futbolda dünya kupasını ilk kez hangi ülke kazanmıştır?";
                btnA.Text = "İngiltere";
                btnB.Text = "Uruguay";
                btnC.Text = "Brezilya";
                btnD.Text = "Fransa";
                label1.Text = "Uruguay";
            }

            if (soruNo == 9)
            {
                richTextBox1.Text = "Aspirinin ilk kez çıkış yılı nedir?";
                btnA.Text = "1912";
                btnB.Text = "1903";
                btnC.Text = "1907";
                btnD.Text = "1899";
                label1.Text = "1899";
            }

            if (soruNo == 10)
            {
                richTextBox1.Text = "Türkiye' de toplam kaç adet ilçe vardır?";
                btnA.Text = "922";
                btnB.Text = "928";
                btnC.Text = "930";
                btnD.Text = "951";
                label1.Text = "922";
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (button8.Enabled == true)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                label2.Text = btnA.Text;
                if (label2.Text == label1.Text)
                {
                    dogrusay++;
                    btnA.BackColor = Color.YellowGreen;

                }
                else
                {
                    yanlissay++;
                    btnA.BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;

                    label2.Text = btnA.Text;
                    if (label2.Text == label1.Text)
                    {
                        dogrusay++;
                        btnA.BackColor = Color.YellowGreen;

                    }
                    else
                    {
                        yanlissay++;
                        btnA.BackColor = Color.Red;
                    }
                }
            }




        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (button8.Enabled == true)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                label2.Text = btnB.Text;
                if (label2.Text == label1.Text)
                {
                    dogrusay++;
                    btnB.BackColor = Color.YellowGreen;

                }
                else
                {
                    yanlissay++;
                    btnB.BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;

                    label2.Text = btnB.Text;
                    if (label2.Text == label1.Text)
                    {
                        dogrusay++;
                        btnB.BackColor = Color.YellowGreen;

                    }
                    else
                    {
                        yanlissay++;
                        btnB.BackColor = Color.Red;
                    }
                }
            }



        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (button8.Enabled == true)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                label2.Text = btnC.Text;
                if (label2.Text == label1.Text)
                {
                    dogrusay++;
                    btnC.BackColor = Color.YellowGreen;

                }
                else
                {
                    yanlissay++;
                    btnC.BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;

                    label2.Text = btnC.Text;
                    if (label2.Text == label1.Text)
                    {
                        dogrusay++;
                        btnC.BackColor = Color.YellowGreen;

                    }
                    else
                    {
                        yanlissay++;
                        btnC.BackColor = Color.Red;
                    }
                }
            }



        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (button8.Enabled == true)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                label2.Text = btnD.Text;
                if (label2.Text == label1.Text)
                {
                    dogrusay++;
                    btnD.BackColor = Color.YellowGreen;

                }
                else
                {
                    yanlissay++;
                    btnD.BackColor = Color.Red;
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;

                    label2.Text = btnD.Text;
                    if (label2.Text == label1.Text)
                    {
                        dogrusay++;
                        btnD.BackColor = Color.YellowGreen;

                    }
                    else
                    {
                        yanlissay++;
                        btnD.BackColor = Color.Red;
                    }
                }
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            joker1.Visible = true;
            pictureBox2.Visible = true;
            joker1.Text = "seyirciler: %72" + " " + label1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            joker1.Visible = true;
            pictureBox1.Visible = true;
            joker1.Text = "Ahmet Bey :Cevap" + " " + label1.Text + " Eminim.";
        }

        private void button6_Click(object sender, EventArgs e)
        {


            button6.Enabled = false;
            if (soruNo == 1)
            {
                btnB.Enabled = false;
                btnD.Enabled = false;
                btnB.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }

            if (soruNo == 2)
            {
                btnA.Enabled = false;
                btnD.Enabled = false;
                btnA.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }

            if (soruNo == 3)
            {
                btnB.Enabled = false;
                btnA.Enabled = false;
                btnB.BackColor = Color.Red;
                btnA.BackColor = Color.Red;
            }

            if (soruNo == 4)
            {
                btnB.Enabled = false;
                btnD.Enabled = false;
                btnB.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }

            if (soruNo == 5)
            {
                btnB.Enabled = false;
                btnA.Enabled = false;
                btnB.BackColor = Color.Red;
                btnA.BackColor = Color.Red;
            }

            if (soruNo == 6)
            {
                btnB.Enabled = false;
                btnA.Enabled = false;
                btnB.BackColor = Color.Red;
                btnA.BackColor = Color.Red;
            }

            if (soruNo == 7)
            {
                btnA.Enabled = false;
                btnD.Enabled = false;
                btnA.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }

            if (soruNo == 8)
            {
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnC.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }

            if (soruNo == 9)
            {
                btnA.Enabled = false;
                btnC.Enabled = false;
                btnA.BackColor = Color.Red;
                btnC.BackColor = Color.Red;
            }

            if (soruNo == 10)
            {
                btnB.Enabled = false;
                btnD.Enabled = false;
                btnB.BackColor = Color.Red;
                btnD.BackColor = Color.Red;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;





        }

        private void basla_Click(object sender, EventArgs e)
        {

            panel.Visible = false;
            basla.Visible = false;
            baslik.Visible = false;
            button1.Visible = true;
        }



        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            label4.Visible = true;
            label5.Text = "DOĞRU:" + " " + dogrusay;
            label6.Text = "YANLIŞ:" + " " + yanlissay;
            label6.BackColor = Color.Red;
            label5.BackColor = Color.LimeGreen;

            richTextBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

