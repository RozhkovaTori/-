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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            Person_help_class help = new Person_help_class();
            string title = (select.variable.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.BackColor = Color.White;
            myTabPage.AutoScroll = true;
            #region  
            help.persik = new Panel();
            help.persik.Size = select.persik.Size;
            help.persik.Location = select.persik.Location;
            #region Texbox

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.fio.BackColor = select.FIO.BackColor;
            help.fio.BorderStyle = select.FIO.BorderStyle;
            help.fio.ForeColor = select.FIO.ForeColor;
            help.fio.Font = select.FIO.Font;
            help.fio.TextAlign = select.FIO.TextAlign;
            help.persik.Controls.Add(help.fio);

            help.образ = new TextBox();
            help.образ.Size = select.образ.Size;
            help.образ.Location = select.образ.Location;
            help.образ.Multiline = true;
            help.образ.BackColor = select.образ.BackColor;
            help.образ.BorderStyle = select.образ.BorderStyle;
            help.образ.ForeColor = select.образ.ForeColor;
            help.образ.Font = select.образ.Font;
            help.образ.TextAlign = select.образ.TextAlign;
            help.persik.Controls.Add(help.образ);

            help.прозвище = new TextBox();
            help.прозвище.Size = select.прозвище.Size;
            help.прозвище.Location = select.прозвище.Location;
            help.прозвище.Multiline = true;
            help.прозвище.BackColor = select.прозвище.BackColor;
            help.прозвище.BorderStyle = select.прозвище.BorderStyle;
            help.прозвище.ForeColor = select.прозвище.ForeColor;
            help.прозвище.Font = select.прозвище.Font;
            help.прозвище.TextAlign = select.прозвище.TextAlign;
            help.persik.Controls.Add(help.прозвище);

            help.возраст = new TextBox();
            help.возраст.Size = select.возраст.Size;
            help.возраст.Location = select.возраст.Location;
            help.возраст.Multiline = true;
            help.возраст.BackColor = select.возраст.BackColor;
            help.возраст.BorderStyle = select.возраст.BorderStyle;
            help.возраст.ForeColor = select.возраст.ForeColor;
            help.возраст.Font = select.возраст.Font;
            help.возраст.TextAlign = select.возраст.TextAlign;
            help.persik.Controls.Add(help.возраст);

            help.дата = new TextBox();
            help.дата.Size = select.дата.Size;
            help.дата.Location = select.дата.Location;
            help.дата.Multiline = true;
            help.дата.BackColor = select.дата.BackColor;
            help.дата.BorderStyle = select.дата.BorderStyle;
            help.дата.ForeColor = select.дата.ForeColor;
            help.дата.Font = select.дата.Font;
            help.дата.TextAlign = select.дата.TextAlign;
            help.persik.Controls.Add(help.дата);

            help.пол = new TextBox();
            help.пол.Size = select.пол.Size;
            help.пол.Location = select.пол.Location;
            help.пол.Multiline = true;
            help.пол.BackColor = select.пол.BackColor;
            help.пол.BorderStyle = select.пол.BorderStyle;
            help.пол.ForeColor = select.пол.ForeColor;
            help.пол.Font = select.пол.Font;
            help.пол.TextAlign = select.пол.TextAlign;
            help.persik.Controls.Add(help.пол);

            help.раса = new TextBox();
            help.раса.Size = select.раса.Size;
            help.раса.Location = select.раса.Location;
            help.раса.Multiline = true;
            help.раса.BackColor = select.раса.BackColor;
            help.раса.BorderStyle = select.раса.BorderStyle;
            help.раса.ForeColor = select.раса.ForeColor;
            help.раса.Font = select.раса.Font;
            help.раса.TextAlign = select.раса.TextAlign;
            help.persik.Controls.Add(help.раса);

            help.место_рождения = new TextBox();
            help.место_рождения.Size = select.место_рождения.Size;
            help.место_рождения.Location = select.место_рождения.Location;
            help.место_рождения.Multiline = true;
            help.место_рождения.BackColor = select.место_рождения.BackColor;
            help.место_рождения.BorderStyle = select.место_рождения.BorderStyle;
            help.место_рождения.ForeColor = select.место_рождения.ForeColor;
            help.место_рождения.Font = select.место_рождения.Font;
            help.место_рождения.TextAlign = select.место_рождения.TextAlign;
            help.persik.Controls.Add(help.место_рождения);

            help.профессия = new TextBox();
            help.профессия.Size = select.профессия.Size;
            help.профессия.Location = select.профессия.Location;
            help.профессия.Multiline = true;
            help.профессия.BackColor = select.профессия.BackColor;
            help.профессия.BorderStyle = select.профессия.BorderStyle;
            help.профессия.ForeColor = select.профессия.ForeColor;
            help.профессия.Font = select.профессия.Font;
            help.профессия.TextAlign = select.профессия.TextAlign;
            help.persik.Controls.Add(help.профессия);

            help.приндалженость = new TextBox();
            help.приндалженость.Size = select.приндалженость.Size;
            help.приндалженость.Location = select.приндалженость.Location;
            help.приндалженость.Multiline = true;
            help.приндалженость.BackColor = select.приндалженость.BackColor;
            help.приндалженость.BorderStyle = select.приндалженость.BorderStyle;
            help.приндалженость.ForeColor = select.приндалженость.ForeColor;
            help.приндалженость.Font = select.приндалженость.Font;
            help.приндалженость.TextAlign = select.приндалженость.TextAlign;
            help.persik.Controls.Add(help.приндалженость);

            help.биография = new TextBox();
            help.биография.Size = select.биография.Size;
            help.биография.Location = select.биография.Location;
            help.биография.Multiline = true;
            help.биография.BackColor = select.биография.BackColor;
            help.биография.BorderStyle = select.биография.BorderStyle;
            help.биография.ForeColor = select.биография.ForeColor;
            help.биография.Font = select.биография.Font;
            help.биография.TextAlign = select.биография.TextAlign;
            help.persik.Controls.Add(help.биография);

            help.взаимоотношения = new RichTextBox();
            help.взаимоотношения.Size = select.взаимоотношения.Size;
            help.взаимоотношения.Location = select.взаимоотношения.Location;
            help.взаимоотношения.Multiline = true;
            help.взаимоотношения.BackColor = select.взаимоотношения.BackColor;
            help.взаимоотношения.BorderStyle = select.взаимоотношения.BorderStyle;
            help.взаимоотношения.ForeColor = select.взаимоотношения.ForeColor;
            help.взаимоотношения.Font = select.взаимоотношения.Font;
            help.persik.Controls.Add(help.взаимоотношения);

            help.характер = new TextBox();
            help.характер.Size = select.характер.Size;
            help.характер.Location = select.характер.Location;
            help.характер.Multiline = true;
            help.характер.BackColor = select.характер.BackColor;
            help.характер.BorderStyle = select.характер.BorderStyle;
            help.характер.ForeColor = select.характер.ForeColor;
            help.характер.Font = select.характер.Font;
            help.характер.TextAlign = select.характер.TextAlign;
            help.persik.Controls.Add(help.характер);

            help.преимущества = new TextBox();
            help.преимущества.Size = select.преимущества.Size;
            help.преимущества.Location = select.преимущества.Location;
            help.преимущества.Multiline = true;
            help.преимущества.BackColor = select.преимущества.BackColor;
            help.преимущества.BorderStyle = select.преимущества.BorderStyle;
            help.преимущества.ForeColor = select.преимущества.ForeColor;
            help.преимущества.Font = select.преимущества.Font;
            help.преимущества.TextAlign = select.преимущества.TextAlign;
            help.persik.Controls.Add(help.преимущества);

            help.факты = new TextBox();
            help.факты.Size = select.факты.Size;
            help.факты.Location = select.факты.Location;
            help.факты.Multiline = true;
            help.факты.BackColor = select.факты.BackColor;
            help.факты.BorderStyle = select.факты.BorderStyle;
            help.факты.ForeColor = select.факты.ForeColor;
            help.факты.Font = select.факты.Font;
            help.факты.TextAlign = select.факты.TextAlign;
            help.persik.Controls.Add(help.факты);

            help.внешность = new TextBox();
            help.внешность.Size = select.внешность.Size;
            help.внешность.Location = select.внешность.Location;
            help.внешность.Multiline = true;
            help.внешность.BackColor = select.внешность.BackColor;
            help.внешность.BorderStyle = select.внешность.BorderStyle;
            help.внешность.ForeColor = select.внешность.ForeColor;
            help.внешность.Font = select.внешность.Font;
            help.внешность.TextAlign = select.внешность.TextAlign;
            help.persik.Controls.Add(help.внешность);

            help.увлечения = new TextBox();
            help.увлечения.Size = select.увлечения.Size;
            help.увлечения.Location = select.увлечения.Location;
            help.увлечения.Multiline = true;
            help.увлечения.BackColor = select.увлечения.BackColor;
            help.увлечения.BorderStyle = select.увлечения.BorderStyle;
            help.увлечения.ForeColor = select.увлечения.ForeColor;
            help.увлечения.Font = select.увлечения.Font;
            help.увлечения.TextAlign = select.увлечения.TextAlign;
            help.persik.Controls.Add(help.увлечения);

            help.способности = new TextBox();
            help.способности.Size = select.способности.Size;
            help.способности.Location = select.способности.Location;
            help.способности.Multiline = true;
            help.способности.BackColor = select.способности.BackColor;
            help.способности.BorderStyle = select.способности.BorderStyle;
            help.способности.ForeColor = select.способности.ForeColor;
            help.способности.Font = select.способности.Font;
            help.способности.TextAlign = select.способности.TextAlign;
            help.persik.Controls.Add(help.способности);

            help.эффекты = new TextBox();
            help.эффекты.Size = select.эффекты.Size;
            help.эффекты.Location = select.эффекты.Location;
            help.эффекты.Multiline = true;
            help.эффекты.BackColor = select.эффекты.BackColor;
            help.эффекты.BorderStyle = select.эффекты.BorderStyle;
            help.эффекты.ForeColor = select.эффекты.ForeColor;
            help.эффекты.Font = select.эффекты.Font;
            help.эффекты.TextAlign = select.эффекты.TextAlign;
            help.persik.Controls.Add(help.эффекты);

            help.доп_информация = new TextBox();
            help.доп_информация.Size = select.доп_информация.Size;
            help.доп_информация.Location = select.доп_информация.Location;
            help.доп_информация.Multiline = true;
            help.доп_информация.BackColor = select.доп_информация.BackColor;
            help.доп_информация.BorderStyle = select.доп_информация.BorderStyle;
            help.доп_информация.ForeColor = select.доп_информация.ForeColor;
            help.доп_информация.Font = select.доп_информация.Font;
            help.доп_информация.TextAlign = select.доп_информация.TextAlign;
            help.persik.Controls.Add(help.доп_информация);

            help.книга = new TextBox();
            help.книга.Size = select.книга.Size;
            help.книга.Location = select.книга.Location;
            help.книга.Multiline = true;
            help.книга.BackColor = select.книга.BackColor;
            help.книга.BorderStyle = select.книга.BorderStyle;
            help.книга.ForeColor = select.книга.ForeColor;
            help.книга.Font = select.книга.Font;
            help.книга.TextAlign = select.книга.TextAlign;
            help.persik.Controls.Add(help.книга);

            help.источник = new TextBox();
            help.источник.Size = select.источник.Size;
            help.источник.Location = select.источник.Location;
            help.источник.Multiline = true;
            help.источник.BackColor = select.источник.BackColor;
            help.источник.BorderStyle = select.источник.BorderStyle;
            help.источник.ForeColor = select.источник.ForeColor;
            help.источник.Font = select.источник.Font;
            help.источник.TextAlign = select.источник.TextAlign;
            help.persik.Controls.Add(help.источник);

            help.короткий_сюжет = new TextBox();
            help.короткий_сюжет.Size = select.короткий_сюжет.Size;
            help.короткий_сюжет.Location = select.короткий_сюжет.Location;
            help.короткий_сюжет.Multiline = true;
            help.короткий_сюжет.BackColor = select.короткий_сюжет.BackColor;
            help.короткий_сюжет.BorderStyle = select.короткий_сюжет.BorderStyle;
            help.короткий_сюжет.ForeColor = select.короткий_сюжет.ForeColor;
            help.короткий_сюжет.Font = select.короткий_сюжет.Font;
            help.короткий_сюжет.TextAlign = select.короткий_сюжет.TextAlign;
            help.persik.Controls.Add(help.короткий_сюжет);

            help.заметки = new TextBox();
            help.заметки.Size = select.заметки.Size;
            help.заметки.Location = select.заметки.Location;
            help.заметки.Multiline = true;
            help.заметки.BackColor = select.заметки.BackColor;
            help.заметки.BorderStyle = select.заметки.BorderStyle;
            help.заметки.ForeColor = select.заметки.ForeColor;
            help.заметки.Font = select.заметки.Font;
            help.заметки.TextAlign = select.заметки.TextAlign;
            help.persik.Controls.Add(help.заметки);

            #endregion
            #region Label 

            l = new Label();
            set_label(ref select.CompliteBtnm, ref l);
            l.Click += new EventHandler(select.label23_Click);
            help.CompliteBtnm = l;
            help.persik.Controls.Add(help.CompliteBtnm);
            
            
            l = new Label();
            set_label(ref select.label1, ref l);
            help.label1 = l; 
            help.persik.Controls.Add(help.label1);

            l = new Label();
            set_label(ref select.label2, ref l);
            help.label2 = l;
            help.persik.Controls.Add(help.label2);

            l = new Label();
            set_label(ref select.label3, ref l);
            help.label3= l;
            help.persik.Controls.Add(help.label3);

            l = new Label();
            set_label(ref select.label4, ref l);
            help.label4 = l;
            help.persik.Controls.Add(help.label4);

            l = new Label();
            set_label(ref select.label5, ref l);
            help.label5 = l;
            help.persik.Controls.Add(help.label5);

            l = new Label();
            set_label(ref select.label6, ref l);
            help.label6 = l;
            help.persik.Controls.Add(help.label6);

            l = new Label();
            set_label(ref select.label7, ref l);
            help.label7 = l;
            help.persik.Controls.Add(help.label7);

            l = new Label();
            set_label(ref select.label8, ref l);
            help.label8 = l;
            help.persik.Controls.Add(help.label8);

            l = new Label();
            set_label(ref select.label9, ref l);
            help.label9 = l;
            help.persik.Controls.Add(help.label9);

            l = new Label();
            set_label(ref select.label10, ref l);
            help.label10 = l;
            help.persik.Controls.Add(help.label10);

            l = new Label();
            set_label(ref select.label11, ref l);
            help.label11 = l;
            help.persik.Controls.Add(help.label11);

            l = new Label();
            set_label(ref select.label12, ref l);
            help.label12 = l;
            help.persik.Controls.Add(help.label12);

            l = new Label();
            set_label(ref select.label13, ref l);
            help.label13 = l;
            help.persik.Controls.Add(help.label13);

            l = new Label();
            set_label(ref select.label14, ref l);
            help.label14 = l;
            help.persik.Controls.Add(help.label14);

            l = new Label();
            set_label(ref select.label15, ref l);
            help.label15 = l;
            help.persik.Controls.Add(help.label15);

            l = new Label();
            set_label(ref select.label16, ref l);
            help.label16 = l;
            help.persik.Controls.Add(help.label16);

            l = new Label();
            set_label(ref select.label17, ref l);
            help.label17 = l;
            help.persik.Controls.Add(help.label17);

            l = new Label();
            set_label(ref select.label18, ref l);
            help.label18 = l;
            help.persik.Controls.Add(help.label18);

            l = new Label();
            set_label(ref select.label19, ref l);
            help.label19 = l;
            help.persik.Controls.Add(help.label19);

            l = new Label();
            set_label(ref select.label20, ref l);
            help.label20 = l;
            help.persik.Controls.Add(help.label20);

            l = new Label();
            set_label(ref select.label21, ref l);
            help.label21 = l;
            help.persik.Controls.Add(help.label21);

            l = new Label();
            set_label(ref select.label22, ref l);
            help.label22 = l;
            help.persik.Controls.Add(help.label22);

            l = new Label();
            set_label(ref select.label24, ref l);
            help.label24 = l;
            help.persik.Controls.Add(help.label24);

            l = new Label();
            set_label(ref select.label25, ref l);
            help.label25 = l;
            help.persik.Controls.Add(help.label25);

            l = new Label();
            set_label(ref select.label26, ref l);
            help.label26 = l;
            help.persik.Controls.Add(help.label26);

            l = new Label();
            set_label(ref select.label27, ref l);
            help.label27 = l;
            help.persik.Controls.Add(help.label27);

            l = new Label();
            set_label(ref select.CompliteBtn, ref l);
            l.Click += new EventHandler(select.label23_Click);
            help.CompliteBtn = l;
            help.persik.Controls.Add(help.CompliteBtn);
            
            #endregion
            #region PictureBox

            help.профиль = new PictureBox();
            help.профиль.SizeMode = select.профиль.SizeMode;
            help.профиль.Size = select.профиль.Size;
            help.профиль.Location = select.профиль.Location;
            help.профиль.BackgroundImage = select.профиль.BackgroundImage;
            help.профиль.BorderStyle = select.профиль.BorderStyle;
            help.профиль.BackgroundImageLayout = select.профиль.BackgroundImageLayout;
            help.профиль.DoubleClick += new EventHandler(select.pictureBox1_DoubleClick);
            help.persik.Controls.Add(help.профиль);

            help.гориз_профиль = new PictureBox();
            help.гориз_профиль.SizeMode = select.гориз_профиль.SizeMode;
            help.гориз_профиль.Size = select.гориз_профиль.Size;
            help.гориз_профиль.Location = select.гориз_профиль.Location;
            help.гориз_профиль.BackgroundImage = select.гориз_профиль.BackgroundImage;
            help.гориз_профиль.BorderStyle = select.гориз_профиль.BorderStyle;
            help.гориз_профиль.BackgroundImageLayout = select.гориз_профиль.BackgroundImageLayout;
            help.гориз_профиль.DoubleClick += new EventHandler(select.pictureBox2_DoubleClick);
            help.persik.Controls.Add(help.гориз_профиль);

            help.горизонтал = new PictureBox();
            help.горизонтал.SizeMode = select.горизонтал.SizeMode;
            help.горизонтал.Size = select.горизонтал.Size;
            help.горизонтал.Location = select.горизонтал.Location;
            help.горизонтал.BackgroundImage = select.горизонтал.BackgroundImage;
            help.горизонтал.BorderStyle = select.горизонтал.BorderStyle;
            help.горизонтал.BackgroundImageLayout = select.горизонтал.BackgroundImageLayout;
            help.горизонтал.DoubleClick += new EventHandler(select.горизонтал_DoubleClick);
            help.persik.Controls.Add(help.горизонтал);

            #endregion
            select.resize.Add(help.persik);
            myTabPage.Controls.Add(select.resize[select.resize.Count - 1]);
            select.variable.TabPages.Add(myTabPage);
            select.help_m.Add(help);
            #endregion
        }

        void set_label(ref Label suorce, ref Label clone) {
            clone.Size = suorce.Size;
            clone.Location = suorce.Location;
            clone.BackColor = suorce.BackColor;
            clone.BorderStyle = suorce.BorderStyle;
            clone.ForeColor = suorce.ForeColor;
            clone.Font = suorce.Font;
            clone.TextAlign = suorce.TextAlign;
            clone.Text = suorce.Text;
            clone.Size = suorce.Size;
            clone.Location = suorce.Location;
        }
        private void pictureBox2_Click(object sender, EventArgs e) {
            if (select.variable.SelectedTab.Name != "Defaul") 
            select.variable.TabPages.Remove(select.variable.SelectedTab);
        }

    }
}
