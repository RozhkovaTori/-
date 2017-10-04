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
    public partial class Mybooks_Foto : UserControl {
        List<PictureBox> mass = new List<PictureBox>();
        public Mybooks_Foto() {
            InitializeComponent();
            content.Controls.Clear();
            if(CForm.selfref.mass_person.Count > 0)
            foreach(Person_class o in CForm.selfref.mass_person) {   
                                add_img(o.img);
                               add_img(o.imga);
            }
            if(CForm.selfref.mass_book.Count > 0)
                 foreach(Book_class book in CForm.selfref.mass_book) {
                     if(book.массив_глав.Length > 0)
                           foreach(Chapter_class gg in book.массив_глав) 
                               foreach(Bitmap bit in gg.массив_изображений)
                                    add_img(bit);                    
                     if(book.массив_втор_персонажей.Length > 0)
                           foreach(Second_person_class sg in book.массив_втор_персонажей) 
                               add_img(sg.изображение);
                     if(book.массив_локаций.Length > 0)
                           foreach(Location_class l in book.массив_локаций) 
                               add_img(l.изображение);
                     }

        }
        void add_img(Bitmap b) {
            PictureBox p = new PictureBox();
            p.Image = b;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.Dock = DockStyle.Fill;
            content.Controls.Add(p);
        } 

    }
}
