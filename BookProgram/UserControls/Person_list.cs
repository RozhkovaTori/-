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
            Person_help_class help = new Person_help_class();
            string title = (select.variable.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);

#region  
            help.persik = new Panel();
            help.persik.Dock = DockStyle.Fill;

            #region Texbox

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.образ = new TextBox();
            help.образ.Size = select.образ.Size;
            help.образ.Location = select.образ.Location;
            help.образ.Multiline = true;
            help.persik.Controls.Add(help.образ);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);

            help.fio = new TextBox();
            help.fio.Size = select.FIO.Size;
            help.fio.Location = select.FIO.Location;
            help.fio.Multiline = true;
            help.persik.Controls.Add(help.fio);
            
            #endregion
            #region Label 

            help.CompliteBtnm = new Label();
            help.CompliteBtnm.Size = select.CompliteBtnm.Size;
            help.CompliteBtnm.Location = select.CompliteBtnm.Location;
            help.CompliteBtnm.Click += new EventHandler(select.label23_Click);
            help.persik.Controls.Add(help.CompliteBtnm);

            help.label5 = new Label();
            help.label5.Size = select.label5.Size;
            help.label5.Location = select.label5.Location;
            help.persik.Controls.Add(help.label5);

            help.label11 = new Label();
            help.label11.Size = select.label11.Size;
            help.label11.Location = select.label11.Location;
            help.persik.Controls.Add(help.label11);

            help.label2 = new Label();
            help.label2.Size = select.label2.Size;
            help.label2.Location = select.label2.Location;
            help.persik.Controls.Add(help.label2);

            help.label3 = new Label();
            help.label3.Size = select.label3.Size;
            help.label3.Location = select.label3.Location;
            help.persik.Controls.Add(help.label3);

            help.label4 = new Label();
            help.label4.Size = select.label4.Size;
            help.label4.Location = select.label4.Location;
            help.persik.Controls.Add(help.label4);

            help.label9 = new Label();
            help.label9.Size = select.label9.Size;
            help.label9.Location = select.label9.Location;
            help.persik.Controls.Add(help.label9);

            help.label24 = new Label();
            help.label24.Size = select.label24.Size;
            help.label24.Location = select.label24.Location;
            help.persik.Controls.Add(help.label24);

            help.label25 = new Label();
            help.label25.Size = select.label25.Size;
            help.label25.Location = select.label25.Location;
            help.persik.Controls.Add(help.label25);

            help.label6 = new Label();
            help.label6.Size = select.label6.Size;
            help.label6.Location = select.label6.Location;
            help.persik.Controls.Add(help.label6);

            help.label1 = new Label();
            help.label1.Size = select.label1.Size;
            help.label1.Location = select.label1.Location;
            help.persik.Controls.Add(help.label1);

            help.label10 = new Label();
            help.label10.Size = select.label10.Size;
            help.label10.Location = select.label10.Location;
            help.persik.Controls.Add(help.label10);

            help.label7 = new Label();
            help.label7.Size = select.label7.Size;
            help.label7.Location = select.label7.Location;
            help.persik.Controls.Add(help.label7);

            help.label12 = new Label();
            help.label12.Size = select.label12.Size;
            help.label12.Location = select.label12.Location;
            help.persik.Controls.Add(help.label12);

            help.label13 = new Label();
            help.label13.Size = select.label13.Size;
            help.label13.Location = select.label13.Location;
            help.persik.Controls.Add(help.label13);

            help.label14 = new Label();
            help.label14.Size = select.label14.Size;
            help.label14.Location = select.label14.Location;
            help.persik.Controls.Add(help.label14);

            help.label15 = new Label();
            help.label15.Size = select.label15.Size;
            help.label15.Location = select.label15.Location;
            help.persik.Controls.Add(help.label15);

            help.label16 = new Label();
            help.label16.Size = select.label16.Size;
            help.label16.Location = select.label16.Location;
            help.persik.Controls.Add(help.label16);

            help.label17 = new Label();
            help.label17.Size = select.label17.Size;
            help.label17.Location = select.label17.Location;
            help.persik.Controls.Add(help.label17);

            help.label26 = new Label();
            help.label26.Size = select.label26.Size;
            help.label26.Location = select.label26.Location;
            help.persik.Controls.Add(help.label26);

            help.label8 = new Label();
            help.label8.Size = select.label8.Size;
            help.label8.Location = select.label8.Location;
            help.persik.Controls.Add(help.label8);

            help.label21 = new Label();
            help.label21.Size = select.label21.Size;
            help.label21.Location = select.label21.Location;
            help.persik.Controls.Add(help.label21);

            help.label27 = new Label();
            help.label27.Size = select.label27.Size;
            help.label27.Location = select.label27.Location;
            help.persik.Controls.Add(help.label27);

            help.label18 = new Label();
            help.label18.Size = select.label18.Size;
            help.label18.Location = select.label18.Location;
            help.persik.Controls.Add(help.label18);

            help.label19 = new Label();
            help.label19.Size = select.label19.Size;
            help.label19.Location = select.label19.Location;
            help.persik.Controls.Add(help.label19);

            help.label22 = new Label();
            help.label22.Size = select.label22.Size;
            help.label22.Location = select.label22.Location;
            help.persik.Controls.Add(help.label22);

            help.label20 = new Label();
            help.label20.Size = select.label20.Size;
            help.label20.Location = select.label20.Location;
            help.persik.Controls.Add(help.label20);

            help.CompliteBtn = new Label();
            help.CompliteBtn.Size = select.CompliteBtn.Size;
            help.CompliteBtn.Location = select.CompliteBtn.Location;
            help.CompliteBtn.Click += new EventHandler(select.label23_Click);
            help.persik.Controls.Add(help.CompliteBtn);


            #endregion
            #region PictureBox

            help.профиль = new PictureBox();
            help.профиль.SizeMode = select.профиль.SizeMode;
            help.профиль.Size = select.профиль.Size;
            help.профиль.Location = select.профиль.Location;
            help.профиль.DoubleClick += new EventHandler(select.pictureBox1_DoubleClick);
            help.persik.Controls.Add(help.профиль);

            help.izmen = new PictureBox();
            help.izmen.SizeMode = select.izmen.SizeMode;
            help.izmen.Size = select.izmen.Size;
            help.izmen.Location = select.izmen.Location;
            help.izmen.DoubleClick += new EventHandler(select.izmen_DoubleClick);
            help.persik.Controls.Add(help.izmen);

            help.гориз_профиль = new PictureBox();
            help.гориз_профиль.SizeMode = select.гориз_профиль.SizeMode;
            help.гориз_профиль.Size = select.гориз_профиль.Size;
            help.гориз_профиль.Location = select.гориз_профиль.Location;
            help.гориз_профиль.DoubleClick += new EventHandler(select.pictureBox2_DoubleClick);
            help.persik.Controls.Add(help.гориз_профиль);

            help.горизонтал = new PictureBox();
            help.горизонтал.SizeMode = select.горизонтал.SizeMode;
            help.горизонтал.Size = select.горизонтал.Size;
            help.горизонтал.Location = select.горизонтал.Location;
            help.горизонтал.DoubleClick += new EventHandler(select.горизонтал_DoubleClick);
            help.persik.Controls.Add(help.горизонтал);

            #endregion


            //dynamic_content.Controls.Add(help.persik);
            //mass_l.Add(help);

            #endregion
            select.variable.TabPages.Add(myTabPage);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (select.variable.SelectedTab.Name != "Defaul") 
            select.variable.TabPages.Remove(select.variable.SelectedTab);
        }

    }
}
