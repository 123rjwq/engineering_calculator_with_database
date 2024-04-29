using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr_engineering_calculator_Rom_Kir
{
    public partial class regFor : Form
    {
        public regFor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            begin_button.Enabled = false; // Сначала делаем кнопку неактивной
            //login_text.KeyPress += login_text_KeyPress;
            //password_text.KeyPress += password_text_KeyPress;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // Создание экземпляра второй формы
            start startForm = new start();

            // Показ второй формы
            startForm.Show();

            // Скрытие текущей формы
            this.Hide();
        }

        private void begin_button_Click(object sender, EventArgs e)
        {
            // Создание экземпляра второй формы
            calculator calсForm = new calculator();

            // Показ второй формы
            calсForm.Show();

            // Скрытие текущей формы
            this.Hide();
        }

        private void login_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Контрол будет принимать не более 14 символов.
            login_text.MaxLength = 15;
            ValidateInput(e);

        }

        private void password_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
            // Символ пароля - звездочка.
            password_text.PasswordChar = '*';
            // Контрол будет принимать не более 14 символов.
            password_text.MaxLength = 14;
        }

        private void ValidateInput(KeyPressEventArgs e)
        {
            // Регулярное выражение, разрешающее ввод только букв, цифр и указанных специальных символов
            var regex = new Regex(@"^[a-zA-Z0-9!""№;%:?*()_+-]+$");
            if (!regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
                MessageBox.Show("Введены недопустимые символы. Пожалуйста, используйте только буквы английского алфавита, цифры или указанные специальные символы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private const string FileName = "login_password.txt";

        private void save_button_Click(object sender, EventArgs e)
        {

            string login = login_text.Text;
            string password = password_text.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            if (File.Exists(FileName))
            {
                string[] lines = File.ReadAllLines(FileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 2 && parts[0] == login && parts[1] == password)
                    {
                        MessageBox.Show("Логин и пароль уже сохранены.");
                        return;
                    }
                }
            }

            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.WriteLine($"{login} {password}");
            }

            MessageBox.Show("Логин и пароль сохранены.");

            //        }

            //        if (userExists)
            //        {
            //            MessageBox.Show("Логин и пароль уже существуют.");
            //            return; // Прекращение выполнения метода, если пользователь уже существует
            //        }
            //    }

            //    // Добавление нового пользователя в существующий файл
            //    using (StreamWriter writer = new StreamWriter(filePath, true)) // true для добавления данных в конец файла
            //    {
            //        writer.WriteLine("---Новый_Пользователь---");
            //        writer.WriteLine("!Логин: " + login_text.Text);
            //        writer.WriteLine("#Пароль: " + password_text.Text);
            //        writer.WriteLine("------");
            //    }

            //    MessageBox.Show("Данные сохранены в файл " + filePath, "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Активация кнопки после успешного сохранения
            begin_button.Enabled = true;
        }

    }
}
