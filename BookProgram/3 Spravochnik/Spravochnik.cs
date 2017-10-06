using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram {
    public partial class Spravochnik : UserControl {
        public Spravochnik() {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            obhi.Visible = true;
            anglrus.Visible = false;
            ima.Visible = false;
            mifol.Visible = false;
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            obhi.Visible = false;
            anglrus.Visible = false;
            ima.Visible = true;
            mifol.Visible = false;
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            obhi.Visible = false;
            anglrus.Visible = true;
            ima.Visible = false;
            mifol.Visible = false;
        }

       
        private void pictureBox4_Click(object sender, EventArgs e)
        { 
            obhi.Visible = false;
            anglrus.Visible = false;
            ima.Visible = false;
            mifol.Visible = true;
        }


    }
}
