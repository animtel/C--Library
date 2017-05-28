using LiteLibrary.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiteLibrary
{
    public partial class MainView : Form
    {
        ListOfBooks list = new ListOfBooks();
        public Graphics g;
        public Bitmap map;
        public Pen p;
        public double angle = Math.PI / 2;
        public double ang1 = Math.PI / 4;
        public double ang2 = Math.PI / 6;

        public int index { get; set; }
        public int IdOfBook { get; set; }
        public string GenreOfBook { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(PBTree.Width, PBTree.Height);
            g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Green);

            DrawTree(150, 300, 100, angle);

            PBTree.BackgroundImage = map;
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
        

        public bool flag = true;
        

        public MainView()
        {
            InitializeComponent();
            Table.DataSource = list.ShowAllBooks();
        }

        private void textBoxID(object sender, EventArgs e)
        {

        }

        

        private void buttonShowAllBooks(object sender, EventArgs e)
        {
            Table.DataSource = list.ShowAllBooks();
        }

        public string ChooseYourAvailableOfBook()
        {
            string result = "";
            
            return result;
        }

        public string ChooseYourGenre()
        {
            string result = "";

            switch (CBGenre.Text)
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
            string Available = CBAvailable.Text;
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
            string WhatAreYouWantToSearch = CBSearch.Text;
            switch (WhatAreYouWantToSearch)
            {
                case "Search as id":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsId(TBSearch.Text, CBAvailable.Text.ToLower());
                    break;
                case "Search as Autor":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsAutor(TBSearch.Text, CBAvailable.Text.ToLower());
                    break;
                case "Search as Name":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsName(TBSearch.Text, CBAvailable.Text.ToLower());
                    break;
                case "Search as Year":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsYear(TBSearch.Text, CBAvailable.Text.ToLower());
                    break;
                case "Search as Genre":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsGenre(ChooseYourGenre());
                    break;
                case "Search as Valuetion":
                    ChooseYourGenre();
                    ChooseYourAvailable();
                    Table.DataSource = list.FindBookAsValuetion(TBSearch.Text);
                    break;
                default:
                    
                    break;
            }
        } // Главная кнопка поиска!

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table.DataSource = list.ShowAllBooks();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (TBSearch.Focus() && flag)
            {
                TBSearch.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ChangeBook change = new ChangeBook(index);

            change.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = index;
            int Id = IdOfBook;
            string Genre = GenreOfBook;
            if (ind != null)
            {
                PDFBookReader reader = new PDFBookReader(ind, Id, Genre);
                reader.Show();
            }
            else
            {
                MessageBox.Show("Вы не выбрали книгу!");
            }
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            IdOfBook = Convert.ToInt32(Table.Rows[index].Cells[0].Value);
            GenreOfBook = Convert.ToString(Table.Rows[index].Cells[4].Value);
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
