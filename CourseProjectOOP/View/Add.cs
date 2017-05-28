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
    public partial class Add : Form
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
            File.Move(pathOfFile, @"Library\" + CBGenre.Text + @"\" + TBId.Text + ".pdf");
            


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

            
            
            Id = TBId.Text;
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');
                if (Id == newLib[0])
                {
                    flagId = false;
                    label8.Text = "*";
                }
            }

            Autor = TBAutor.Text;
            NameOfBook = TBNameBook.Text;
            
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
            
            Year = TBYear.Text;
            var regYear = new Regex("^[0-9]{4}$");
            if (!regYear.IsMatch(Year))
            {
                label11.Text = "*";
                flagYear = false;
            }

            Genre = CBGenre.Text;
            
            Valuetion = CBVal.Text;
            var regValuetion = new Regex("[0-9]{0,2}");
            if (!regValuetion.IsMatch(Valuetion))
            {
                flagVal = false;
                label13.Text = "*";

            }

            Available = CBAvailable.Text;

            
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

        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proverka();
            this.Close();
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (TBId.Focus() && flag)
            {
                TBId.Text = "";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (TBAutor.Focus() && flag)
            {
                TBAutor.Text = "";
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (TBNameBook.Focus() && flag)
            {
                TBNameBook.Text = "";
            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (TBYear.Focus() && flag)
            {
                TBYear.Text = "";
            }
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            flag = true;
            if (CBVal.Focus() && flag)
            {
                CBVal.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathOfFile = openFileDialog1.FileName;

        }

    }
}
