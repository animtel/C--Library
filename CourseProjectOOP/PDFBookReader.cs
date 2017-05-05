using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectOOP
{
    public partial class PDFBookReader : Form
    {
        public int index { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }

        public PDFBookReader(int ind, int id, string genre)
        {
            InitializeComponent();
            this.index = ind;
            this.Id = id;
            this.Genre = genre;
            //axAcroPDF1.src = @"Library\" + Genre + @"\" + Id + ".pdf";
            axAcroPDF1.LoadFile(@"Library\" + Genre + @"\" + Id + ".pdf");

        }

        private void PDFBookReader_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
