﻿using System;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Mybooks : UserControl
    {
        public static Mybooks selfref_Mybooks { get; set; }
        //Mybooks_Oglavlenie headers = new Mybooks_Oglavlenie();
        // Mybooks_Newbook book = new Mybooks_Newbook(false);
        public Mybooks()
        {
            InitializeComponent();
            //selfref_Mybooks = this;
            //mybook.Sorted = true;

            //headers.Dock = DockStyle.Fill;
            //kniga.Controls.Add(headers);
            //kniga.Controls.SetChildIndex(headers, 0);
            //book.Dock = DockStyle.Fill;
            //headers.VisibleMenu.Controls.Add(book);
            //headers.VisibleMenu.Controls.SetChildIndex(book, 0);
            //headers.Visible = false;

            //if (File.Exists(CForm.selfref.global_path_file)) {
            //    CForm.selfref.load_is_file(CForm.selfref.global_path_file);
            //    refrash_list();
            //    if (mybook.Items.Count > 0) mybook.SetSelected(0, true);
            //    refresh_mybook();
            //}
        }
        public void refrash_list()
        {
            //mybook.Items.Clear();
            //CForm.selfref.save_to_file(CForm.selfref.global_path_file);
            //foreach (Book_class p in CForm.selfref.mass_book)
            //    mybook.Items.Add(p.название);
            //if (mybook.Items.Count > 0) headers.Visible = true; else headers.Visible = false;
        }
        private void newbook_MouseHover( object sender, EventArgs e )
        {
            //newbook.Image= Properties.Resources.новая_книга_аним;
        }
        private void newbook_MouseLeave( object sender, EventArgs e )
        {
            //newbook.Image = Properties.Resources.новая_книга;
        }
        private void newbook_Click( object sender, EventArgs e )
        {
            //newbook.Image = Properties.Resources.новая_книга;
            //CFormDialog f = new CFormDialog(new Mybooks_Newbook(true));
            //f.Show();
        }
        private void удалитьВыбраннуюКнигуToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //if (mybook.Items.Count > 0) {
            //    for (int i = 0; i < CForm.selfref.mass_book.Count; i++)
            //        if (mybook.Items[mybook.SelectedIndex].ToString() == CForm.selfref.mass_book[i].название) {
            //            int temp = mybook.SelectedIndex;
            //            CForm.selfref.mass_book.Remove(CForm.selfref.mass_book[i]);
            //            refrash_list();
            //            if(mybook.Items.Count > 0) mybook.SetSelected(temp - 1, true);
            //            refresh_mybook();
            //            break;
            //        }
            //}
            //else {
            //CFormMessage s = new CFormMessage("Список пуст");
            //s.Show();
            //}
        }
        public void refresh_mybook()
        {
            //if (mybook.Items.Count > 0 && mybook.SelectedIndex >= 0)
            //    for (int i = 0; i < CForm.selfref.mass_book.Count; i++)
            //        if (mybook.Items[mybook.SelectedIndex].ToString() == CForm.selfref.mass_book[i].название) {
            //            book.init_poly(CForm.selfref.mass_book[i]);
            //            break;
            //        }
        }

        private void mybook_SelectedIndexChanged( object sender, EventArgs e )
        {
            //refresh_mybook();
            //headers.refrash_list();
        }
    }
}






