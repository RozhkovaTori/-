using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProgram {
    [Serializable]
    public class Location_class {
        public string название { get; set; }
        public string описание { get; set; }
        public Bitmap изображение { get; set; }
    }
}
