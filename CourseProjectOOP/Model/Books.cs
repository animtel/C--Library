using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOOP
{
    class Books
    {
        public int id { get; set; }
        public string autor { get; set; }
        public string nameOfBook { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public int valuetion { get; set; }
        public bool Available { get; set; }

        public Books(int id, string autor, string nameOfBook, int year, string genre, int valuetion, bool Available)
        {
            this.id = id;
            this.autor = autor;
            this.nameOfBook = nameOfBook;
            this.year = year;
            this.genre = genre;
            this.valuetion = valuetion;
            this.Available = Available;
        }
    }
}
