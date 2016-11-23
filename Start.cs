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

namespace WindowsFormsApplication1
{
    public partial class Start : Form
    {
        

        Image background = Resources.witcher44;
        Image begin_red = Resources.BEGIN;
        Image begin = Resources.beginB;

        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EXIT.BackColor = Color.Transparent;
            EXIT2.BackColor = Color.Transparent;
        }

        private void EXIT_MouseEnter_1(object sender, EventArgs e)
        {
            EXIT.Visible = false;
            EXIT2.Visible = true;
        }

        private void EXIT2_MouseLeave(object sender, EventArgs e)
        {
            EXIT.Visible = true;
            EXIT2.Visible = false;
        }

        private void EXIT2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}