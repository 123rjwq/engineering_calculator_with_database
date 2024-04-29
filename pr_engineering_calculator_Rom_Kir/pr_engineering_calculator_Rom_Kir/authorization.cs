using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr_engineering_calculator_Rom_Kir
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Инициализация кнопки как неактивной
            begin_button_2.Enabled = false;

            // Подписка на события TextChanged для текстовых полей
            login_text_2.TextChanged += TextBox_TextChanged;
            password_text_2.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка, что оба текстовых поля не пусты
            if (!string.IsNullOrWhiteSpace(login_text_2.Text) && !string.IsNullOrWhiteSpace(password_text_2.Text))
            {
                // Если оба поля не пусты, активируем кнопку
                begin_button_2.Enabled = true;
            }
            else
            {
                // Если хотя бы одно поле пусто, деактивируем кнопку
                begin_button_2.Enabled = false;
            }
        }


        private void back_button_1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра второй формы
            start startForm = new start();

            // Показ второй формы
            startForm.Show();

            // Скрытие текущей формы
            this.Hide();
        }

        private const string FileName = "login_password.txt";
        private void begin_button_2_Click(object sender, EventArgs e)
        {

            string login = login_text_2.Text;
            string password = password_text_2.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            // Проверяем, существует ли файл с учетными данными
            if (File.Exists(FileName))
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(FileName);
                bool isFound = false; // Флаг для отслеживания нахождения совпадения

                foreach (string line in lines)
                {
                    // Разделяем строку на части по пробелу
                    string[] parts = line.Split(' ');
                    // Проверяем, совпадают ли введенный логин и пароль с сохраненными
                    if (parts.Length == 2 && parts[0] == login && parts[1] == password)
                    {
                        // Если совпадают, выводим сообщение об успешной авторизации
                        MessageBox.Show("Вы авторизовались.");
                        // Создаем экземпляр второй формы (например, калькулятора)
                        calculator calсForm = new calculator();

                        // Показываем вторую форму
                        calсForm.Show();

                        // Скрываем текущую форму
                        this.Hide();
                        isFound = true; // Устанавливаем флаг в true, так как совпадение найдено
                        break; // Прерываем цикл, так как нашли совпадение
                    }
                }

                // Если после проверки всех строк совпадение не найдено, выводим сообщение о необходимости регистрации
                if (!isFound)
                {
                    MessageBox.Show("Надо зарегистрироваться.");
                }
            }
            //else
            //{
            //    MessageBox.Show("Надо зарегистрироваться.");
            //    return;
            //}

            //// Создание пути к файлу
            //string filePath = "login_password.txt";

            //// Проверка на существование логина и пароля в файле
            //if (File.Exists(filePath))
            //{
            //    string[] lines = File.ReadAllLines(filePath); // Чтение всех строк файла в массив
            //    bool userExists = false; // Переменная для отслеживания наличия пользователя

            //    for (int i = 0; i < lines.Length; i++) // Используем цикл for, чтобы иметь доступ к следующей строке
            //    {
            //        // Проверка, что текущая строка содержит тире "------"
            //        if (lines[i].Trim() == "------")
            //        {
            //            // Проверка следующих двух строк на соответствие введенному логину и паролю
            //            if (i + 2 < lines.Length && lines[i + 1].Trim().StartsWith("!Логин: ") && lines[i + 1].Trim().Substring(9) == login_text_2.Text &&
            //                lines[i + 2].Trim().StartsWith("#Пароль: ") && lines[i + 2].Trim().Substring(10) == password_text_2.Text)
            //            {
            //                userExists = true; // Пользователь найден
            //                break; // Выход из цикла
            //            }
            //        }
            //    }

            //    if (!userExists)
            //    {
            //        MessageBox.Show("Пользователь не найден. Пожалуйста, зарегистрируйтесь.");
            //        return; // Прекращение выполнения метода
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Файл с данными не найден. Пожалуйста, зарегистрируйтесь.");
            //    return; // Прекращение выполнения метода
            //}


        }

        private void login_text_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Контрол будет принимать не более 14 символов.
            login_text_2.MaxLength = 15;
            ValidateInput(e);
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

        private void password_text_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInput(e);
            // Символ пароля - звездочка.
            password_text_2.PasswordChar = '*';
            // Контрол будет принимать не более 14 символов.
            password_text_2.MaxLength = 14;
        }
    }
}
