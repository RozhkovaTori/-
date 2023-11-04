using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Mybooks_Vtorperson : UserControl
    {
        List<Vtorpers_help_class> mass_p = new List<Vtorpers_help_class>();
        public Mybooks_Vtorperson()
        {
            InitializeComponent();
            if( CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_втор_персонажей.Length > 0 )
                add_mass( CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_втор_персонажей );
        }
        private void save_Click( object sender, EventArgs e )
        {
            foreach( Vtorpers_help_class pers in mass_p )
                if( !String.IsNullOrEmpty( pers.name.Text ) )
                {
                    Second_person_class p = new Second_person_class();
                    p.фио = pers.name.Text;
                    p.описание = pers.content.Text;
                    p.изображение = new Bitmap( pers.img.Image );
                    CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_second_pers( p );
                }
            CForm.selfref.save_to_file( CForm.selfref.global_path_file );
            CFormDialog.CRefDialog.CloseCFormDialog();
        }
        private void add_Click( object sender, EventArgs e ) { add(); }
        void add()
        {
            Vtorpers_help_class new_vpers = new Vtorpers_help_class();
            // Копируем значения всех свойств панели
            new_vpers.panel = new Panel();
            new_vpers.panel.Dock = DockStyle.Top;
            new_vpers.panel.Height = fix_content.Height;
            // Копируем значения всех свойств фио
            new_vpers.name = new TextBox();
            new_vpers.name.Multiline = true;
            new_vpers.name.Size = ФИО.Size;
            new_vpers.name.Location = ФИО.Location;
            new_vpers.panel.Controls.Add( new_vpers.name );
            // Копируем значения всех свойств описания
            new_vpers.content = new TextBox();
            new_vpers.content.Multiline = true;
            new_vpers.content.Size = описание.Size;
            new_vpers.content.Location = описание.Location;
            new_vpers.panel.Controls.Add( new_vpers.content );
            // Копируем значения всех свойств изображения
            new_vpers.img = new PictureBox();
            new_vpers.img.Image = изображение.Image;
            new_vpers.img.SizeMode = изображение.SizeMode;
            new_vpers.img.Size = изображение.Size;
            new_vpers.img.Location = изображение.Location;
            new_vpers.img.DoubleClick += new EventHandler( изображение_DoubleClick );
            new_vpers.panel.Controls.Add( new_vpers.img );
            //добавляем панель в массив и на форму
            dynamic_content.Controls.Add( new_vpers.panel );
            mass_p.Add( new_vpers );
        }
        void add_mass( Second_person_class[] vtorpers )
        {
            foreach( Second_person_class pers in vtorpers )
            {
                add();
                mass_p[mass_p.Count - 1].name.Text = pers.фио;
                mass_p[mass_p.Count - 1].content.Text = pers.описание;
                mass_p[mass_p.Count - 1].img.Image = pers.изображение;
            }
        }
        private void изображение_DoubleClick( object sender, EventArgs e )
        {
            if( openFileDialog1.ShowDialog() == DialogResult.OK )
                ( (PictureBox) sender ).Image = Image.FromFile( openFileDialog1.FileName );
        }

    }
}
