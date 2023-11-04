using System;
using System.Drawing;

namespace BookProgram
{
    [Serializable]
    public class Location_class
    {
        public string название { get; set; }
        public string описание { get; set; }
        public Bitmap изображение { get; set; }
    }
}
