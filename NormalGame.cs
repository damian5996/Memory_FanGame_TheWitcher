using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class NormalGame : Form
    {
        Thread Close6;
        #region IMAGE
        Image caranthir = Resources.caranthirN;
        Image geralt_ciri = Resources.geralt_ciriN;
        Image jaskier = Resources.jaskierN;
        Image eskel = Resources.EskelN;
        Image keira = Resources.keiraN;
        Image triss2 = Resources.triss2N;
        Image triss = Resources.trissN;
        Image wight = Resources.wightN;
        Image yen = Resources.yenN;
        Image logo = Resources.backN;
        #endregion

        public int[] tab = new int[18];
        public int[] klik = new int[2];
        private int counter = 0;
        private int score;
        private int count_caranthir = 60;
        private int count_geralt_ciri = 60;
        private int count_jaskier = 60;
        private int count_eskel = 60;
        private int count_keira = 60;
        private int count_triss2 = 60;
        private int count_triss = 60;
        private int count_wight = 60;
        private int count_yen = 60;

        public NormalGame()
        {
            #region Random
            Random rnd = new Random();
            int a, b;
            int i = 0;
            while (i < 18)
            {
                a = rnd.Next(0, 9);
                b = 0;
                for (int j = 0; j < i; j++)
                {
                    if (tab[j] == a)
                        b++;
                }
                if (b < 2)
                {
                    tab[i] = a;
                    i++;
                }
            }
            #endregion

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[0] == 0)
                {
                    button1.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[0] == 1)
                {
                    button1.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[0] == 2)
                {
                    button1.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[0] == 3)
                {
                    button1.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[0] == 4)
                {
                    button1.Image = keira;
                    count_keira -= 5;
                }
                if (tab[0] == 5)
                {
                    button1.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[0] == 6)
                {
                    button1.Image = triss;
                    count_triss -= 5;
                }
                if (tab[0] == 7)
                {
                    button1.Image = wight;
                    count_wight -= 5;
                }
                if (tab[0] == 8)
                {
                    button1.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[0];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {   
                if (tab[1] == 0)
                {
                    button2.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[1] == 1)
                {
                    button2.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[1] == 2)
                {
                    button2.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[1] == 3)
                {
                    button2.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[1] == 4)
                {
                    button2.Image = keira;
                    count_keira -= 5;
                }
                if (tab[1] == 5)
                {
                    button2.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[1] == 6)
                {
                    button2.Image = triss;
                    count_triss -= 5;
                }
                if (tab[1] == 7)
                {
                    button2.Image = wight;
                    count_wight -= 5;
                }
                if (tab[1] == 8)
                {
                    button2.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[1];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[2] == 0)
                {
                    button3.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[2] == 1)
                {
                    button3.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[2] == 2)
                {
                    button3.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[2] == 3)
                {
                    button3.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[2] == 4)
                {
                    button3.Image = keira;
                    count_keira -= 5;
                }
                if (tab[2] == 5)
                {
                    button3.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[2] == 6)
                {
                    button3.Image = triss;
                    count_triss -= 5;
                }
                if (tab[2] == 7)
                {
                    button3.Image = wight;
                    count_wight -= 5;
                }
                if (tab[2] == 8)
                {
                    button3.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[2];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[3] == 0)
                {
                    button4.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[3] == 1)
                {
                    button4.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[3] == 2)
                {
                    button4.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[3] == 3)
                {
                    button4.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[3] == 4)
                {
                    button4.Image = keira;
                    count_keira -= 5;
                }
                if (tab[3] == 5)
                {
                    button4.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[3] == 6)
                {
                    button4.Image = triss;
                    count_triss -= 5;
                }
                if (tab[3] == 7)
                {
                    button4.Image = wight;
                    count_wight -= 5;
                }
                if (tab[3] == 8)
                {
                    button4.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[3];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[4] == 0)
                {
                    button5.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[4] == 1)
                {
                    button5.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[4] == 2)
                {
                    button5.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[4] == 3)
                {
                    button5.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[4] == 4)
                {
                    button5.Image = keira;
                    count_keira -= 5;
                }
                if (tab[4] == 5)
                {
                    button5.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[4] == 6)
                {
                    button5.Image = triss;
                    count_triss -= 5;
                }
                if (tab[4] == 7)
                {
                    button5.Image = wight;
                    count_wight -= 5;
                }
                if (tab[4] == 8)
                {
                    button5.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[4];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[5] == 0)
                {
                    button6.Image = caranthir;
                    count_caranthir -= 5;
                }
                if (tab[5] == 1)
                {
                    button6.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[5] == 2)
                {
                    button6.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[5] == 3)
                {
                    button6.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[5] == 4)
                {
                    button6.Image = keira;
                    count_keira -= 5;
                }
                if (tab[5] == 5)
                {
                    button6.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[5] == 6)
                {
                    button6.Image = triss;
                    count_triss -= 5;
                }
                if (tab[5] == 7)
                {
                    button6.Image = wight;
                    count_wight -= 5;
                }
                if (tab[5] == 8)
                {
                    button6.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[5];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[6] == 0)
                {
                    button7.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[6] == 1)
                {
                    button7.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[6] == 2)
                {
                    button7.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[6] == 3)
                {
                    button7.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[6] == 4)
                {
                    button7.Image = keira;
                    count_keira -= 5;
                }
                if (tab[6] == 5)
                {
                    button7.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[6] == 6)
                {
                    button7.Image = triss;
                    count_triss -= 5;
                }
                if (tab[6] == 7)
                {
                    button7.Image = wight;
                    count_wight -= 5;
                }
                if (tab[6] == 8)
                {
                    button7.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[6];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[7] == 0)
                {
                    button8.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[7] == 1)
                {
                    button8.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[7] == 2)
                {
                    button8.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[7] == 3)
                {
                    button8.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[7] == 4)
                {
                    button8.Image = keira;
                    count_keira -= 5;
                }
                if (tab[7] == 5)
                {
                    button8.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[7] == 6)
                {
                    button8.Image = triss;
                    count_triss -= 5;
                }
                if (tab[7] == 7)
                {
                    button8.Image =wight;
                    count_wight -= 5;
                }
                if (tab[7] == 8)
                {
                    button8.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[7];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[8] == 0)
                {
                    button9.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[8] == 1)
                {
                    button9.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[8] == 2)
                {
                    button9.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[8] == 3)
                {
                    button9.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[8] == 4)
                {
                    button9.Image = keira;
                    count_keira -= 5;
                }
                if (tab[8] == 5)
                {
                    button9.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[8] == 6)
                {
                    button9.Image = triss;
                    count_triss -= 5;
                }
                if (tab[8] == 7)
                {
                    button9.Image = wight;
                    count_wight -= 5;
                }
                if (tab[8] == 8)
                {
                    button9.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[9];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[9] == 0)
                {
                    button10.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[9] == 1)
                {
                    button10.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[9] == 2)
                {
                    button10.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[9] == 3)
                {
                    button10.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[9] == 4)
                {
                    button10.Image = keira;
                    count_keira -= 5;
                }
                if (tab[9] == 5)
                {
                    button10.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[9] == 6)
                {
                    button10.Image = triss;
                    count_triss -= 5;
                }
                if (tab[9] == 7)
                {
                    button10.Image = wight;
                    count_wight -= 5;
                }
                if (tab[9] == 8)
                {
                    button10.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[9];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[10] == 0)
                {
                    button11.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[10] == 1)
                {
                    button11.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[10] == 2)
                {
                    button11.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[10] == 3)
                {
                    button11.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[10] == 4)
                {
                    button11.Image = keira;
                    count_keira -= 5;
                }
                if (tab[10] == 5)
                {
                    button11.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[10] == 6)
                {
                    button11.Image = triss;
                    count_triss -= 5;
                }
                if (tab[10] == 7)
                {
                    button11.Image = wight;
                    count_wight -= 5;
                }
                if (tab[10] == 8)
                {
                    button11.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[10];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[11] == 0)
                {
                    button12.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[11] == 1)
                {
                    button12.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[11] == 2)
                {
                    button12.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[11] == 3)
                {
                    button12.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[11] == 4)
                {
                    button12.Image = keira;
                    count_keira -= 5;
                }
                if (tab[11] == 5)
                {
                    button12.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[11] == 6)
                {
                    button12.Image = triss;
                    count_triss -= 5;
                }
                if (tab[11] == 7)
                {
                    button12.Image = wight;
                    count_wight -= 5;
                }
                if (tab[11] == 8)
                {
                    button12.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[11];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[12] == 0)
                {
                    button13.Image = caranthir;
                    count_caranthir -= 5;
                }
                if (tab[12] == 1)
                {
                    button13.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[12] == 2)
                {
                    button13.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[12] == 3)
                {
                    button13.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[12] == 4)
                {
                    button13.Image = keira;
                    count_keira -= 5;
                }
                if (tab[12] == 5)
                {
                    button13.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[12] == 6)
                {
                    button13.Image = triss;
                    count_triss -= 5;
                }
                if (tab[12] == 7)
                {
                    button13.Image =wight;
                    count_wight -= 5;
                }
                if (tab[12] == 8)
                {
                    button13.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[12];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[13] == 0)
                {
                    button14.Image = caranthir;
                    count_caranthir -= 5;
                }
                if (tab[13] == 1)
                {
                    button14.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[13] == 2)
                {
                    button14.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[13] == 3)
                {
                    button14.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[13] == 4)
                {
                    button14.Image = keira;
                    count_keira -= 5;
                }
                if (tab[13] == 5)
                {
                    button14.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[13] == 6)
                {
                    button14.Image = triss;
                    count_triss -= 5;
                }
                if (tab[13] == 7)
                {
                    button14.Image = wight;
                    count_wight -= 5;
                }
                if (tab[13] == 8)
                {
                    button14.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[13];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[14] == 0)
                {
                    button15.Image = caranthir;
                    count_caranthir -= 5;
                }
                if (tab[14] == 1)
                {
                    button15.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[14] == 2)
                {
                    button15.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[14] == 3)
                {
                    button15.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[14] == 4)
                {
                    button15.Image = keira;
                    count_keira -= 5;
                }
                if (tab[14] == 5)
                {
                    button15.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[14] == 6)
                {
                    button15.Image = triss;
                    count_triss -= 5;
                }
                if (tab[14] == 7)
                {
                    button15.Image = wight;
                    count_wight -= 5;
                }
                if (tab[14] == 8)
                {
                    button15.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[14];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[15] == 0)
                {
                    button16.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[15] == 1)
                {
                    button16.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[15] == 2)
                {
                    button16.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[15] == 3)
                {
                    button16.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[15] == 4)
                {
                    button16.Image = keira;
                    count_keira -= 5;
                }
                if (tab[15] == 5)
                {
                    button16.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[15] == 6)
                {
                    button16.Image = triss;
                    count_triss -= 5;
                }
                if (tab[15] == 7)
                {
                    button16.Image = wight;
                    count_wight -= 5;
                }
                if (tab[15] == 8)
                {
                    button16.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[15];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[16] == 0)
                {
                    button17.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[16] == 1)
                {
                    button17.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[16] == 2)
                {
                    button17.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[16] == 3)
                {
                    button17.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[16] == 4)
                {
                    button17.Image = jaskier;
                    count_keira -= 5;
                }
                if (tab[16] == 5)
                {
                    button17.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[16] == 6)
                {
                    button17.Image = triss;
                    count_triss -= 5;
                }
                if (tab[16] == 7)
                {
                    button17.Image = wight;
                    count_wight -= 5;
                }
                if (tab[16] == 8)
                {
                    button17.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[16];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                if (tab[17] == 0)
                {
                    button18.Image = caranthir;
                    count_caranthir -= 5;

                }
                if (tab[17] == 1)
                {
                    button18.Image = geralt_ciri;
                    count_geralt_ciri -= 5;
                }
                if (tab[17] == 2)
                {
                    button18.Image = jaskier;
                    count_jaskier -= 5;
                }
                if (tab[17] == 3)
                {
                    button18.Image = eskel;
                    count_eskel -= 5;
                }
                if (tab[17] == 4)
                {
                    button18.Image = keira;
                    count_keira -= 5;
                }
                if (tab[17] == 5)
                {
                    button18.Image = triss2;
                    count_triss2 -= 5;
                }
                if (tab[17] == 6)
                {
                    button18.Image = triss;
                    count_triss -= 5;
                }
                if (tab[17] == 7)
                {
                    button18.Image = wight;
                    count_wight -= 5;
                }
                if (tab[17] == 8)
                {
                    button18.Image = yen;
                    count_yen -= 5;
                }
                klik[counter] = tab[17];
                counter++;
            }
            else
            {
                reset();
                if (klik[0] == klik[1])
                    delete(klik[0]);
            }
        }
        private void reset()
        {
               button1.Image = logo;
               button2.Image = logo;
               button3.Image = logo;
               button4.Image = logo;
               button5.Image = logo;
               button6.Image = logo;
               button7.Image = logo;
               button8.Image = logo;
               button9.Image = logo;
               button10.Image = logo;
               button11.Image = logo;
               button12.Image = logo;
               button13.Image = logo;
               button14.Image = logo;
               button15.Image = logo;
               button16.Image = logo;
               button17.Image = logo;
               button18.Image = logo;

            counter = 0;
        }

        private void delete(int a)
        {
            #region delete
            if (tab[0] == a)
            {
                button1.Visible = false;
            }
            if (tab[1] == a)
            {
                button2.Visible = false;
            }
            if (tab[2] == a)
            {
                button3.Visible = false;
            }
            if (tab[3] == a)
            {
                button4.Visible = false;
            }
            if (tab[4] == a)
            {
                button5.Visible = false;
            }
            if (tab[5] == a)
            {
                button6.Visible = false;
            }
            if (tab[6] == a)
            {
                button7.Visible = false;
            }
            if (tab[7] == a)
            {
                button8.Visible = false;
            }
            if (tab[8] == a)
            {
                button9.Visible = false;
            }
            if (tab[9] == a)
            {
                button10.Visible = false;
            }
            if (tab[10] == a)
            {
                button11.Visible = false;
            }
            if (tab[11] == a)
            {
                button12.Visible = false;
            }
            if (tab[12] == a)
            {
                button13.Visible = false;
            }
            if (tab[13] == a)
            {
                button14.Visible = false;
            }
            if (tab[14] == a)
            {
                button15.Visible = false;
            }
            if (tab[15] == a)
            {
                button16.Visible = false;
            }
            if (tab[16] == a)
            {
                button17.Visible = false;
            }
            if (tab[17] == a)
            {
                button18.Visible = false;
            }
            #endregion
            #region counting score
            
            if (a == 0)
            {
                score += count_caranthir;
                label1.Text = score.ToString();
            }
            if (a == 1)
            {
                score += count_geralt_ciri;
                label1.Text = score.ToString();
            }
            if (a == 2)
            {
                score += count_jaskier;
                label1.Text = score.ToString();
            }
            if (a == 3)
            {
                score += count_eskel;
                label1.Text = score.ToString();
            }
            if (a == 4)
            {
                score += count_keira;
                label1.Text = score.ToString();
            }
            if (a == 5)
            {
                score += count_triss2;
                label1.Text = score.ToString();
            }
            if (a == 6)
            {
                score += count_triss;
                label1.Text = score.ToString();
            }
            if (a == 7)
            {
                score += count_wight;
                label1.Text = score.ToString();
            }
            if (a == 8)
            {
                score += count_yen;
                label1.Text = score.ToString();
            }
            #endregion
        }
    
    #region BACK
    private void BACK_MouseEnter(object sender, EventArgs e)
        {
            BACK.Visible = false;
            BACK2.Visible = true;
        }

        private void BACK2_MouseLeave(object sender, EventArgs e)
        {
            BACK.Visible = true;
            BACK2.Visible = false;
        }

        private void BACK2_Click(object sender, EventArgs e)
        {
            this.Close();
            Close6 = new Thread(previousForm2);
            Close6.SetApartmentState(ApartmentState.STA);
            Close6.Start();
        }
        private void previousForm2()
        {
            Application.Run(new ChooseLevel());
        }
        #endregion
    }
}
