using System;
using System.Collections.Generic;
using System.Drawing;

namespace BookProgram
{
    [Serializable]
    public class Chapter_class
    {
        public string оглавнение { get; set; }
        public string контент { get; set; }
        List<Bitmap> изображения = new List<Bitmap>();
        public void add_bitmap( Bitmap add ) { изображения.Add( add ); }
        public void add_range_bitmap( Bitmap[] add_range ) { изображения.AddRange( add_range ); }
        public void remove_chapter( Bitmap delete ) { изображения.Remove( delete ); }
        public Bitmap[] массив_изображений { get { return изображения.ToArray(); } }
    }
}
