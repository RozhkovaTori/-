using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Mybooks_Newbook : UserControl
    {
        bool cr;
        public static Mybooks_Newbook selfref_book { get; set; }
        public Mybooks_Newbook(bool create)
        {
            InitializeComponent();
            selfref_book = this;
            if (!create) {
                CompliteBtnmu.Text = "Изменить";
                название.ReadOnly = true;
            }
            cr = create;
        }
        public void init_poly(Book_class book) {
            название.Text = book.название;
            о_книге.Text = book.о_книге;
            обложка.Image = (Image)book.обложка;
        }
        private void обложка_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                обложка.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private void CompliteBtnmu_Click(object sender, EventArgs e) {
            if (cr) {
                string error = "";
                if (isClonНазв()) error += "Ошибка: Такая книга уже существует";
                if (String.IsNullOrEmpty(название.Text)) error += "Ошибка: Поле названя пустое";

                if (error == "") {
                   Book_class book = new Book_class();
                    book.название = название.Text;
                    book.о_книге = о_книге.Text;
                    if (обложка.Image != null) book.обложка = new Bitmap(обложка.Image); 

                    CForm.selfref.mass_book.Add(book);

                    Mybooks.selfref_Mybooks.refrash_list();

                    CFormDialog.CRefDialog.CloseCFormDialog(); // закрытие формы
                }
                else {
                    CFormMessage s = new CFormMessage(error);
                    s.Show();
                }
            }
            else {
                string error = "";
                if (String.IsNullOrEmpty(название.Text)) error += "Ошибка: Поле Название пустое";

                if (error == "") {
                    Book_class book = new Book_class();
                    название.Text = book.название;
                    о_книге.Text = book.о_книге;
                    обложка.Image = book.обложка;

                    for (int i = 0; i < CForm.selfref.mass_book.Count; i++)
                        if (название.Text == CForm.selfref.mass_book[i].название)
                        {
                            CForm.selfref.mass_book.Remove(CForm.selfref.mass_book[i]);
                            break;
                        }
                    CForm.selfref.mass_book.Add(book);
                    Mybooks.selfref_Mybooks.refrash_list();
                }
                else {
                    CFormMessage s = new CFormMessage(error);
                    s.Show();
                }
            }
        }
        bool isClonНазв() {
            foreach (Book_class b in CForm.selfref.mass_book)
                if (b.название == название.Text)
                    return true;
                    return false;
        }
        private void Mybooks_Newbook_Resize(object sender, EventArgs e) { centering(); }
        void centering() {
            panel1.Left = Width / 2 - panel1.Width / 2;
        }

       
    }
}
