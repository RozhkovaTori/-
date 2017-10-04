using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProgram {
    [Serializable]
    public class Book_class {
        public string название { get; set; }
        public string о_книге { get; set; }
        public string жанр { get; set; }
        public Bitmap обложка { get; set; }
        //массив глав
        List<Chapter_class> хранилище_глав = new List<Chapter_class>();
        public void add_chapter(Chapter_class add) { хранилище_глав.Add(add); }
        public void remove_chapter(Chapter_class delete) { хранилище_глав.Remove(delete); }
        public Chapter_class[] массив_глав { get { return хранилище_глав.ToArray(); } }
        //массив глав персонажей
        List<Person_class> хранилище_глав_персонажей = new List<Person_class>();
        public void add_gg(Person_class add) { хранилище_глав_персонажей.Add(add); }
        public void remove_gg(Person_class delete) { хранилище_глав_персонажей.Remove(delete); }
        public Person_class[] массив_глав_персонажей { get { return хранилище_глав_персонажей.ToArray(); } }
        //массив втор персов
        List<Second_person_class> хранилище_втор_персонажей = new List<Second_person_class>();
        public void add_second_pers(Second_person_class add) { хранилище_втор_персонажей.Add(add); }
        public void add_range_second_pers(Second_person_class[] add) { хранилище_втор_персонажей.AddRange(add); }
        public void remove_second_pers(Second_person_class delete) { хранилище_втор_персонажей.Remove(delete); }
        public Second_person_class[] массив_втор_персонажей { get { return хранилище_втор_персонажей.ToArray(); } }
        //массив локаций
        List<Location_class> хранилище_локаций = new List<Location_class>();
        public void add_location(Location_class add) { хранилище_локаций.Add(add); }
        public void add_range_location(Location_class[] add) { хранилище_локаций.AddRange(add); }
        public void remove_location(Location_class delete) { хранилище_локаций.Remove(delete); }
        public Location_class[] массив_локаций { get { return хранилище_локаций.ToArray(); } }
    }
}