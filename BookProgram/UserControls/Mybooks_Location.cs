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
    public partial class Mybooks_Location : UserControl
    {
       List<Location_help_class> mass_l = new List<Location_help_class>();
        public Mybooks_Location() {
            InitializeComponent();
            if (CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_локаций.Length > 0)
                add_mass(CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_локаций);
        }
        private void save_Click(object sender, EventArgs e) {
            foreach (Location_help_class loc in mass_l)
                if (!String.IsNullOrEmpty(loc.name.Text)) {
                    Location_class l = new Location_class();
                    l.название = loc.name.Text;
                    l.описание = loc.content.Text;
                    l.изображение = new Bitmap(loc.img.Image);
                    CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_location(l);
                }
            CForm.selfref.save_to_file(CForm.selfref.global_path_file);
            CFormDialog.CRefDialog.CloseCFormDialog();
        }
        private void add_Click(object sender, EventArgs e) { add(); }
        void add() {
            Location_help_class new_loc = new Location_help_class();
            // Копируем значения всех свойств панели
            new_loc.panel = new Panel();
            new_loc.panel.Dock = DockStyle.Top;
            new_loc.panel.Height = fix_content.Height;
            // Копируем значения всех свойств название
            new_loc.name = new TextBox();
            new_loc.name.Multiline = true;
            new_loc.name.Size = название.Size;
            new_loc.name.Location = название.Location;
            new_loc.panel.Controls.Add(new_loc.name);
            // Копируем значения всех свойств описания
            new_loc.content = new TextBox();
            new_loc.content.Multiline = true;
            new_loc.content.Size = описание.Size;
            new_loc.content.Location = описание.Location;
            new_loc.panel.Controls.Add(new_loc.content);
            // Копируем значения всех свойств изображения
            new_loc.img = new PictureBox();
            new_loc.img.Image = изображение.Image;
            new_loc.img.SizeMode = изображение.SizeMode;
            new_loc.img.Size = изображение.Size;
            new_loc.img.Location = изображение.Location;
            new_loc.img.DoubleClick += new EventHandler(изображение_DoubleClick);
            new_loc.panel.Controls.Add(new_loc.img);
            //добавляем панель в массив и на форму
            dynamic_content.Controls.Add(new_loc.panel);
            mass_l.Add(new_loc);
        }
        void add_mass(Location_class[] Location) {
            foreach (Location_class loc in Location) {
                add();
                mass_l[mass_l.Count - 1].name.Text = loc.название;
                mass_l[mass_l.Count - 1].content.Text = loc.описание;
                mass_l[mass_l.Count - 1].img.Image = loc.изображение; 
            }
        }
        private void изображение_DoubleClick(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                ((PictureBox)sender).Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
