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
    //**********************************************************************************************************************************
    public partial class Form1 : Form
    {
        public Graphics g;
        public Bitmap map;
        public Pen p;
        public double angle = Math.PI / 2;
        public double ang1 = Math.PI / 4;
        public double ang2 = Math.PI / 6;

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Green);

            DrawTree(150, 300, 100, angle);

            pictureBox1.BackgroundImage = map;
        }
        public int DrawTree(double x, double y, double a, double angle)
        {

            if (a > 2)
            {
                a *= 0.7;

                double xnew = Math.Round(x + a * Math.Cos(angle)),
                       ynew = Math.Round(y - a * Math.Sin(angle));

                g.DrawLine(p, (float)x, (float)y, (float)xnew, (float)ynew);

                x = xnew;
                y = ynew;

                DrawTree(x, y, a, angle + ang1);
                DrawTree(x, y, a, angle - ang2);
            }
            return 0;
        }
        //*******************************************************************************************************************************
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public bool flag = true;
        

        public Form1()
        {
            InitializeComponent();
            ShowAllBooks();
        }

        private void textBoxID(object sender, EventArgs e)
        {

        }

        
        public void FindBookAsId()
        {
            string searchId = textBox1.Text;
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
                if (data.id == Convert.ToInt32(searchId) && data.Available == Convert.ToBoolean(comboBox3.Text.ToLower()))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            dataGridView1.DataSource = p;
        }

        public void FindBookAsAutor()
        {
            string searchAutor = textBox1.Text;
            
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
                if (data.autor == searchAutor && data.Available == Convert.ToBoolean(comboBox3.Text.ToLower()))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            dataGridView1.DataSource = p;
        }

        public void FindBookAsName()
        {
            string searchName = textBox1.Text;
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
                if (data.nameOfBook == searchName && data.Available == Convert.ToBoolean(comboBox3.Text.ToLower()))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            dataGridView1.DataSource = p;
        }

        public void FindBookAsYear()
        {
            string searchYear = textBox1.Text;
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
                if (data.year == Convert.ToInt32(searchYear) && data.Available == Convert.ToBoolean(comboBox3.Text.ToLower()))
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            dataGridView1.DataSource = p;
        }

                    
        public void FindBookAsGenre()
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
                if (data.genre == comboBox2.Text)
                {
                    p.Add(new Books(data.id, data.autor, data.nameOfBook, data.year, data.genre, data.valuetion, data.Available));
                }
            }
            dataGridView1.DataSource = p;
        }

        public void FindBookAsValuetion()
        {
            string searchValuetion = textBox1.Text;
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
            dataGridView1.DataSource = p;
        }

        public void ShowAllBooks()
        {
            string[] library = File.ReadAllLines("Library.txt");



            List<Books> book = new List<Books>();
            foreach (string str in library)
            {
                string[] newLib = str.Split(',');

                book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));
            }
            dataGridView1.DataSource = book;
            



            


        }

        private void buttonShowAllBooks(object sender, EventArgs e)
        {
            
            
            ShowAllBooks();
        }

        private void labelAllBooks(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        



        public string ChooseYourAvailableOfBook()
        {
            string result = "";
            
            return result;
        }

        public string ChooseYourGenre()
        {
            string result = "";

            switch (comboBox2.Text)
            {
                case "Fantasy":
                    result = "Fantasy";
                    break;
                case "Romans":
                    result = "Romans";
                    break;
                case "Childrens lit":
                    result = "Childrens lit";
                    break;
                case "Detectiv":
                    result = "Detectiv";
                    break;
                case "Mistic":
                    result = "Mistic";
                    break;
                default:
                    result = "Genre";
                    break;
            }
            return result;
        } // Жанры!

        public string ChooseYourAvailable()
        {
            string Available = comboBox3.Text;
            string result = "";
            switch (Available)
            {
                case "Are available":
                    return result = "Are available";
                    break;
                case "Aren`t available":
                    return result = "Aren`t available";
                    break;
                default:
                    return result = "Available";
                    break;
            }
        } //Есть или нет в наличии!

        private void button3_Click(object sender, EventArgs e)
        {
            string WhatAreYouWantToSearch = comboBox1.Text;
            switch (WhatAreYouWantToSearch)
            {
                case "Search as id":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsId();
                    break;
                case "Search as Autor":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsAutor();
                    break;
                case "Search as Name":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsName();
                    break;
                case "Search as Year":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsYear();
                    break;
                case "Search as Genre":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsGenre();
                    break;
                case "Search as Valuetion":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    FindBookAsValuetion();
                    break;
                default:
                    
                    break;
            }
        } // Главная кнопка поиска!

        //public void Dich()
        //{
        //    string[] library = File.ReadAllLines("Library.txt");
        //    List<Books> person = new List<Books>();
        //    List<Books> person1 = new List<Books>();

        //    dataGridView1.DataSource = person;
        //    //File.AppendAllText("person.txt", Convert.ToString(dataGridView1.DataSource));

        //    List<Books> Changed = new List<Books>();
        //    foreach (string str in library)
        //    {
        //        string[] newPer = str.Split(',');

        //        person.Add(new Books(Convert.ToInt32(newPer[0]), newPer[1], newPer[2], Convert.ToInt32(newPer[3]), newPer[4], Convert.ToInt32(newPer[5]), Convert.ToBoolean(newPer[6])));
        //    }
        //    string[] st = library[0].Split(',');
        //    string[,] arr = new string[library.Length - 1, st.Length - 1];
        //    for (int i = 0; i < library.Length; i++)
        //    {
        //        for (int j = 0; j < st.Length; j++)
        //        {
        //            arr[i, j] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
        //        }
        //    }


        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {

        //        Changed.Add(new Books(Convert.ToInt32(arr[i, 0]), arr[i, 1], arr[i, 2], Convert.ToInt32(arr[i, 3]), arr[i, 4], Convert.ToInt32(arr[i, 5]), Convert.ToBoolean(arr[i, 6])));

        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books p in Changed)
        //    {
        //        string newAllPerson = $"{p.id},{p.autor},{p.nameOfBook},{p.year},{p.genre},{p.valuetion},{p.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllPerson);
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

       

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllBooks();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Focus() && flag)
            {
                textBox1.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            form.Show();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ChangeBook change = new ChangeBook(index);

            change.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFBookReader reader = new PDFBookReader();
            reader.Show();
        }
    }
}
