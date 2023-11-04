using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Arxivper : UserControl
    {
        public static Arxivper selfref_Arxivper { get; set; }

        public Arxivper()
        {
            InitializeComponent();
            list.Sorted = true;
            if( list.Items.Count > 0 ) refrash_list();
        }
        public void refrash_list()
        {
            list.Items.Clear();
            foreach( Person_class p in CForm.selfref.mass_person )
                list.Items.Add( p.fio );
        }
        public void refrash_tab()
        {
            if( list.SelectedIndex >= 0 )
                variable.TabPages.Clear();
            foreach( Person_class p in CForm.selfref.mass_person )
                if( list.SelectedItem.ToString() == p.id )
                {
                    if( p.is_gg ) variable.TabPages.Add( new TabPage( "Главный персонаж" ) );
                    else variable.TabPages.Add( new TabPage( "Вариация " + CForm.selfref.mass_person.Count.ToString() ) );
                }
        }
        public void save_content()
        {
            foreach( Person_class pv in CForm.selfref.mass_person )
                if( pv.id == variable.SelectedTab.Text )
                {
                    pv.fio = FIO.Text;
                    pv.прозвище = прозвище.Text;
                    pv.образ = образ.Text;
                    pv.возраст = возраст.Text;
                    pv.дата = дата.Text;
                    pv.пол = пол.Text;
                    pv.раса = раса.Text;
                    pv.место_рождения = место_рождения.Text;
                    pv.профессия = профессия.Text;
                    pv.приндалженость = приндалженость.Text;
                    pv.биография = биография.Text;
                    pv.взаимоотношения = взаимоотношения.Text;
                    pv.характер = характер.Text;
                    pv.преимущества = преимущества.Text;
                    pv.факты = факты.Text;
                    pv.внешность = внешность.Text;
                    pv.увлечения = увлечения.Text;
                    pv.способности = способности.Text;
                    pv.эффекты = эффекты.Text;
                    pv.доп_информация = доп_информация.Text;
                    pv.книга = книга.Text;
                    pv.источник = источник.Text;
                    pv.короткий_сюжет = короткий_сюжет.Text;
                    pv.заметки = заметки.Text;
                    if( профиль.Image != null ) pv.img = new Bitmap( профиль.Image );
                    if( гориз_профиль.Image != null ) pv.imga = new Bitmap( гориз_профиль.Image );
                    if( горизонтал.Image != null ) pv.imgak = new Bitmap( горизонтал.Image );
                    CForm.selfref.save_to_file( "default.bm" );
                    break;
                }
        }
        public void load_content()
        {
            foreach( Person_class pv in CForm.selfref.mass_person )
                if( pv.id == variable.SelectedTab.Text )
                {
                    FIO.Text = pv.fio;
                    образ.Text = pv.образ;
                    прозвище.Text = pv.прозвище;
                    возраст.Text = pv.возраст;
                    дата.Text = pv.дата;
                    пол.Text = pv.пол;
                    раса.Text = pv.раса;
                    место_рождения.Text = pv.место_рождения;
                    профессия.Text = pv.профессия;
                    приндалженость.Text = pv.приндалженость;
                    биография.Text = pv.биография;
                    взаимоотношения.Text = pv.взаимоотношения;
                    характер.Text = pv.характер;
                    преимущества.Text = pv.преимущества;
                    факты.Text = pv.факты;
                    внешность.Text = pv.внешность;
                    увлечения.Text = pv.увлечения;
                    способности.Text = pv.способности;
                    эффекты.Text = pv.эффекты;
                    доп_информация.Text = pv.доп_информация;
                    книга.Text = pv.книга;
                    источник.Text = pv.источник;
                    короткий_сюжет.Text = pv.короткий_сюжет;
                    заметки.Text = pv.заметки;
                    профиль.Image = (Image) pv.img;
                    гориз_профиль.Image = (Image) pv.imga;
                    горизонтал.Image = (Image) pv.imgak;
                    break;
                }
        }
        private void add_p_Click( object sender, EventArgs e )
        {
            Person_class p = new Person_class();
            p.fio = "Новый персонаж " + CForm.selfref.mass_person.Count.ToString();
            p.id = p.fio;
            p.is_gg = true;
            CForm.selfref.mass_person.Add( p );
            refrash_list();
        }
        private void delete_p_Click( object sender, EventArgs e )
        {

        }
        private void add_tab_Click( object sender, EventArgs e )
        {

        }
        private void delete_tab_Click( object sender, EventArgs e )
        {

        }
        private void list_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( list.SelectedIndex >= 0 )
            {
                refrash_tab();
                load_content();
            }
        }

        private void label23_Click( object sender, EventArgs e )
        {

        }
    }
}
