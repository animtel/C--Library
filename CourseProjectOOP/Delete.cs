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
    public partial class Delete : Form
    {
        ListOfBooks list = new ListOfBooks();
        public Delete()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //public void DeleteBookById()
        //{
        //    string searchId = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[0] != searchId)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}

        //public void DeleteBookByAutor()
        //{
        //    string searchAutor = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[1] != searchAutor)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}

        //public void DeleteBookByNameOfBook()
        //{
        //    string searchName = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[2] != searchName)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}

        //public void DeleteBookByYear()
        //{
        //    string searchYear = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[3] != searchYear)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}

        //public void DeleteBookByGenre()
        //{
        //    string searchGenre = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[4] != searchGenre)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}

        //public void DeleteBookByValuetion()
        //{
        //    string searchValuetion = texValue.Text;
        //    string[] library = File.ReadAllLines("Library.txt");

        //    List<Books> book = new List<Books>();
        //    foreach (string str in library)
        //    {

        //        string[] newLib = str.Split(',');
        //        if (newLib[5] != searchValuetion)
        //        {
        //            book.Add(new Books(Convert.ToInt32(newLib[0]), newLib[1], newLib[2], Convert.ToInt32(newLib[3]), newLib[4], Convert.ToInt32(newLib[5]), Convert.ToBoolean(newLib[6])));

        //        }
        //    }
        //    File.WriteAllText("Library.txt", "");
        //    foreach (Books dat in book)
        //    {
        //        string newAllBooks = $"{Convert.ToString(dat.id)},{dat.autor},{dat.nameOfBook},{Convert.ToString(dat.year)},{dat.genre},{Convert.ToString(dat.valuetion)},{dat.Available}\r\n";
        //        File.AppendAllText("Library.txt", newAllBooks);


        //    }
        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WhatAreYouWantToDelete = ChooseDel.Text;
            switch (WhatAreYouWantToDelete)
            {
                case "Delete by id":
                    list.DeleteBookById(ChooseDel.Text);
                    break;
                case "Delete by autor":
                    list.DeleteBookByAutor(ChooseDel.Text);
                    break;
                case "Delete by name of book":
                    list.DeleteBookByNameOfBook(ChooseDel.Text);
                    break;
                case "Delete by year":
                    list.DeleteBookByYear(ChooseDel.Text);
                    break;
                case "Delete by genre":
                    list.DeleteBookByGenre(ChooseDel.Text);
                    break;
                case "Delete by valuetion":
                    list.DeleteBookByValuetion(ChooseDel.Text);
                    break;
                default:
                    label1.Text = "Вы ввели неверное значение!\r\n";
                    break;
            }
        }
    }
}
