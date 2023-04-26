namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCitizensList = new System.Windows.Forms.DataGridView();
            this.btnAddCitizen = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbSearchMale = new System.Windows.Forms.RadioButton();
            this.nudSearchBirthYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitizensList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchBirthYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitizensList
            // 
            this.dgvCitizensList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitizensList.Location = new System.Drawing.Point(26, 21);
            this.dgvCitizensList.Name = "dgvCitizensList";
            this.dgvCitizensList.Size = new System.Drawing.Size(550, 150);
            this.dgvCitizensList.TabIndex = 0;
            // 
            // btnAddCitizen
            // 
            this.btnAddCitizen.Location = new System.Drawing.Point(25, 351);
            this.btnAddCitizen.Name = "btnAddCitizen";
            this.btnAddCitizen.Size = new System.Drawing.Size(75, 23);
            this.btnAddCitizen.TabIndex = 1;
            this.btnAddCitizen.Text = "Добавить";
            this.btnAddCitizen.UseVisualStyleBackColor = true;
            this.btnAddCitizen.Click += new System.EventHandler(this.btnAddCitizen_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(134, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(281, 353);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(26, 289);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthdate.TabIndex = 4;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(84, 187);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(100, 20);
            this.tbFullName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(84, 223);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Адресс";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(26, 256);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(34, 17);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "М";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(84, 256);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(36, 17);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Ж";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbSearchMale
            // 
            this.rbSearchMale.AutoSize = true;
            this.rbSearchMale.Location = new System.Drawing.Point(281, 321);
            this.rbSearchMale.Name = "rbSearchMale";
            this.rbSearchMale.Size = new System.Drawing.Size(34, 17);
            this.rbSearchMale.TabIndex = 11;
            this.rbSearchMale.TabStop = true;
            this.rbSearchMale.Text = "М";
            this.rbSearchMale.UseVisualStyleBackColor = true;
            // 
            // nudSearchBirthYear
            // 
            this.nudSearchBirthYear.Location = new System.Drawing.Point(281, 295);
            this.nudSearchBirthYear.Name = "nudSearchBirthYear";
            this.nudSearchBirthYear.Size = new System.Drawing.Size(120, 20);
            this.nudSearchBirthYear.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 390);
            this.Controls.Add(this.nudSearchBirthYear);
            this.Controls.Add(this.rbSearchMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddCitizen);
            this.Controls.Add(this.dgvCitizensList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitizensList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchBirthYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitizensList;
        private System.Windows.Forms.Button btnAddCitizen;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbSearchMale;
        private System.Windows.Forms.NumericUpDown nudSearchBirthYear;
    }
}

