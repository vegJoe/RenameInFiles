namespace RenameInFiles
{
    partial class Form1
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
            this.sourceDirectoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationDirectoryBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.oldWordTextbox = new System.Windows.Forms.TextBox();
            this.newWordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addWordsBtn = new System.Windows.Forms.Button();
            this.keepOldFilesCheckbox = new System.Windows.Forms.CheckBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.chkSearchFiles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sourceDirectoryBtn
            // 
            this.sourceDirectoryBtn.Location = new System.Drawing.Point(199, 90);
            this.sourceDirectoryBtn.Name = "sourceDirectoryBtn";
            this.sourceDirectoryBtn.Size = new System.Drawing.Size(75, 23);
            this.sourceDirectoryBtn.TabIndex = 0;
            this.sourceDirectoryBtn.Text = "Browse";
            this.sourceDirectoryBtn.UseVisualStyleBackColor = true;
            this.sourceDirectoryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Directory";
            // 
            // destinationDirectoryBtn
            // 
            this.destinationDirectoryBtn.Location = new System.Drawing.Point(199, 144);
            this.destinationDirectoryBtn.Name = "destinationDirectoryBtn";
            this.destinationDirectoryBtn.Size = new System.Drawing.Size(75, 23);
            this.destinationDirectoryBtn.TabIndex = 3;
            this.destinationDirectoryBtn.Text = "Browse";
            this.destinationDirectoryBtn.UseVisualStyleBackColor = true;
            this.destinationDirectoryBtn.Click += new System.EventHandler(this.destinationDirectoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // oldWordTextbox
            // 
            this.oldWordTextbox.Location = new System.Drawing.Point(199, 220);
            this.oldWordTextbox.Name = "oldWordTextbox";
            this.oldWordTextbox.Size = new System.Drawing.Size(151, 22);
            this.oldWordTextbox.TabIndex = 4;
            this.oldWordTextbox.TextChanged += new System.EventHandler(this.oldWord_TextChanged);
            // 
            // newWordTextbox
            // 
            this.newWordTextbox.Location = new System.Drawing.Point(199, 272);
            this.newWordTextbox.Name = "newWordTextbox";
            this.newWordTextbox.Size = new System.Drawing.Size(151, 22);
            this.newWordTextbox.TabIndex = 5;
            this.newWordTextbox.TextChanged += new System.EventHandler(this.newWordTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Old word / Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "New word";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(27, 348);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 186);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Old word / Search";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "New word";
            this.columnHeader2.Width = 140;
            // 
            // addWordsBtn
            // 
            this.addWordsBtn.Location = new System.Drawing.Point(399, 272);
            this.addWordsBtn.Name = "addWordsBtn";
            this.addWordsBtn.Size = new System.Drawing.Size(96, 23);
            this.addWordsBtn.TabIndex = 9;
            this.addWordsBtn.Text = "Add words";
            this.addWordsBtn.UseVisualStyleBackColor = true;
            this.addWordsBtn.Click += new System.EventHandler(this.addWordsButton_Click);
            // 
            // keepOldFilesCheckbox
            // 
            this.keepOldFilesCheckbox.AutoSize = true;
            this.keepOldFilesCheckbox.Location = new System.Drawing.Point(399, 95);
            this.keepOldFilesCheckbox.Name = "keepOldFilesCheckbox";
            this.keepOldFilesCheckbox.Size = new System.Drawing.Size(115, 21);
            this.keepOldFilesCheckbox.TabIndex = 10;
            this.keepOldFilesCheckbox.Text = "Keep old files";
            this.keepOldFilesCheckbox.UseVisualStyleBackColor = true;
            this.keepOldFilesCheckbox.CheckedChanged += new System.EventHandler(this.keepOldFilesCheckbox_CheckedChanged);
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(399, 510);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(75, 23);
            this.executeBtn.TabIndex = 11;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // chkSearchFiles
            // 
            this.chkSearchFiles.AutoSize = true;
            this.chkSearchFiles.Location = new System.Drawing.Point(399, 149);
            this.chkSearchFiles.Name = "chkSearchFiles";
            this.chkSearchFiles.Size = new System.Drawing.Size(104, 21);
            this.chkSearchFiles.TabIndex = 12;
            this.chkSearchFiles.Text = "Search files";
            this.chkSearchFiles.UseVisualStyleBackColor = true;
            this.chkSearchFiles.CheckedChanged += new System.EventHandler(this.checkBoxSearchFiles);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 576);
            this.Controls.Add(this.chkSearchFiles);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.keepOldFilesCheckbox);
            this.Controls.Add(this.addWordsBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newWordTextbox);
            this.Controls.Add(this.oldWordTextbox);
            this.Controls.Add(this.destinationDirectoryBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceDirectoryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceDirectoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button destinationDirectoryBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox oldWordTextbox;
        private System.Windows.Forms.TextBox newWordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addWordsBtn;
        private System.Windows.Forms.CheckBox keepOldFilesCheckbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.CheckBox chkSearchFiles;
    }
}

