using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookProgram {
    public partial class Arxivper : UserControl {
        public static Arxivper selfref_Arxivper { get; set; }
        Dobnovpers select = new Dobnovpers(false, false);
        public Arxivper() {
            InitializeComponent();
            Arxivlist.Sorted = true;
            if (File.Exists(CForm.selfref.global_path_file)) {
                CForm.selfref.load_is_file(CForm.selfref.global_path_file);
                refrash_list();
                if (Arxivlist.Items.Count > 0) Arxivlist.SetSelected(0, true);
                refrash_select();
                
            }
            selfref_Arxivper = this;
            select.Dock = DockStyle.Fill;
            arhifper_body.Controls.Add(select);
            arhifper_body.Controls.SetChildIndex(select, 0);
        }
        public void refrash_list() {
            Arxivlist.Items.Clear();
            CForm.selfref.save_to_file(CForm.selfref.global_path_file);
            foreach (Person_class p in CForm.selfref.mass_person) 
                Arxivlist.Items.Add(p.fio);
        }
        private void pictureBox1_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Dobnovpers(true, false));
            f.Show();
        }
        private void удалитьВыбранногоПерсонажаToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Arxivlist.Items.Count > 0 && Arxivlist.SelectedIndex >= 0) {
                for (int i = 0; i < CForm.selfref.mass_person.Count; i++)
                    if (Arxivlist.Items[Arxivlist.SelectedIndex].ToString() == CForm.selfref.mass_person[i].fio) {
                        CForm.selfref.mass_person.Remove(CForm.selfref.mass_person[i]);
                        refrash_list();
                        refrash_select();
                        break;
                    }
            }
            else {
                CFormMessage s = new CFormMessage("Список пуст");
                s.Show();
            } 
        }
        private void Arxivlist_Click(object sender, EventArgs e) {
            refrash_select();
        }
        void refrash_select() {
            if (Arxivlist.Items.Count > 0 && Arxivlist.SelectedIndex >= 0)
                for (int i = 0; i < CForm.selfref.mass_person.Count; i++)
                    if (Arxivlist.Items[Arxivlist.SelectedIndex].ToString() == CForm.selfref.mass_person[i].fio) {
                        Dobnovpers.selfref_dobn.init_poly(CForm.selfref.mass_person[i]);
                        break;
                    }
        }
        private void pech_Click(object sender, EventArgs e) {
            select.build_word_doc();
        }
    }
}
