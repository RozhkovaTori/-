using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookProgram
{
    public partial class Start : Form
    {


        public Start()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.с_с_старт;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.к_с_старт;
            CForm f = new CForm();
            f.Show();
            Hide();
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.н_с_старт;
        }

        private void свернуть_MouseHover(object sender, EventArgs e)
        {
            свернуть.Image = Properties.Resources.с_свернуть;
        }
        private void свернуть_Click(object sender, EventArgs e)
        {
            свернуть.Image = Properties.Resources.с_к_закрыть;
            this.WindowState = FormWindowState.Minimized;
        }
        private void свернуть_MouseLeave(object sender, EventArgs e)
        {
            свернуть.Image = Properties.Resources.с_н_свернуть;
        }


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.старт_закрыть;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.с_к__закрыть;
            Application.Exit();
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.с_н_закрыть;
        }

        
    }
}
  