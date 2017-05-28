namespace LiteLibrary
{
    partial class MainView
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
            this.butShowAll = new System.Windows.Forms.Button();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.CBGenre = new System.Windows.Forms.ComboBox();
            this.CBAvailable = new System.Windows.Forms.ComboBox();
            this.PBTree = new System.Windows.Forms.PictureBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.butOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // butShowAll
            // 
            this.butShowAll.Location = new System.Drawing.Point(296, 118);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(87, 23);
            this.butShowAll.TabIndex = 7;
            this.butShowAll.Text = "Show all books";
            this.butShowAll.UseVisualStyleBackColor = true;
            this.butShowAll.Click += new System.EventHandler(this.buttonShowAllBooks);
            // 
            // CBSearch
            // 
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Items.AddRange(new object[] {
            "Search as id",
            "Search as Autor",
            "Search as Name",
            "Search as Year",
            "Search as Genre",
            "Search as Valuetion"});
            this.CBSearch.Location = new System.Drawing.Point(388, 9);
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(162, 21);
            this.CBSearch.TabIndex = 9;
            this.CBSearch.Text = "What are you want to search";
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(388, 36);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(162, 20);
            this.TBSearch.TabIndex = 11;
            this.TBSearch.Text = "Search";
            this.TBSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.TBSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(388, 118);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(162, 23);
            this.butSearch.TabIndex = 12;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(555, 118);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(87, 23);
            this.butAdd.TabIndex = 15;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.button4_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(555, 91);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(87, 23);
            this.butDel.TabIndex = 16;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.button5_Click);
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
            this.CBGenre.Location = new System.Drawing.Point(388, 64);
            this.CBGenre.Name = "CBGenre";
            this.CBGenre.Size = new System.Drawing.Size(162, 21);
            this.CBGenre.TabIndex = 17;
            this.CBGenre.Text = "Genre";
            // 
            // CBAvailable
            // 
            this.CBAvailable.FormattingEnabled = true;
            this.CBAvailable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CBAvailable.Location = new System.Drawing.Point(388, 91);
            this.CBAvailable.Name = "CBAvailable";
            this.CBAvailable.Size = new System.Drawing.Size(162, 21);
            this.CBAvailable.TabIndex = 18;
            this.CBAvailable.Text = "Available";
            // 
            // PBTree
            // 
            this.PBTree.Location = new System.Drawing.Point(326, 214);
            this.PBTree.Name = "PBTree";
            this.PBTree.Size = new System.Drawing.Size(432, 397);
            this.PBTree.TabIndex = 20;
            this.PBTree.TabStop = false;
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(85, 147);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(762, 150);
            this.Table.TabIndex = 21;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            this.Table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(556, 64);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(86, 23);
            this.butOpen.TabIndex = 22;
            this.butOpen.Text = "Open";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(943, 542);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.PBTree);
            this.Controls.Add(this.CBAvailable);
            this.Controls.Add(this.CBGenre);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.CBSearch);
            this.Controls.Add(this.butShowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.ComboBox CBGenre;
        private System.Windows.Forms.ComboBox CBAvailable;
        private System.Windows.Forms.PictureBox PBTree;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button butOpen;
    }
}

