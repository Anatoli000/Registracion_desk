using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Касса_БЕЛ_ЖД
{
    public partial class FormEntrance : System.Windows.Forms.Form
    {
        /* Переменные, которые будут хранить на протяжение работы программы логин и пароль. */
        public string login = string.Empty;
        public string password = string.Empty;
        private Users user = new Users(); // Экземпляр класса пользователей.
        public FormEntrance()
        {
            InitializeComponent();
            LoadUsers(); // Метод десериализует класс.
        }
        private void LoadUsers()
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                user = (Users)formatter.Deserialize(fs);

                fs.Close();
            }
            catch { return; }
        }

        private void EnterToForm()
        {
            for (int i = 0; i < user.Logins.Count; i++) // Ищем пользователя и проверяем правильность пароля.
            {
                if (user.Logins[i] == loginTextBox.Text && user.Passwords[i] == passwordTextBox.Text)
                {
                    login = user.Logins[i];
                    password = user.Passwords[i];
                    DialogResult result = MessageBox.Show(
                    "Вы вошли в систему!",
                    "Сообщение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.OK)
                    {
                        FormTickets formTickets = new FormTickets();
                        formTickets.Show();
                        Visible = false;
                    }
                    
                }
                else if (user.Logins[i] == loginTextBox.Text && passwordTextBox.Text != user.Passwords[i])
                {
                    login = user.Logins[i];

                    MessageBox.Show("Неверный пароль!");
                }
            }

            if (login == "") { MessageBox.Show("Пользователь " + loginTextBox.Text + " не найден!"); }
        }

        private void AddUser() // Регистрируем нового пользователя.
        {
            if (loginTextBox.Text == "" || passwordTextBox.Text == "") { MessageBox.Show("Не введен логин или пароль!"); return; }

            user.Logins.Add(loginTextBox.Text);
            user.Passwords.Add(passwordTextBox.Text);

            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, user); // Сериализуем класс.

            fs.Close();

            login = loginTextBox.Text;
            DialogResult dr = MessageBox.Show("Новый пользователь зарегистрирован успешно",
               "Регистпация",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button3);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterToForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем программу.
        }

        private void FormEntrance_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == "" | password == "") { Application.Exit(); }
        }
    }
}
