namespace CourseProjectOOP
{
    partial class Delete
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
            this.ChooseDel = new System.Windows.Forms.ComboBox();
            this.texValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseDel
            // 
            this.ChooseDel.FormattingEnabled = true;
            this.ChooseDel.Items.AddRange(new object[] {
            "Delete by id",
            "Delete by autor",
            "Delete by name of book",
            "Delete by year",
            "Delete by genre",
            "Delete by valuetion"});
            this.ChooseDel.Location = new System.Drawing.Point(13, 13);
            this.ChooseDel.Name = "ChooseDel";
            this.ChooseDel.Size = new System.Drawing.Size(284, 21);
            this.ChooseDel.TabIndex = 0;
            this.ChooseDel.Text = "Choose how do you want delete";
            this.ChooseDel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // texValue
            // 
            this.texValue.Location = new System.Drawing.Point(13, 41);
            this.texValue.Name = "texValue";
            this.texValue.Size = new System.Drawing.Size(284, 20);
            this.texValue.TabIndex = 1;
            this.texValue.Text = "Enter your value";
            this.texValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texValue);
            this.Controls.Add(this.ChooseDel);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseDel;
        private System.Windows.Forms.TextBox texValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}