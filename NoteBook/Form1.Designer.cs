namespace NoteBook
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
            this.TextField = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextField
            // 
            this.TextField.Location = new System.Drawing.Point(96, 8);
            this.TextField.Multiline = true;
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(628, 354);
            this.TextField.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(472, 385);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 24);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(12, 50);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(67, 30);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // Filename
            // 
            this.Filename.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic);
            this.Filename.Location = new System.Drawing.Point(265, 385);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(125, 28);
            this.Filename.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name :";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnnew.Location = new System.Drawing.Point(12, 12);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(67, 30);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            ".txt",
            ".jpg",
            ".jpeg",
            ".png"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "txt",
            "jpg",
            "jpeg",
            "png"});
            this.comboBox1.Location = new System.Drawing.Point(396, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 29);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(746, 416);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.TextField);
            this.Name = "Form1";
            this.Text = "NoteBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextField;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

