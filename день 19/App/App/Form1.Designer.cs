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
            this.btnIPhone = new System.Windows.Forms.Button();
            this.btnSamsungGalaxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIPhone
            // 
            this.btnIPhone.Location = new System.Drawing.Point(43, 64);
            this.btnIPhone.Name = "btnIPhone";
            this.btnIPhone.Size = new System.Drawing.Size(75, 23);
            this.btnIPhone.TabIndex = 0;
            this.btnIPhone.Text = "IPhone";
            this.btnIPhone.UseVisualStyleBackColor = true;
            this.btnIPhone.Click += new System.EventHandler(this.btnIPhone_Click);
            // 
            // btnSamsungGalaxy
            // 
            this.btnSamsungGalaxy.Location = new System.Drawing.Point(167, 64);
            this.btnSamsungGalaxy.Name = "btnSamsungGalaxy";
            this.btnSamsungGalaxy.Size = new System.Drawing.Size(111, 23);
            this.btnSamsungGalaxy.TabIndex = 1;
            this.btnSamsungGalaxy.Text = "SamsungGalaxy";
            this.btnSamsungGalaxy.UseVisualStyleBackColor = true;
            this.btnSamsungGalaxy.Click += new System.EventHandler(this.btnSamsungGalaxy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 149);
            this.Controls.Add(this.btnSamsungGalaxy);
            this.Controls.Add(this.btnIPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIPhone;
        private System.Windows.Forms.Button btnSamsungGalaxy;
    }
}

