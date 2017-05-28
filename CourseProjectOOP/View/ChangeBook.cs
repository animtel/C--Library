using LiteLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteLibrary
{
    
    public partial class ChangeBook : Form
    {
        ListOfBooks list = new ListOfBooks();
        public int indexOfRows { get; set; }
        public string pathOfFile { get; set; }
        public string Id { get; set; }
        public string Autor { get; set; }
        public string NameOfBook { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Valuetion { get; set; }
        public string Available { get; set; }
        public ChangeBook(int index)
        {
            this.indexOfRows = index;
            InitializeComponent();
            InitializeBook();
        }


        public void InitializeBook()
        {


            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();

            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }

            TBAut.Text = Convert.ToString(book[indexOfRows].autor);
            TBNameOfBook.Text = Convert.ToString(book[indexOfRows].nameOfBook);
            TBYear.Text = Convert.ToString(book[indexOfRows].year);
            CBGenre.Text = Convert.ToString(book[indexOfRows].genre);
            TBVal.Text = Convert.ToString(book[indexOfRows].valuetion);
            CBAvailable.Text = Convert.ToString(book[indexOfRows].Available);
            Id = Convert.ToString(book[indexOfRows].id);
            pathOfFile = @"Library\" + Convert.ToString(book[indexOfRows].genre) + @"\" + Convert.ToString(book[indexOfRows].id) + ".pdf";
            
        }


        public void changebook()
        {
            string[] library = File.ReadAllLines("Library.txt");

            List<Books> book = new List<Books>();

            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }

            book[indexOfRows].autor = TBAut.Text;
            book[indexOfRows].nameOfBook = TBNameOfBook.Text;
            book[indexOfRows].year = Convert.ToInt32(TBYear.Text);
            book[indexOfRows].genre = CBGenre.Text;
            book[indexOfRows].valuetion = Convert.ToInt32(TBVal.Text);
            book[indexOfRows].Available = Convert.ToBoolean(CBAvailable.Text);

            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);
            }
            File.Move(pathOfFile, @"Library\" + CBGenre.Text + @"\" + Id + ".pdf");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Proverka();
            MainView form1 = new MainView();
            list.ShowAllBooks();
            Close();

        }

        public void Proverka()
        {
            string[] library = File.ReadAllLines("Library.txt");


            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

            }

            bool flagName = true;
            bool flagId = true;
            bool flagYear = true;
            bool flagVal = true;
            bool flagFile = true;


            Autor = TBAut.Text;
            NameOfBook = TBNameOfBook.Text;

            try
            {
                Convert.ToInt32(Autor);
                flagName = false;
            }
            catch (Exception ex)
            {
                flagName = true;
            }

            Year = TBYear.Text;
            var regYear = new Regex("^[0-9]{4}$");
            if (!regYear.IsMatch(Year))
            {
                flagYear = false;
            }

            Genre = CBGenre.Text;

            Valuetion = TBVal.Text;
            var regValuetion = new Regex("[0-9]{0,2}");
            if (!regValuetion.IsMatch(Valuetion))
            {
                flagVal = false;
            }

            Available = CBAvailable.Text;

            if (flagId && flagName && flagYear && flagVal)
            {
                changebook();
            }
            else
            {
                MessageBox.Show("Вы ввели неверное значение!");
            }
        }

        bool flag = true;

    }
}
