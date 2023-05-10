namespace App
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
            this.addButton = new System.Windows.Forms.Button();
            this.arraySizeLabel = new System.Windows.Forms.Label();
            this.arrayContentsLabel = new System.Windows.Forms.Label();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.containsButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.characterTextBox = new System.Windows.Forms.TextBox();
            this.removeNegativeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(19, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // arraySizeLabel
            // 
            this.arraySizeLabel.AutoSize = true;
            this.arraySizeLabel.Location = new System.Drawing.Point(12, 19);
            this.arraySizeLabel.Name = "arraySizeLabel";
            this.arraySizeLabel.Size = new System.Drawing.Size(62, 13);
            this.arraySizeLabel.TabIndex = 1;
            this.arraySizeLabel.Text = "Элементы:";
            // 
            // arrayContentsLabel
            // 
            this.arrayContentsLabel.AutoSize = true;
            this.arrayContentsLabel.Location = new System.Drawing.Point(12, 57);
            this.arrayContentsLabel.Name = "arrayContentsLabel";
            this.arrayContentsLabel.Size = new System.Drawing.Size(49, 13);
            this.arrayContentsLabel.TabIndex = 2;
            this.arrayContentsLabel.Text = "Массив:";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(19, 134);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(100, 20);
            this.elementTextBox.TabIndex = 3;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(111, 233);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "Умножить";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // containsButton
            // 
            this.containsButton.Location = new System.Drawing.Point(204, 233);
            this.containsButton.Name = "containsButton";
            this.containsButton.Size = new System.Drawing.Size(75, 23);
            this.containsButton.TabIndex = 5;
            this.containsButton.Text = "Проверить";
            this.containsButton.UseVisualStyleBackColor = true;
            this.containsButton.Click += new System.EventHandler(this.containsButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 102);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(62, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Результат:";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(19, 160);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.multiplierTextBox.TabIndex = 7;
            // 
            // characterTextBox
            // 
            this.characterTextBox.Location = new System.Drawing.Point(19, 186);
            this.characterTextBox.Name = "characterTextBox";
            this.characterTextBox.Size = new System.Drawing.Size(100, 20);
            this.characterTextBox.TabIndex = 8;
            // 
            // removeNegativeButton
            // 
            this.removeNegativeButton.Location = new System.Drawing.Point(301, 233);
            this.removeNegativeButton.Name = "removeNegativeButton";
            this.removeNegativeButton.Size = new System.Drawing.Size(123, 23);
            this.removeNegativeButton.TabIndex = 9;
            this.removeNegativeButton.Text = "Удалить отриц";
            this.removeNegativeButton.UseVisualStyleBackColor = true;
            this.removeNegativeButton.Click += new System.EventHandler(this.removeNegativeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 265);
            this.Controls.Add(this.removeNegativeButton);
            this.Controls.Add(this.characterTextBox);
            this.Controls.Add(this.multiplierTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.containsButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.arrayContentsLabel);
            this.Controls.Add(this.arraySizeLabel);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label arraySizeLabel;
        private System.Windows.Forms.Label arrayContentsLabel;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button containsButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.TextBox characterTextBox;
        private System.Windows.Forms.Button removeNegativeButton;
    }
}

