using CourseProjectOOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectOOP
{
    public partial class ChangeBook : Form
    {
        ListOfBooks list = new ListOfBooks();
        public int indexOfRows { get; set; }
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
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changebook();
            MainView form1 = new MainView();
            list.ShowAllBooks();
            Close();

        }
    }
}
