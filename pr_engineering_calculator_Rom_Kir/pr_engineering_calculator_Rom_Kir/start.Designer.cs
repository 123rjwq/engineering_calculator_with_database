namespace pr_engineering_calculator_Rom_Kir
{
    partial class start
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
            this.registration_button = new System.Windows.Forms.Button();
            this.authorization_button = new System.Windows.Forms.Button();
            this.necessary_to_register = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registration_button
            // 
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registration_button.Location = new System.Drawing.Point(173, 238);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(75, 23);
            this.registration_button.TabIndex = 0;
            this.registration_button.Text = "регистрация";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // authorization_button
            // 
            this.authorization_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authorization_button.Location = new System.Drawing.Point(452, 238);
            this.authorization_button.Name = "authorization_button";
            this.authorization_button.Size = new System.Drawing.Size(75, 23);
            this.authorization_button.TabIndex = 1;
            this.authorization_button.Text = "войти";
            this.authorization_button.UseVisualStyleBackColor = true;
            this.authorization_button.Click += new System.EventHandler(this.authorization_button_Click);
            // 
            // necessary_to_register
            // 
            this.necessary_to_register.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.necessary_to_register.Location = new System.Drawing.Point(132, 123);
            this.necessary_to_register.Name = "necessary_to_register";
            this.necessary_to_register.Size = new System.Drawing.Size(476, 20);
            this.necessary_to_register.TabIndex = 2;
            this.necessary_to_register.Text = "Необходимо зарегистрироваться или войти в учетную запись, для работы с приложение" +
    "м";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.necessary_to_register);
            this.Controls.Add(this.authorization_button);
            this.Controls.Add(this.registration_button);
            this.Name = "start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button authorization_button;
        private System.Windows.Forms.TextBox necessary_to_register;
    }
}

