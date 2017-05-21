using CourseProjectOOP.Model;
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

namespace CourseProjectOOP
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

            textBox1.Text = Convert.ToString(book[indexOfRows].id);
            textBox2.Text = Convert.ToString(book[indexOfRows].autor);
            textBox3.Text = Convert.ToString(book[indexOfRows].nameOfBook);
            textBox4.Text = Convert.ToString(book[indexOfRows].year);
            comboBox1.Text = Convert.ToString(book[indexOfRows].genre);
            textBox6.Text = Convert.ToString(book[indexOfRows].valuetion);
            comboBox2.Text = Convert.ToString(book[indexOfRows].Available);

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

            book[indexOfRows].id = Convert.ToInt32(textBox1.Text);
            book[indexOfRows].autor = textBox2.Text;
            book[indexOfRows].nameOfBook = textBox3.Text;
            book[indexOfRows].year = Convert.ToInt32(textBox4.Text);
            book[indexOfRows].genre = comboBox1.Text;
            book[indexOfRows].valuetion = Convert.ToInt32(textBox6.Text);
            book[indexOfRows].Available = Convert.ToBoolean(comboBox2.Text);

            File.WriteAllText("Library.txt", "");
            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);
            }
            File.Move(pathOfFile, @"Library\" + comboBox1.Text + @"\" + textBox1.Text + ".pdf");


        }
        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Proverka();
            changebook();
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



            Id = textBox1.Text;
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');
                if (Id == newLib[0])
                {
                    flagId = false;
                    //label8.Text = "*";
                }
            }

            Autor = textBox2.Text;
            NameOfBook = textBox3.Text;

            try
            {
                Convert.ToInt32(Autor);
                //label9.Text = "*";
                flagName = false;
            }
            catch (Exception ex)
            {
                flagName = true;
            }

            Year = textBox4.Text;
            var regYear = new Regex("^[0-9]{4}$");
            if (!regYear.IsMatch(Year))
            {
                //label11.Text = "*";
                flagYear = false;
            }

            Genre = comboBox1.Text;

            Valuetion = textBox6.Text;
            var regValuetion = new Regex("[0-9]{0,2}");
            if (!regValuetion.IsMatch(Valuetion))
            {
                flagVal = false;
                //label13.Text = "*";

            }

            Available = comboBox2.Text;


            //openFileDialog1.ShowDialog();
            //pathOfFile = openFileDialog1.FileName;
            //textBox4.Text = openFileDialog1.FileName;
            if (pathOfFile == "")
            {
                flagFile = false;
            }


            if (flagId && flagName && flagYear && flagVal && flagFile)
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
