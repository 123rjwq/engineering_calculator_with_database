namespace pr_engineering_calculator_Rom_Kir
{
    partial class regFor
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
            this.back_button = new System.Windows.Forms.Button();
            this.begin_button = new System.Windows.Forms.Button();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.heading_label_2 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(622, 386);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // begin_button
            // 
            this.begin_button.Location = new System.Drawing.Point(720, 386);
            this.begin_button.Name = "begin_button";
            this.begin_button.Size = new System.Drawing.Size(75, 23);
            this.begin_button.TabIndex = 1;
            this.begin_button.Text = "начать";
            this.begin_button.UseVisualStyleBackColor = true;
            this.begin_button.Click += new System.EventHandler(this.begin_button_Click);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(239, 168);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(206, 20);
            this.password_text.TabIndex = 2;
            this.password_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_text_KeyPress);


            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(239, 118);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(100, 20);
            this.login_text.TabIndex = 3;
            this.login_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_text_KeyPress);

            // 
            // heading_label_2
            // 
            this.heading_label_2.AutoSize = true;
            this.heading_label_2.Location = new System.Drawing.Point(152, 86);
            this.heading_label_2.Name = "heading_label_2";
            this.heading_label_2.Size = new System.Drawing.Size(135, 13);
            this.heading_label_2.TabIndex = 4;
            this.heading_label_2.Text = "Создайте логин и пароль";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(152, 118);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(81, 13);
            this.login_label.TabIndex = 5;
            this.login_label.Text = "Введите логин";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(145, 171);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(88, 13);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Введите пароль";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(264, 259);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // regFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.heading_label_2);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.begin_button);
            this.Controls.Add(this.back_button);
            this.Name = "regFor";
            this.Text = "registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button begin_button;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.Label heading_label_2;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button save_button;
    }
}