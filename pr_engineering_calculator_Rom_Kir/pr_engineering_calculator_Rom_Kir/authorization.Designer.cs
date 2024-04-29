namespace pr_engineering_calculator_Rom_Kir
{
    partial class authorization
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
            this.back_button_1 = new System.Windows.Forms.Button();
            this.begin_button_2 = new System.Windows.Forms.Button();
            this.heading_label_3 = new System.Windows.Forms.Label();
            this.login_label_2 = new System.Windows.Forms.Label();
            this.password_label_3 = new System.Windows.Forms.Label();
            this.login_text_2 = new System.Windows.Forms.TextBox();
            this.password_text_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_button_1
            // 
            this.back_button_1.Location = new System.Drawing.Point(612, 415);
            this.back_button_1.Name = "back_button_1";
            this.back_button_1.Size = new System.Drawing.Size(75, 23);
            this.back_button_1.TabIndex = 0;
            this.back_button_1.Text = "назад";
            this.back_button_1.UseVisualStyleBackColor = true;
            this.back_button_1.Click += new System.EventHandler(this.back_button_1_Click);
            // 
            // begin_button_2
            // 
            this.begin_button_2.Location = new System.Drawing.Point(713, 415);
            this.begin_button_2.Name = "begin_button_2";
            this.begin_button_2.Size = new System.Drawing.Size(75, 23);
            this.begin_button_2.TabIndex = 1;
            this.begin_button_2.Text = "начать";
            this.begin_button_2.UseVisualStyleBackColor = true;
            this.begin_button_2.Click += new System.EventHandler(this.begin_button_2_Click);
            // 
            // heading_label_3
            // 
            this.heading_label_3.AutoSize = true;
            this.heading_label_3.Location = new System.Drawing.Point(183, 118);
            this.heading_label_3.Name = "heading_label_3";
            this.heading_label_3.Size = new System.Drawing.Size(129, 13);
            this.heading_label_3.TabIndex = 2;
            this.heading_label_3.Text = "Введите пароль и логин";
            // 
            // login_label_2
            // 
            this.login_label_2.AutoSize = true;
            this.login_label_2.Location = new System.Drawing.Point(154, 170);
            this.login_label_2.Name = "login_label_2";
            this.login_label_2.Size = new System.Drawing.Size(41, 13);
            this.login_label_2.TabIndex = 3;
            this.login_label_2.Text = "Логин:";
            // 
            // password_label_3
            // 
            this.password_label_3.AutoSize = true;
            this.password_label_3.Location = new System.Drawing.Point(154, 203);
            this.password_label_3.Name = "password_label_3";
            this.password_label_3.Size = new System.Drawing.Size(45, 13);
            this.password_label_3.TabIndex = 4;
            this.password_label_3.Text = "Пароль";
            // 
            // login_text_2
            // 
            this.login_text_2.Location = new System.Drawing.Point(220, 170);
            this.login_text_2.Name = "login_text_2";
            this.login_text_2.Size = new System.Drawing.Size(100, 20);
            this.login_text_2.TabIndex = 5;
            this.login_text_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_text_2_KeyPress);
            // 
            // password_text_2
            // 
            this.password_text_2.Location = new System.Drawing.Point(220, 203);
            this.password_text_2.Name = "password_text_2";
            this.password_text_2.Size = new System.Drawing.Size(100, 20);
            this.password_text_2.TabIndex = 6;
            this.password_text_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_text_2_KeyPress);
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_text_2);
            this.Controls.Add(this.login_text_2);
            this.Controls.Add(this.password_label_3);
            this.Controls.Add(this.login_label_2);
            this.Controls.Add(this.heading_label_3);
            this.Controls.Add(this.begin_button_2);
            this.Controls.Add(this.back_button_1);
            this.Name = "authorization";
            this.Text = "authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button_1;
        private System.Windows.Forms.Button begin_button_2;
        private System.Windows.Forms.Label heading_label_3;
        private System.Windows.Forms.Label login_label_2;
        private System.Windows.Forms.Label password_label_3;
        private System.Windows.Forms.TextBox login_text_2;
        private System.Windows.Forms.TextBox password_text_2;
    }
}