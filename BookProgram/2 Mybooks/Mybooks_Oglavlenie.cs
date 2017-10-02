using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookProgram {
    public partial class Mybooks_Oglavlenie : UserControl {
        int temp_height_menu = 70;
        public static Mybooks_Oglavlenie selfref_Mybooks_Oglavlenie { get; set; }
        public Mybooks_Oglavlenie() {
            InitializeComponent();
            selfref_Mybooks_Oglavlenie = this;
            if(Mybooks.selfref_Mybooks != null) 
               refrash_list();
        }
        private void HideMenuBtn_Click(object sender, EventArgs e) {
            VisibleMenu.Visible = false;
            HideMenu.Visible = true;
            temp_height_menu = oknige.Height;
            oknige.Height = HideMenu.Height;
        }
        private void ShowMenuBut_Click(object sender, EventArgs e) {
            VisibleMenu.Visible = true;
            HideMenu.Visible = false;
            oknige.Height = temp_height_menu;
        }
        public void refrash_list() {
            if (CForm.selfref.mass_book.Count > 0) {
                oglavknigi.Items.Clear();
                CForm.selfref.save_to_file(CForm.selfref.global_path_file);
                if (CForm.selfref.mass_book.Count > 0 && Mybooks.selfref_Mybooks.mybook.Items.Count > 0)
                    foreach (Chapter_class c in CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав)
                        oglavknigi.Items.Add(c.оглавнение);
            }
        }
        private void oglavknigi_DoubleClick(object sender, EventArgs e)
        {
            if (oglavknigi.Items.Count > 0 && oglavknigi.SelectedIndex >= 0)
                foreach (Chapter_class c in CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав)
                    if (oglavknigi.Items[oglavknigi.SelectedIndex].ToString() == c.оглавнение) {
                        Mybooks_Newchapter n = new Mybooks_Newchapter(false);
                        n.init_poly(c);
                        CFormDialog f = new CFormDialog(n);
                        f.Show();
                        break;
                    }
        }
        #region меню
        private void newcharper_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Mybooks_Newchapter(true));
            f.Show();
        }
        private void glavpers_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Mybooks_Glaverson());
            f.Show();
        }
        private void vtorpers_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Mybooks_Vtorperson());
            f.Show();
            }

       
        private void locacii_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Mybooks_Location());
            f.Show();
        }
        private void foto_Click(object sender, EventArgs e) {
            CFormDialog f = new CFormDialog(new Mybooks_Foto());
            f.Show();
        }


        
        private void удалитьГлавуToolStripMenuItem_Click(object sender, EventArgs e) {
            if (oglavknigi.Items.Count > 0 && oglavknigi.SelectedIndex >= 0)
                for (int i = 0; i < CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав.Length; i++)
                    if (oglavknigi.Items[oglavknigi.SelectedIndex].ToString() == CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав[i].оглавнение) {
                        CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].remove_chapter(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав[i]);
                        refrash_list();
                        break;
                    }
        }
        #endregion
       
    }
}
