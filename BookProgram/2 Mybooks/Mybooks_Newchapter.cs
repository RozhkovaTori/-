using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class Mybooks_Newchapter : UserControl
    {
        //bool cr;
        //PictureBox[] pic_mass = new PictureBox[0];
        public Mybooks_Newchapter( bool create )
        {
            InitializeComponent();
            //cr = create;
            //if (cr) название.ReadOnly = false; else название.ReadOnly = true;    
        }
        private void pictureBox2_Click( object sender, EventArgs e )
        {
            //string error = "";
            //if (isClonНазв()) error += "Ошибка: Такая глава уже существует";
            //if (String.IsNullOrEmpty(название.Text)) error += "Ошибка: Поле название пустое";
            //if (error == "") {
            //    Chapter_class cc = new Chapter_class();
            //    cc.контент = контент.Text;
            //    cc.оглавнение = название.Text;
            //    List<Bitmap> temp_b = new List<Bitmap>();
            //    foreach (PictureBox p in pic_mass)
            //        if (p.Image != Properties.Resources.Для_пикчербоксов)
            //            temp_b.Add(new Bitmap(p.Image));
            //    CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].add_chapter(cc);
            //    Mybooks_Oglavlenie.selfref_Mybooks_Oglavlenie.refrash_list();
            //    CFormDialog.CRefDialog.CloseCFormDialog();
            //}
            //else {
            //    CFormMessage s = new CFormMessage(error);
            //    s.Show();
            //}
        }
        // bool isClonНазв() {
        //foreach (Chapter_class b in CForm.selfref.mass_book[Mybooks.selfref_Mybooks.mybook.SelectedIndex].массив_глав)
        //    if (b.оглавнение == название.Text)
        //        return true;
        //return false;
        // }
        private void обложка_DoubleClick( object sender, EventArgs e )
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            ( (PictureBox) sender ).Image = Image.FromFile( openFileDialog1.FileName );
        }
        public void init_poly( Chapter_class chapter )
        {
            //название.Text = chapter.оглавнение;
            //контент.Text = chapter.контент;
            //add_picturebox(chapter.массив_изображений);
        }
        void add_picturebox( Bitmap b )
        {
            //add_img_separator();  
            //Array.Resize(ref pic_mass, pic_mass.Length + 1);
            //pic_mass[pic_mass.Length - 1] = new PictureBox();
            //pic_mass[pic_mass.Length - 1].Dock = DockStyle.Top;
            //pic_mass[pic_mass.Length - 1].Image = b;
            //pic_mass[pic_mass.Length - 1].SizeMode = PictureBoxSizeMode.Zoom;
            //pic_mass[pic_mass.Length - 1].BorderStyle = BorderStyle.FixedSingle;
            //pic_mass[pic_mass.Length - 1].Height = pic_mass[pic_mass.Length - 1].Width + pic_mass[pic_mass.Length - 1].Width;
            //pic_mass[pic_mass.Length - 1].DoubleClick += new EventHandler(обложка_DoubleClick);
            //imagelist.Controls.Add(pic_mass[pic_mass.Length - 1]);
        }
        void add_picturebox( Bitmap[] b )
        {
            //foreach (Bitmap bb in b) {
            //    add_img_separator();  
            //    Array.Resize(ref pic_mass, pic_mass.Length + 1);
            //    pic_mass[pic_mass.Length - 1] = new PictureBox();
            //    pic_mass[pic_mass.Length - 1].Dock = DockStyle.Top;
            //    pic_mass[pic_mass.Length - 1].Image = bb;
            //    pic_mass[pic_mass.Length - 1].SizeMode = PictureBoxSizeMode.Zoom;
            //    pic_mass[pic_mass.Length - 1].BorderStyle = BorderStyle.FixedSingle;
            //    pic_mass[pic_mass.Length - 1].Height = pic_mass[pic_mass.Length - 1].Width + pic_mass[pic_mass.Length - 1].Width;
            //    pic_mass[pic_mass.Length - 1].DoubleClick += new EventHandler(обложка_DoubleClick);
            //    imagelist.Controls.Add(pic_mass[pic_mass.Length - 1]);
        }
    }
    // private void pictureBox3_Click(object sender, EventArgs e) {
    //add_img_separator();  
    //Array.Resize(ref pic_mass, pic_mass.Length + 1);
    //pic_mass[pic_mass.Length - 1] = new PictureBox();
    //pic_mass[pic_mass.Length - 1].Dock = DockStyle.Top;
    //pic_mass[pic_mass.Length - 1].Image = Properties.Resources.Для_пикчербоксов;
    //pic_mass[pic_mass.Length - 1].SizeMode = PictureBoxSizeMode.Zoom;
    //pic_mass[pic_mass.Length - 1].BorderStyle = BorderStyle.FixedSingle;
    //pic_mass[pic_mass.Length - 1].Height = pic_mass[pic_mass.Length - 1].Width + pic_mass[pic_mass.Length - 1].Width;
    //pic_mass[pic_mass.Length - 1].DoubleClick += new EventHandler(обложка_DoubleClick);
    //imagelist.Controls.Add(pic_mass[pic_mass.Length - 1]);       
    //  }
    // void add_img_separator() { 
    //PictureBox separator = new PictureBox();
    // separator.Dock = DockStyle.Top;
    // separator.Image = Properties.Resources.разделитель1;
    // separator.SizeMode = PictureBoxSizeMode.Zoom;
    // imagelist.Controls.Add(separator);
    // }
}

