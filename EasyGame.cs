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
    public partial class EasyGame : Form
    {
        Thread Close7;
        Image bruxa = Resources.bruxa2E;
        Image ciri = Resources.ciriE;
        Image geralt = Resources.geraltE;
        Image logo = Resources.back1;

        public int[] tab = new int[6];
        public int[] klik = new int[2];
        private int counter = 0;
        private int score;
        private int count_bruxa = 60;
        private int count_ciri = 60;
        private int count_geralt = 60;
        public EasyGame()
        {
            #region Random
            Random rnd = new Random();
            int a, b;
            int i = 0;
            while (i < 6)
            {
                a = rnd.Next(0, 3);
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
                    button1.Image = bruxa;
                    count_bruxa -= 5;

                }
                if (tab[0] == 1)
                {
                    button1.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[0] == 2)
                {
                    button1.Image = geralt;
                    count_geralt -= 5;
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
                    button2.Image = bruxa;
                    count_bruxa -= 5;
                }
                if (tab[1] == 1)
                {
                    button2.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[1] == 2)
                {
                    button2.Image = geralt;
                    count_geralt -= 5;
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
                    button3.Image = bruxa;
                    count_bruxa -= 5;

                }
                if (tab[2] == 1)
                {
                    button3.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[2] == 2)
                {
                    button3.Image = geralt;
                    count_geralt -= 5;
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
                    button4.Image = bruxa;
                    count_bruxa -= 5;

                }
                if (tab[3] == 1)
                {
                    button4.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[3] == 2)
                {
                    button4.Image = geralt;
                    count_geralt -= 5;
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
                    button5.Image = bruxa;
                    count_bruxa -= 5;

                }
                if (tab[4] == 1)
                {
                    button5.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[4] == 2)
                {
                    button5.Image = geralt;
                    count_geralt -= 5;
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
                    button6.Image = bruxa;
                    count_bruxa -= 5;

                }
                if (tab[5] == 1)
                {
                    button6.Image = ciri;
                    count_ciri -= 5;
                }
                if (tab[5] == 2)
                {
                    button6.Image = geralt;
                    count_geralt -= 5;
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
        private void reset()
        {
            button1.Image = logo;
            button2.Image = logo;
            button3.Image = logo;
            button4.Image = logo;
            button5.Image = logo;
            button6.Image = logo;
            counter = 0;
        }
        private void delete(int a)
        {
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

            #region count_bruxa
            if (a == 0)
            {
                score += count_bruxa;
                label1.Text = score.ToString();
            }
            #endregion
            #region count_ciri
            if (a == 1)
            {
                score += count_ciri;
                label1.Text = score.ToString();
            }
            #endregion
            #region count_geralt
            if (a == 2)
            {
                score += count_geralt;
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
            Close7 = new Thread(previousForm3);
            Close7.SetApartmentState(ApartmentState.STA);
            Close7.Start();
        }
        private void previousForm3()
        {
            Application.Run(new ChooseLevel());
        }
        #endregion
    }
}