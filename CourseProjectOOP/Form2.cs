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
    public partial class Form2 : Form
    {
        public string Id { get; set; }
        public string Autor { get; set; }
        public string NameOfBook { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Valuetion { get; set; }
        public string Available { get; set; }
        public string pathOfFile { get; set; }
        public void AddBook()
        {
            string[] library = File.ReadAllLines("Library.txt");
            

            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

            }
            book.Add(new Books(Convert.ToInt32(Id), Autor, NameOfBook, Convert.ToInt32(Year), Genre, Convert.ToInt32(Valuetion), Convert.ToBoolean(Available)));
            File.WriteAllText("Library.txt", "");

            foreach (Books dat in book)
            {
                string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
                File.AppendAllText("Library.txt", newAllBooks);
            }
            File.Move(pathOfFile, @"Library\" + comboBox1.Text + @"\" + textBox1.Text + ".pdf");


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
                    label8.Text = "*";
                }
            }

            Autor = textBox2.Text;
            NameOfBook = textBox3.Text;
            
            try
            {
                Convert.ToInt32(Autor);
                label9.Text = "*";
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
                label11.Text = "*";
                flagYear = false;
            }

            Genre = comboBox1.Text;
            
            Valuetion = textBox6.Text;
            var regValuetion = new Regex("[0-9]{0,2}");
            if (!regValuetion.IsMatch(Valuetion))
            {
                flagVal = false;
                label13.Text = "*";

            }

            Available = comboBox2.Text;

            
            //openFileDialog1.ShowDialog();
            //pathOfFile = openFileDialog1.FileName;
            //textBox4.Text = openFileDialog1.FileName;
            if(pathOfFile == "")
            {
                flagFile = false;
            }


            if (flagId && flagName && flagYear && flagVal && flagFile)
            {
                AddBook();
            }
            else
            {
                MessageBox.Show("Вы ввели неверное значение!");
                
            }

        }

        bool flag = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proverka();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //flag = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            flag = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            flag = false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            flag = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (textBox1.Focus() && flag)
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (textBox2.Focus() && flag)
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (textBox3.Focus() && flag)
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (textBox4.Focus() && flag)
            {
                textBox4.Text = "";
            }
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (textBox6.Focus() && flag)
            {
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathOfFile = openFileDialog1.FileName;
            //File.Move(openFileDialog1.FileName, @"Library\"+ comboBox1.Text+@"\" +textBox1.Text +".pdf");
            //DirectoryInfo dir = new DirectoryInfo(openFileDialog1.FileName);
            //dir.MoveTo($"Library/Fantasy");
        }
    }
}
