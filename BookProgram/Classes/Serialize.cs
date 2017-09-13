using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProgram
{
    [Serializable]
    public class Serialize
    {
       public List<Person_class> persons { get; set; }
       public List<Book_class> books { get; set; }
    }
}
