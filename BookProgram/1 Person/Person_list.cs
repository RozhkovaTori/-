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
        public Dobnovpers select = new Dobnovpers(false, false);

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
                        int index = Arxivlist.SelectedIndex;
                        CForm.selfref.mass_person.Remove(CForm.selfref.mass_person[i]);
                        refrash_list();
                        if (index > 0) Arxivlist.SetSelected(index - 1, true);
                        refrash_select();
                        break;
                    }
            }
            else {
                CFormMessage s = new CFormMessage("Список пуст");
                s.Show();
            } 
        }
        public void refrash_select() {
            if (Arxivlist.Items.Count > 0 && Arxivlist.SelectedIndex >= 0)
                foreach (Person_class p in CForm.selfref.mass_person) 
                    if (Arxivlist.Items[Arxivlist.SelectedIndex].ToString() == p.fio) {
                        select.init_poly(p);
                        break;
                    }
        }
        private void pech_Click(object sender, EventArgs e) {
            select.build_word_doc();
        }

        private void pictureBox3_Click(object sender, EventArgs e) {
            Person_var_class pv = new Person_var_class();
            pv.id = select.mass_m.Count.ToString();
            select.mass_m.Add(pv);
            select.refrah_tab();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            foreach (Person_var_class pv in select.mass_m)
                if (pv.id == select.variable.SelectedTab.Text && pv.id != "Главный персонаж" ) {
                    select.mass_m.Remove(pv);
                    select.refrah_tab();
                    break;
                }
        }

        private void Arxivlist_SelectedIndexChanged(object sender, EventArgs e) {
            refrash_select();
        }
    }
}
