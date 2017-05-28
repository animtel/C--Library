using LiteLibrary.Model;
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

namespace LiteLibrary
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

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Вы дейсвтиетельно хотите удалить унигу?";
            string caption = "Deleting";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string WhatAreYouWantToDelete = combotextChoose.Text;
                string val = texValue.Text;
                switch (WhatAreYouWantToDelete)
                {
                    case "Delete by id":
                        list.DeleteBookById(val);
                        break;
                    case "Delete by autor":
                        list.DeleteBookByAutor(val);
                        break;
                    case "Delete by name of book":
                        list.DeleteBookByNameOfBook(val);
                        break;
                    case "Delete by year":
                        list.DeleteBookByYear(val);
                        break;
                    case "Delete by genre":
                        list.DeleteBookByGenre(val);
                        break;
                    case "Delete by valuetion":
                        list.DeleteBookByValuetion(val);
                        break;
                    default:
                        label1.Text = "Вы ввели неверное значение!\r\n";
                        break;
                }
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
