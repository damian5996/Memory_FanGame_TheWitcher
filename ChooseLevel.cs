using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChooseLevel : Form
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void EASY_MouseEnter(object sender, EventArgs e)
        {
            EASY.Visible = false;
            EASY2.Visible = true;
        }

        private void EASY2_MouseLeave(object sender, EventArgs e)
        {
            EASY.Visible = true;
            EASY2.Visible = false;
        }

        private void NORMAL_MouseEnter(object sender, EventArgs e)
        {
            NORMAL.Visible = false;
            NORMAL2.Visible = true;
        }

        private void NORMAL2_MouseLeave(object sender, EventArgs e)
        {
            NORMAL.Visible = true;
            NORMAL2.Visible = false;
        }

        private void HARD_MouseEnter(object sender, EventArgs e)
        {
            HARD.Visible = false;
            HARD2.Visible = true;
        }

        private void HARD2_MouseLeave(object sender, EventArgs e)
        {
            HARD.Visible = true;
            HARD2.Visible = false;
        }

        private void EXIT2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EXIT_MouseEnter(object sender, EventArgs e)
        {
            EXIT.Visible = false;
            EXIT2.Visible = true;
        }

        private void EXIT2_MouseLeave(object sender, EventArgs e)
        {
            EXIT.Visible = true;
            EXIT2.Visible = false;
        }
    }
}
