namespace LiteLibrary
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBId = new System.Windows.Forms.TextBox();
            this.TBAutor = new System.Windows.Forms.TextBox();
            this.TBNameBook = new System.Windows.Forms.TextBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.butAddBook = new System.Windows.Forms.Button();
            this.CBVal = new System.Windows.Forms.TextBox();
            this.CBGenre = new System.Windows.Forms.ComboBox();
            this.CBAvailable = new System.Windows.Forms.ComboBox();
            this.labId = new System.Windows.Forms.Label();
            this.labAut = new System.Windows.Forms.Label();
            this.labNamOfBook = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labGenre = new System.Windows.Forms.Label();
            this.labVal = new System.Windows.Forms.Label();
            this.labAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.butChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(157, 12);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(163, 20);
            this.TBId.TabIndex = 0;
            this.TBId.Text = "Id";
            this.TBId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // TBAutor
            // 
            this.TBAutor.Location = new System.Drawing.Point(157, 56);
            this.TBAutor.Name = "TBAutor";
            this.TBAutor.Size = new System.Drawing.Size(163, 20);
            this.TBAutor.TabIndex = 1;
            this.TBAutor.Text = "Autor";
            this.TBAutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.TBAutor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TBNameBook
            // 
            this.TBNameBook.Location = new System.Drawing.Point(157, 103);
            this.TBNameBook.Name = "TBNameBook";
            this.TBNameBook.Size = new System.Drawing.Size(163, 20);
            this.TBNameBook.TabIndex = 2;
            this.TBNameBook.Text = "Name Of book";
            this.TBNameBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            this.TBNameBook.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(157, 153);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(163, 20);
            this.TBYear.TabIndex = 3;
            this.TBYear.Text = "Year";
            this.TBYear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseClick);
            this.TBYear.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // butAddBook
            // 
            this.butAddBook.Location = new System.Drawing.Point(245, 396);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(75, 23);
            this.butAddBook.TabIndex = 4;
            this.butAddBook.Text = "Add Book";
            this.butAddBook.UseVisualStyleBackColor = true;
            this.butAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBVal
            // 
            this.CBVal.Location = new System.Drawing.Point(157, 258);
            this.CBVal.Name = "CBVal";
            this.CBVal.Size = new System.Drawing.Size(163, 20);
            this.CBVal.TabIndex = 6;
            this.CBVal.Text = "Valuetion";
            this.CBVal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseClick);
            this.CBVal.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CBGenre
            // 
            this.CBGenre.FormattingEnabled = true;
            this.CBGenre.Items.AddRange(new object[] {
            "Fantasy",
            "Romans",
            "Childrens lit",
            "Detectiv",
            "Mistic"});
            this.CBGenre.Location = new System.Drawing.Point(157, 203);
            this.CBGenre.Name = "CBGenre";
            this.CBGenre.Size = new System.Drawing.Size(163, 21);
            this.CBGenre.TabIndex = 9;
            this.CBGenre.Text = "Genre";
            // 
            // CBAvailable
            // 
            this.CBAvailable.FormattingEnabled = true;
            this.CBAvailable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CBAvailable.Location = new System.Drawing.Point(157, 305);
            this.CBAvailable.Name = "CBAvailable";
            this.CBAvailable.Size = new System.Drawing.Size(163, 21);
            this.CBAvailable.TabIndex = 10;
            this.CBAvailable.Text = "Available";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(16, 19);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(86, 13);
            this.labId.TabIndex = 11;
            this.labId.Text = "Enter ID of Book";
            // 
            // labAut
            // 
            this.labAut.AutoSize = true;
            this.labAut.Location = new System.Drawing.Point(16, 62);
            this.labAut.Name = "labAut";
            this.labAut.Size = new System.Drawing.Size(60, 13);
            this.labAut.TabIndex = 12;
            this.labAut.Text = "Enter Autor";
            // 
            // labNamOfBook
            // 
            this.labNamOfBook.AutoSize = true;
            this.labNamOfBook.Location = new System.Drawing.Point(16, 109);
            this.labNamOfBook.Name = "labNamOfBook";
            this.labNamOfBook.Size = new System.Drawing.Size(103, 13);
            this.labNamOfBook.TabIndex = 13;
            this.labNamOfBook.Text = "Enter Name of Book";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(16, 153);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(57, 13);
            this.labYear.TabIndex = 14;
            this.labYear.Text = "Enter Year";
            // 
            // labGenre
            // 
            this.labGenre.AutoSize = true;
            this.labGenre.Location = new System.Drawing.Point(16, 210);
            this.labGenre.Name = "labGenre";
            this.labGenre.Size = new System.Drawing.Size(64, 13);
            this.labGenre.TabIndex = 15;
            this.labGenre.Text = "Enter Genre";
            // 
            // labVal
            // 
            this.labVal.AutoSize = true;
            this.labVal.Location = new System.Drawing.Point(16, 264);
            this.labVal.Name = "labVal";
            this.labVal.Size = new System.Drawing.Size(78, 13);
            this.labVal.TabIndex = 16;
            this.labVal.Text = "Enter valuetion";
            // 
            // labAvailable
            // 
            this.labAvailable.AutoSize = true;
            this.labAvailable.Location = new System.Drawing.Point(16, 312);
            this.labAvailable.Name = "labAvailable";
            this.labAvailable.Size = new System.Drawing.Size(78, 13);
            this.labAvailable.TabIndex = 17;
            this.labAvailable.Text = "Enter Available";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(120, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(120, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(120, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(123, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(126, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(129, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(129, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            this.openFileDialog1.Title = "OpenFile";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 58);
            this.button3.TabIndex = 26;
            this.button3.Text = "Choose PDF File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // butChooseFile
            // 
            this.butChooseFile.Location = new System.Drawing.Point(19, 343);
            this.butChooseFile.Name = "butChooseFile";
            this.butChooseFile.Size = new System.Drawing.Size(301, 47);
            this.butChooseFile.TabIndex = 27;
            this.butChooseFile.Text = "Choose file";
            this.butChooseFile.UseVisualStyleBackColor = true;
            this.butChooseFile.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 434);
            this.Controls.Add(this.butChooseFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labAvailable);
            this.Controls.Add(this.labVal);
            this.Controls.Add(this.labGenre);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labNamOfBook);
            this.Controls.Add(this.labAut);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.CBAvailable);
            this.Controls.Add(this.CBGenre);
            this.Controls.Add(this.CBVal);
            this.Controls.Add(this.butAddBook);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBNameBook);
            this.Controls.Add(this.TBAutor);
            this.Controls.Add(this.TBId);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.TextBox TBAutor;
        private System.Windows.Forms.TextBox TBNameBook;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.Button butAddBook;
        private System.Windows.Forms.TextBox CBVal;
        private System.Windows.Forms.ComboBox CBGenre;
        private System.Windows.Forms.ComboBox CBAvailable;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labAut;
        private System.Windows.Forms.Label labNamOfBook;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labGenre;
        private System.Windows.Forms.Label labVal;
        private System.Windows.Forms.Label labAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butChooseFile;
    }
}