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
        ListOfBooks list = new ListOfBooks(); // list of book`s methods
        public Delete()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WhatAreYouWantToDelete = textChoose.Text;
            switch (WhatAreYouWantToDelete)
            {
                case "Delete by id":
                    list.DeleteBookById(textChoose.Text);
                    break;
                case "Delete by autor":
                    list.DeleteBookByAutor(textChoose.Text);
                    break;
                case "Delete by name of book":
                    list.DeleteBookByNameOfBook(textChoose.Text);
                    break;
                case "Delete by year":
                    list.DeleteBookByYear(textChoose.Text);
                    break;
                case "Delete by genre":
                    list.DeleteBookByGenre(textChoose.Text);
                    break;
                case "Delete by valuetion":
                    list.DeleteBookByValuetion(textChoose.Text);
                    break;
                default:
                    label1.Text = "Вы ввели неверное значение!\r\n";
                    break;
            }
        } // switch for calling method from list`s methods.
    }
}
