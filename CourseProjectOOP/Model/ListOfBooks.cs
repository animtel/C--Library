using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOOP.Model
{
    class ListOfBooks
    {

        #region FindBook
        //MainView search = new MainView();
        public List<Books> FindBookAsId(string id, string available)
        {
            string searchId = id;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();

            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }

            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.id == Convert.ToInt32(searchId) && data.Available == Convert.ToBoolean(available.ToLower()))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> FindBookAsAutor(string autor, string available)
        {
            string searchAutor = autor;

            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

            }


            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.autor == searchAutor && data.Available == Convert.ToBoolean(available))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> FindBookAsName(string name, string available)
        {
            string searchName = name;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }


            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.nameOfBook == searchName && data.Available == Convert.ToBoolean(available))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> FindBookAsYear(string year, string available)
        {
            string searchYear = year;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }


            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.year == Convert.ToInt32(searchYear) && data.Available == Convert.ToBoolean(available))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> FindBookAsGenre(string genre)
        {
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }


            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.genre == genre)
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> FindBookAsValuetion(string valuation)
        {
            string searchValuetion = valuation;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }


            List<Books> p = new List<Books>();
            foreach (Books data in book)
            {
                if (data.valuetion == Convert.ToInt32(searchValuetion))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            return p;
        }
        public List<Books> ShowAllBooks()
        {
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }
            return book;
        }
        #endregion

        #region DeleteBook

        public void DeleteBookById(string id)
        {
            string searchId = id;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[0] != searchId)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        public void DeleteBookByAutor(string autor)
        {
            string searchAutor = autor;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[1] != searchAutor)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        public void DeleteBookByNameOfBook(string name)
        {
            string searchName = name;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[2] != searchName)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        public void DeleteBookByYear(string year)
        {
            string searchYear = year;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[3] != searchYear)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        public void DeleteBookByGenre(string genre)
        {
            string searchGenre = genre;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[4] != searchGenre)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        public void DeleteBookByValuetion(string valuetion)
        {
            string searchValuetion = valuetion;
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {

                string[] newLib = str.Split(',');
                if (newLib[5] != searchValuetion)
                {
                    book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

                }
            }
            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);


            }
        }

        #endregion
    }
}
