using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string originalText;
        private string enteredPassword = "";
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Если пользователь нажал Enter, проверьте введенный пароль.
                // enteredPassword содержит введенные пользователем символы.
                MessageBox.Show("Проверка пароля: " + enteredPassword);
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                if (enteredPassword.Length > 0)
                {
                    enteredPassword = enteredPassword.Remove(enteredPassword.Length - 1);
                }
            }
            else
            {
                enteredPassword += e.KeyChar;
            }
            originalText = textBox2.Text;
            string maskedText = new string('*', enteredPassword.Length);
            textBox2.Text = maskedText;
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = enteredPassword;

            // Проверка на специальные символы в textBox1 (логин)
            string loginPattern = @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\]";
            Regex loginRegex = new Regex(loginPattern);

            if (loginRegex.IsMatch(textBox1.Text))
            {
                // Если в логине найдены специальные символы, выдаем ошибку
                MessageBox.Show("Неверный логин или пароль. Проверьте логин или пароль на наличие спец символов!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = |DataDirectory|\db.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Код_Сотрудника, Пароль, Роль FROM Сотрудники WHERE Логин = '" + login + "' AND Пароль = '" + password + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Роль"].ToString();

                if (role == "Администратор")
                {
                    // Если роль "Администратор" и логин/пароль верны
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                   
                }
                else
                {
                    // Для остальных ролей (Пользователь)

                    Form3 form5 = new Form3();
                    form5.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if (string.IsNullOrEmpty(login))
            {
                label3.Visible = true;
                MessageBox.Show("Системная ошибка: Введите Логин");
                textBox1.Text = "";
                textBox2.Text = "";
                return; // Прерываем выполнение кода
            }

            if (password == "")
            {
                label4.Visible = true;
                MessageBox.Show("Системная ошибка: Введите пароль");
                textBox1.Text = "";
                textBox2.Text = "";
                return; // Прерываем выполнение кода
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = enteredPassword;
        }
    }
}
