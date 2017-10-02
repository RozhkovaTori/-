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
    public partial class Mybooks_Glaverson : UserControl {
        public static Mybooks_Glaverson selfref_Mybooks_Glaverson { get; set; }
        public Mybooks_Glaverson() {
            InitializeComponent();
            selfref_Mybooks_Glaverson = this;
            all_gg.Sorted = true;
            book_gg.Sorted = true;
            if (CForm.selfref.mass_person.Count > 0) {
                foreach (Person_class pers in CForm.selfref.mass_person)
                    all_gg.Items.Add(pers.fio);
                all_gg.SetSelected(0, true);
            }
            if (CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей.Length > 0) {
                refrash_list();
                book_gg.SetSelected(0, true);
            }
        }
        public void refrash_list() {
            book_gg.Items.Clear();
            CForm.selfref.save_to_file(CForm.selfref.global_path_file);
            foreach (Person_class p in CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей)
                book_gg.Items.Add(p.fio);
        }

        private void remove_to_book_MouseHover(object sender, EventArgs e)
        {
            remove_to_book.Image= Properties.Resources.Стрелочка_2_аним;
        }
        private void remove_to_book_MouseLeave(object sender, EventArgs e)
        {
            remove_to_book.Image = Properties.Resources.Стрелочка_2;
        }
        private void remove_to_book_Click(object sender, EventArgs e) {
            remove_to_book.Image = Properties.Resources.Стрелочка_2;
            if (book_gg.Items.Count > 0 && book_gg.SelectedIndex >= 0) {
                for (int i = 0; i < CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей.Length; i++)
                    if (book_gg.Items[book_gg.SelectedIndex].ToString() == CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i].fio) {
                        CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].remove_gg(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i]);
                        refrash_list();
                        break;
                    }
            }
            else {
                CFormMessage s = new CFormMessage("Список пуст");
                s.Show();
            } 
        }

        private void add_to_book_MouseHover(object sender, EventArgs e)
        {
            add_to_book.Image = Properties.Resources.Стрелочка_1_аним;
        }
        private void add_to_book_MouseLeave(object sender, EventArgs e)
        {
            add_to_book.Image = Properties.Resources.Стрелочка_1;
        }
        private void add_to_book_Click(object sender, EventArgs e)
        {
            add_to_book.Image = Properties.Resources.Стрелочка_1;
            if (all_gg.Items.Count > 0 && all_gg.SelectedIndex >= 0) {
                for (int i = 0; i < CForm.selfref.mass_person.Count; i++)
                    if (all_gg.Items[all_gg.SelectedIndex].ToString() == CForm.selfref.mass_person[i].fio) {
                        CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_gg(CForm.selfref.mass_person[i]);
                        refrash_list();
                        break;
                    }
            }
            else {
                CFormMessage s = new CFormMessage("Список пуст");
                s.Show();
            }
        }
        private void all_gg_DoubleClick(object sender, EventArgs e) {
            if (all_gg.Items.Count > 0 && all_gg.SelectedIndex >= 0)
                for (int i = 0; i < CForm.selfref.mass_person.Count; i++)
                    if (all_gg.Items[all_gg.SelectedIndex].ToString() == CForm.selfref.mass_person[i].fio) {
                        Dobnovpers d = new Dobnovpers(false, false);
                        d.init_poly(CForm.selfref.mass_person[i]);
                        CFormDialog c = new CFormDialog(d);
                        c.Show();
                        break;
                    }
        }
        private void book_gg_DoubleClick(object sender, EventArgs e) {
            if (book_gg.Items.Count > 0 && book_gg.SelectedIndex >= 0)
                for (int i = 0; i < CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей.Length; i++)
                    if (all_gg.Items[all_gg.SelectedIndex].ToString() == CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i].fio) {
                        Dobnovpers d = new Dobnovpers(false,true);
                        d.init_poly(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i]);
                        d.init_book_info(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex]);
                        CFormDialog c = new CFormDialog(d);
                        c.Show();
                        break;
                    }
        }


    }
}
