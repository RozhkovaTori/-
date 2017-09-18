using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BookProgram {
    public partial class Dobnovpers : UserControl {
        bool cr;
        bool book;
        public static Dobnovpers selfref_dobn { get; set; }
        public Dobnovpers(bool create, bool inbook) {
            InitializeComponent();
            selfref_dobn = this;
            if (!create) {
                CompliteBtn.Text = "Изменить";
                CompliteBtnm.Text = "Изменить";
                FIO.ReadOnly = true;
            }
            cr = create;
            book = inbook;
        }
        public void init_book_info(Book_class book) {
            книга.Text = book.название;
            короткий_сюжет.Text = book.о_книге;
        }
        public void init_poly(Person_class pers) {
            FIO.Text = pers.fio;
            образ.Text = pers.образ;
            прозвище.Text = pers.прозвище;
            возраст.Text = pers.возраст;
            дата.Text = pers.дата;
            пол.Text = pers.пол;
            раса.Text = pers.раса;
            место_рождения.Text = pers.место_рождения;
            профессия.Text = pers.профессия;
            приндалженость.Text = pers.приндалженость;
            биография.Text = pers.биография;
            взаимоотношения.Text = pers.взаимоотношения;
            характер.Text = pers.характер;
            преимущества.Text = pers.преимущества;
            факты.Text = pers.факты;
            внешность.Text = pers.внешность;
            увлечения.Text = pers.увлечения;
            способности.Text = pers.способности;
            эффекты.Text = pers.эффекты;
            доп_информация.Text = pers.доп_информация;
            книга.Text = pers.книга;
            источник.Text = pers.источник;
            короткий_сюжет.Text = pers.короткий_сюжет;
            заметки.Text = pers.заметки;
            профиль.Image = (Image) pers.img;
            гориз_профиль.Image = (Image)pers.imga;
            горизонтал.Image = (Image)pers.imgak;

        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                профиль.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private void Dobnovpers_MouseDown(object sender, MouseEventArgs e) {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e) {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            гориз_профиль.Image = Image.FromFile(openFileDialog2.FileName);
        }
        private void горизонтал_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
                горизонтал.Image = Image.FromFile(openFileDialog3.FileName);
        }
        public void label23_Click(object sender, EventArgs e) {
            if (cr) {
                string error = "";
                if (isClonFio()) error += "Ошибка: Такие Имя Фамилия уже существуют";
                if (String.IsNullOrEmpty(FIO.Text)) error += "Ошибка: Поле Имя Фамилия пустое";

                if (error == "")
                {
                    Person_class pers = new Person_class();
                    pers.fio = FIO.Text;
                    pers.прозвище = прозвище.Text;
                    pers.образ = образ.Text;
                    pers.возраст = возраст.Text;
                    pers.дата = дата.Text;
                    pers.пол = пол.Text;
                    pers.раса = раса.Text;
                    pers.место_рождения = место_рождения.Text;
                    pers.профессия = профессия.Text;
                    pers.приндалженость = приндалженость.Text;
                    pers.биография = биография.Text;
                    pers.взаимоотношения = взаимоотношения.Text;
                    pers.характер = характер.Text;
                    pers.преимущества = преимущества.Text;
                    pers.факты = факты.Text;
                    pers.внешность = внешность.Text;
                    pers.увлечения = увлечения.Text;
                    pers.способности = способности.Text;
                    pers.эффекты = эффекты.Text;
                    pers.доп_информация = доп_информация.Text;
                    pers.книга = книга.Text;
                    pers.источник = источник.Text;
                    pers.короткий_сюжет = короткий_сюжет.Text;
                    pers.заметки = заметки.Text;
                    if(профиль.Image != null) pers.img = new Bitmap(профиль.Image);
                    if(гориз_профиль.Image != null) pers.imga = new Bitmap(гориз_профиль.Image);
                    if(горизонтал.Image != null) pers.imgak = new Bitmap(горизонтал.Image);

                    if (book) {
                        CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_gg(pers);
                        Mybooks_Glaverson.selfref_Mybooks_Glaverson.refrash_list(); 
                    }
                    else {
                        CForm.selfref.mass_person.Add(pers);
                        Arxivper.selfref_Arxivper.refrash_list();
                    }
                    CFormDialog.CRefDialog.CloseCFormDialog(); // закрытие формы
                }
                else {
                    CFormMessage s = new CFormMessage(error);
                    s.Show();
                } 
            }
            else {
                string error = "";
                if (String.IsNullOrEmpty(FIO.Text)) error += "Ошибка: Поле Имя Фамилия пустое";

                if (error == "")
                {
                    Person_class pers = new Person_class();
                    pers.fio = FIO.Text;
                    pers.прозвище = прозвище.Text;
                    pers.образ = образ.Text;
                    pers.возраст = возраст.Text;
                    pers.дата = дата.Text;
                    pers.пол = пол.Text;
                    pers.раса = раса.Text;
                    pers.место_рождения = место_рождения.Text;
                    pers.профессия = профессия.Text;
                    pers.приндалженость = приндалженость.Text;
                    pers.биография = биография.Text;
                    pers.взаимоотношения = взаимоотношения.Text;
                    pers.характер = характер.Text;
                    pers.преимущества = преимущества.Text;
                    pers.факты = факты.Text;
                    pers.внешность = внешность.Text;
                    pers.увлечения = увлечения.Text;
                    pers.способности = способности.Text;
                    pers.эффекты = эффекты.Text;
                    pers.доп_информация = доп_информация.Text;
                    pers.книга = книга.Text;
                    pers.источник = источник.Text;
                    pers.короткий_сюжет = короткий_сюжет.Text;
                    pers.заметки = заметки.Text;
                    pers.img = new Bitmap(профиль.Image);
                    pers.imga = new Bitmap(гориз_профиль.Image);
                    pers.imgak = new Bitmap(горизонтал.Image);

                    if (book) {
                        for (int i = 0; i < CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей.Length; i++)
                            if (FIO.Text == CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i].fio) {
                                CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].remove_gg(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав_персонажей[i]);
                                break;
                            }
                        CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_gg(pers);
                        Mybooks_Glaverson.selfref_Mybooks_Glaverson.refrash_list();
                    }
                    else {
                    for (int i = 0; i < CForm.selfref.mass_person.Count; i++)
                        if (FIO.Text == CForm.selfref.mass_person[i].fio) {
                            CForm.selfref.mass_person.Remove(CForm.selfref.mass_person[i]);
                            break;
                        }
                    CForm.selfref.mass_person.Add(pers);
                    Arxivper.selfref_Arxivper.refrash_list();
                    }
                }
                else {
                    CFormMessage s = new CFormMessage(error);
                    s.Show();                  
                }
            }
        }
        bool isClonFio() {
            foreach (Person_class p in CForm.selfref.mass_person)
                if (p.fio == FIO.Text)
                    return true;
            return false;
        }

        public void build_word_doc() {
            string content = "";
            content += "Фамилия Имя \n" + FIO.Text + "\n";
            if (!String.IsNullOrEmpty(прозвище.Text) || !String.IsNullOrEmpty(образ.Text) || !String.IsNullOrEmpty(возраст.Text) || !String.IsNullOrEmpty(дата.Text) || !String.IsNullOrEmpty(пол.Text) || !String.IsNullOrEmpty(раса.Text) || !String.IsNullOrEmpty(место_рождения.Text) || !String.IsNullOrEmpty(профессия.Text) || !String.IsNullOrEmpty(приндалженость.Text)) content += "P A R T   I  О Б Щ А Я    И Н Ф О Р М А Ц И Я: \n";
            if(!String.IsNullOrEmpty(прозвище.Text)) content += "Прозвище \n" + прозвище.Text + "\n";
            if(!String.IsNullOrEmpty(образ.Text)) content += "Образ \n" + образ.Text + "\n";
            if(!String.IsNullOrEmpty(возраст.Text)) content += "Возраст \n" + возраст.Text + "\n";
            if(!String.IsNullOrEmpty(дата.Text)) content += "Дата \n" + дата.Text + "\n";
            if(!String.IsNullOrEmpty(пол.Text)) content += "Пол \n" + пол.Text + "\n";
            if(!String.IsNullOrEmpty(раса.Text)) content += "Раса \n" + раса.Text + "\n";
            if(!String.IsNullOrEmpty(место_рождения.Text)) content += "Место_рождения \n" + место_рождения.Text + "\n";
            if(!String.IsNullOrEmpty(профессия.Text)) content += "Профессия \n" + профессия.Text + "\n";
            if(!String.IsNullOrEmpty(приндалженость.Text)) content += "Приндалженость \n" + приндалженость.Text + "\n";
            if(!String.IsNullOrEmpty(биография.Text) || !String.IsNullOrEmpty(взаимоотношения.Text)) content += "P A R T   II Б И О Г Р А Ф И Я: \n";
            if(!String.IsNullOrEmpty(биография.Text)) content += "Биография \n" + биография.Text + "\n";
            if(!String.IsNullOrEmpty(взаимоотношения.Text)) content += "Взаимоотношения \n" + взаимоотношения.Text + "\n";
            if(!String.IsNullOrEmpty(характер.Text) || !String.IsNullOrEmpty(преимущества.Text) || !String.IsNullOrEmpty(факты.Text) || !String.IsNullOrEmpty(внешность.Text) || !String.IsNullOrEmpty(увлечения.Text) || !String.IsNullOrEmpty(способности.Text) || !String.IsNullOrEmpty(эффекты.Text)) content += "P A R T   III Л И Ч Н О С Т Ь: \n";
            if(!String.IsNullOrEmpty(характер.Text)) content += "Чарактер \n" + характер.Text + "\n";
            if(!String.IsNullOrEmpty(преимущества.Text)) content += "Преимущества \n" + преимущества.Text + "\n";
            if(!String.IsNullOrEmpty(факты.Text)) content += "Факты \n" + факты.Text + "\n";
            if(!String.IsNullOrEmpty(внешность.Text)) content += "Внешность \n" + внешность.Text + "\n";
            if(!String.IsNullOrEmpty(увлечения.Text)) content += "Увлечения \n" + увлечения.Text + "\n";
            if(!String.IsNullOrEmpty(способности.Text)) content += "Способности \n" + способности.Text + "\n";
            if(!String.IsNullOrEmpty(эффекты.Text)) content += "Эффекты \n" + эффекты.Text + "\n";
            if (!String.IsNullOrEmpty(доп_информация.Text)) {
                content += "P A R T   IV Д О П О Л Н И Т Е Л Ь Н О: \n";
                content += "Доп_информация \n" + доп_информация.Text + "\n";
            }
            if (!String.IsNullOrEmpty(книга.Text) || !String.IsNullOrEmpty(источник.Text) || !String.IsNullOrEmpty(короткий_сюжет.Text)) content += "P A R T   V К Н И Г А: \n";
            if(!String.IsNullOrEmpty(книга.Text)) content += "Книга \n" + книга.Text + "\n";
            if(!String.IsNullOrEmpty(источник.Text)) content += "Источник \n" + источник.Text + "\n";
            if(!String.IsNullOrEmpty(короткий_сюжет.Text)) content += "Короткий_сюжет \n" + короткий_сюжет.Text + "\n";
            if(!String.IsNullOrEmpty(заметки.Text)) { 
                content += "P A R T   VI З А М Е Т К И: \n";
                content += "Заметки \n" + заметки.Text + "\n";
            }
            export_pers_word(content);
        }

        public void export_pers_word(string content) {
            try {
                Microsoft.Office.Interop.Word.Application winword =
                new Microsoft.Office.Interop.Word.Application();

                winword.Visible = false;

                object missing = System.Reflection.Missing.Value;

                //Создание нового документа 
                Microsoft.Office.Interop.Word.Document document =
                winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //добавление новой страницы 
                winword.Selection.InsertNewPage();
 
                document.Content.SetRange(0, 0);

                //доавление изоражения
               // object f = false;
               // object t = true;
               // object left = Type.Missing;
               // object top = Type.Missing;
              //  object width = 300;
              //  object height = 300;
              //  object range = Type.Missing;
              //  Microsoft.Office.Interop.Word.WdWrapType wrap = Microsoft.Office.Interop.Word.WdWrapType.wdWrapSquare;
              //  document.Shapes.AddPicture( ref f, ref t, ref left, ref top, ref width, ref height, ref range).WrapFormat.Type = wrap;

                //Добавление текста в документ
                document.Content.Text =  content + Environment.NewLine;

               winword.Visible = true;
           }
           catch (Exception ex) {
               CFormMessage s = new CFormMessage(ex.Message);
               s.Show(); 
           }
        }
        private void Dobnovpers_Resize(object sender, EventArgs e) { centering(); }
        void centering() {
            persik.Left = Width / 2 - persik.Width / 2; 
        }

 
    }
}
