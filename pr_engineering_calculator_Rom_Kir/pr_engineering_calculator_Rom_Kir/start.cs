using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_engineering_calculator_Rom_Kir
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            // Создание экземпляра второй формы
            regFor regForm = new regFor();

            // Показ второй формы
            regForm.Show();

            // Скрытие текущей формы
            this.Hide();
        }

        private void authorization_button_Click(object sender, EventArgs e)
        {
            // Создание экземпляра второй формы
            authorization authForm = new authorization();

            // Показ второй формы
            authForm.Show();

            // Скрытие текущей формы
            this.Hide();
        }
    }
}
