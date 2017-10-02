using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProgram
{
    
    [Serializable]
    public class Person_class
    {
        public string fio { get; set; }
        public string образ { get; set; }
        public string прозвище { get; set; }
        public string возраст { get; set; }
        public string дата { get; set; }
        public string пол { get; set; }
        public string раса { get; set; }
        public string место_рождения { get; set; }
        public string профессия { get; set; }
        public string приндалженость { get; set; }

        public string биография { get; set; }
        public string взаимоотношения { get; set; }

        public string характер { get; set; }
        public string преимущества { get; set; }
        public string факты { get; set; }
        public string внешность { get; set; }
        public string увлечения { get; set; }
        public string способности { get; set; }
        public string эффекты { get; set; }

        public string доп_информация { get; set; }

        public string книга { get; set; }
        public string источник { get; set; }
        public string короткий_сюжет { get; set; }

        public string заметки { get; set; }

        public Bitmap img { get; set; }
        public Bitmap imga { get; set; }
        public Bitmap imgak { get; set; }
      
        List<Person_var_class> var = new List<Person_var_class>();

        public void add_var(Person_var_class add) { var.Add(add); }

        public void remove_var(Person_var_class remove) { var.Remove(remove); }

        public Person_var_class[] get_var { get { return var.ToArray(); } }
    }

}
