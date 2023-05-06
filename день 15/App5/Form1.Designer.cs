namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnCopyFiles = new System.Windows.Forms.Button();
            this.btnCreateArchive = new System.Windows.Forms.Button();
            this.btnExtractArchive = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSourceDir = new System.Windows.Forms.Label();
            this.txtFileExtension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(152, 262);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(173, 46);
            this.btnGetFiles.TabIndex = 0;
            this.btnGetFiles.Text = "Получить файлы";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click_1);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(331, 262);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(162, 46);
            this.btnCreateDirectory.TabIndex = 1;
            this.btnCreateDirectory.Text = "Создать директорию";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click_1);
            // 
            // btnCopyFiles
            // 
            this.btnCopyFiles.Location = new System.Drawing.Point(499, 261);
            this.btnCopyFiles.Name = "btnCopyFiles";
            this.btnCopyFiles.Size = new System.Drawing.Size(163, 48);
            this.btnCopyFiles.TabIndex = 2;
            this.btnCopyFiles.Text = "Копировать файлы";
            this.btnCopyFiles.UseVisualStyleBackColor = true;
            this.btnCopyFiles.Click += new System.EventHandler(this.btnCopyFiles_Click_1);
            // 
            // btnCreateArchive
            // 
            this.btnCreateArchive.Location = new System.Drawing.Point(272, 324);
            this.btnCreateArchive.Name = "btnCreateArchive";
            this.btnCreateArchive.Size = new System.Drawing.Size(140, 47);
            this.btnCreateArchive.TabIndex = 3;
            this.btnCreateArchive.Text = "Создание архива";
            this.btnCreateArchive.UseVisualStyleBackColor = true;
            this.btnCreateArchive.Click += new System.EventHandler(this.btnCreateArchive_Click_1);
            // 
            // btnExtractArchive
            // 
            this.btnExtractArchive.Location = new System.Drawing.Point(418, 325);
            this.btnExtractArchive.Name = "btnExtractArchive";
            this.btnExtractArchive.Size = new System.Drawing.Size(129, 46);
            this.btnExtractArchive.TabIndex = 4;
            this.btnExtractArchive.Text = "Извлечь архив";
            this.btnExtractArchive.UseVisualStyleBackColor = true;
            this.btnExtractArchive.Click += new System.EventHandler(this.btnExtractArchive_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 221);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.AutoSize = true;
            this.txtSourceDir.Location = new System.Drawing.Point(275, 275);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(0, 20);
            this.txtSourceDir.TabIndex = 6;
            // 
            // txtFileExtension
            // 
            this.txtFileExtension.AutoSize = true;
            this.txtFileExtension.Location = new System.Drawing.Point(473, 275);
            this.txtFileExtension.Name = "txtFileExtension";
            this.txtFileExtension.Size = new System.Drawing.Size(0, 20);
            this.txtFileExtension.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFileExtension);
            this.Controls.Add(this.txtSourceDir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExtractArchive);
            this.Controls.Add(this.btnCreateArchive);
            this.Controls.Add(this.btnCopyFiles);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnGetFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetFiles;
        private Button btnCreateDirectory;
        private Button btnCopyFiles;
        private Button btnCreateArchive;
        private Button btnExtractArchive;
        private TextBox textBox1;
        private Label txtSourceDir;
        private Label txtFileExtension;
    }
}