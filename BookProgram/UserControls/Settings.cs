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
    public partial class Settings : UserControl {
        public Settings() {
            InitializeComponent();
            openFileDialog1.Filter = "global programm files (*.bm)|*.bm";
        }
        private void pictureBox2_Click(object sender, EventArgs e) { Hide(); }
        private void pictureBox1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                path.Text = openFileDialog1.FileName;  
        }
        private void Settings_Load(object sender, EventArgs e) {
            path.Text = CForm.selfref.set.path_global_file;
            height_f.Value = CForm.selfref.set.height_form;
            width_f.Value = CForm.selfref.set.width_form;
            full.Checked = CForm.selfref.set.fullscreen;
        }
        private void savebtn_Click(object sender, EventArgs e) {
            CForm.selfref.set.path_global_file=path.Text;
            CForm.selfref.set.height_form= Convert.ToInt32(height_f.Value);
            CForm.selfref.set.width_form= Convert.ToInt32(width_f.Value);
            CForm.selfref.set.fullscreen=full.Checked;
            CForm.selfref.save_settings_to_file();
        }
    }
}
