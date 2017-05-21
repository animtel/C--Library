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
            this.textChoose = new System.Windows.Forms.ComboBox();
            this.texValue = new System.Windows.Forms.TextBox();
            this.butSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textChoose
            // 
            this.textChoose.FormattingEnabled = true;
            this.textChoose.Items.AddRange(new object[] {
            "Delete by id",
            "Delete by autor",
            "Delete by name of book",
            "Delete by year",
            "Delete by genre",
            "Delete by valuetion"});
            this.textChoose.Location = new System.Drawing.Point(13, 13);
            this.textChoose.Name = "textChoose";
            this.textChoose.Size = new System.Drawing.Size(284, 21);
            this.textChoose.TabIndex = 0;
            this.textChoose.Text = "Choose how do you want delete";
            this.textChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // texValue
            // 
            this.texValue.Location = new System.Drawing.Point(13, 41);
            this.texValue.Name = "texValue";
            this.texValue.Size = new System.Drawing.Size(284, 20);
            this.texValue.TabIndex = 1;
            this.texValue.Text = "Enter your value";
            // 
            // butSwitch
            // 
            this.butSwitch.Location = new System.Drawing.Point(222, 67);
            this.butSwitch.Name = "butSwitch";
            this.butSwitch.Size = new System.Drawing.Size(75, 23);
            this.butSwitch.TabIndex = 2;
            this.butSwitch.Text = "Enter";
            this.butSwitch.UseVisualStyleBackColor = true;
            this.butSwitch.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.butSwitch);
            this.Controls.Add(this.texValue);
            this.Controls.Add(this.textChoose);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textChoose;
        private System.Windows.Forms.TextBox texValue;
        private System.Windows.Forms.Button butSwitch;
        private System.Windows.Forms.Label label1;
    }
}