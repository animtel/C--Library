namespace LiteLibrary
{
    partial class ChangeBook
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
            this.CBAvailable = new System.Windows.Forms.ComboBox();
            this.CBGenre = new System.Windows.Forms.ComboBox();
            this.TBVal = new System.Windows.Forms.TextBox();
            this.butChange = new System.Windows.Forms.Button();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.TBNameOfBook = new System.Windows.Forms.TextBox();
            this.TBAut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBAvailable
            // 
            this.CBAvailable.FormattingEnabled = true;
            this.CBAvailable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CBAvailable.Location = new System.Drawing.Point(65, 261);
            this.CBAvailable.Name = "CBAvailable";
            this.CBAvailable.Size = new System.Drawing.Size(163, 21);
            this.CBAvailable.TabIndex = 18;
            this.CBAvailable.Text = "Available";
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
            this.CBGenre.Location = new System.Drawing.Point(65, 159);
            this.CBGenre.Name = "CBGenre";
            this.CBGenre.Size = new System.Drawing.Size(163, 21);
            this.CBGenre.TabIndex = 17;
            this.CBGenre.Text = "Genre";
            // 
            // TBVal
            // 
            this.TBVal.Location = new System.Drawing.Point(65, 214);
            this.TBVal.Name = "TBVal";
            this.TBVal.Size = new System.Drawing.Size(163, 20);
            this.TBVal.TabIndex = 16;
            this.TBVal.Text = "Valuetion";
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(153, 299);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 15;
            this.butChange.Text = "Change Book";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(65, 109);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(163, 20);
            this.TBYear.TabIndex = 14;
            this.TBYear.Text = "Year";
            // 
            // TBNameOfBook
            // 
            this.TBNameOfBook.Location = new System.Drawing.Point(65, 59);
            this.TBNameOfBook.Name = "TBNameOfBook";
            this.TBNameOfBook.Size = new System.Drawing.Size(163, 20);
            this.TBNameOfBook.TabIndex = 13;
            this.TBNameOfBook.Text = "Name Of book";
            // 
            // TBAut
            // 
            this.TBAut.Location = new System.Drawing.Point(65, 12);
            this.TBAut.Name = "TBAut";
            this.TBAut.Size = new System.Drawing.Size(163, 20);
            this.TBAut.TabIndex = 12;
            this.TBAut.Text = "Autor";
            // 
            // ChangeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 344);
            this.Controls.Add(this.CBAvailable);
            this.Controls.Add(this.CBGenre);
            this.Controls.Add(this.TBVal);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBNameOfBook);
            this.Controls.Add(this.TBAut);
            this.Name = "ChangeBook";
            this.Text = "ChangeBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBAvailable;
        private System.Windows.Forms.ComboBox CBGenre;
        private System.Windows.Forms.TextBox TBVal;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.TextBox TBNameOfBook;
        private System.Windows.Forms.TextBox TBAut;
    }
}