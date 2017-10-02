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
            panel3.Controls.Clear();
            Spravochnik_1 it = new Spravochnik_1();
            it.Dock = DockStyle.Fill;
            panel3.Controls.Add(it);
            panel3.Controls.SetChildIndex(it, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Spravochnik_2 it = new Spravochnik_2();
            it.Dock = DockStyle.Fill;
            panel3.Controls.Add(it);
            panel3.Controls.SetChildIndex(it, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Spravochnik_4 it = new Spravochnik_4();
            it.Dock = DockStyle.Fill;
            panel3.Controls.Add(it);
            panel3.Controls.SetChildIndex(it, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Spravochnik_3 it = new Spravochnik_3();
            it.Dock = DockStyle.Fill;
            panel3.Controls.Add(it);
            panel3.Controls.SetChildIndex(it, 0);
        }
    }
}
