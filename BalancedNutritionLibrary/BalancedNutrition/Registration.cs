using BalancedNutritionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedNutrition
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                if (db.Users.Where(u => u.Login == LoginTextBox.Text).ToList().Count() > 0)
                {
                    if (PasswordTextBox1.Text == PasswordTextBox2.Text && LoginTextBox.Text != ""
                        && RoleComboBox.Text != "" && PasswordTextBox1.Text != "" && PasswordTextBox2.Text != ""
                        && LoginTextBox.Text != db.Users.Where(u => u.Login == LoginTextBox.Text).ToList()[0].Login)
                    {
                        MD5 mD5 = MD5.Create();
                        var hash = mD5.ComputeHash(Encoding.UTF8.GetBytes(PasswordTextBox1.Text));

                        string login = LoginTextBox.Text;
                        string password = Convert.ToBase64String(hash);
                        Role role = new Role();
                        foreach (Role r in db.Roles)
                        {
                            if (r.Name == RoleComboBox.Text)
                            {
                                role = r;
                                break;
                            }
                        }
                        User user = new User { Login = login, Password = password, Role = role };
                        db.Add(user);
                        db.SaveChanges();
                        WarningLabel.ForeColor = Color.Green;
                        WarningLabel.Text = "Регистрация прошла успешно";
                    }
                    else
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "";
                        if (PasswordTextBox1.Text == "" || PasswordTextBox2.Text == "")
                            WarningLabel.Text += "В поле пароля ничего не указано.";
                        if (PasswordTextBox1.Text != PasswordTextBox2.Text)
                            WarningLabel.Text += "\nПароли не совпадают.";
                        if (LoginTextBox.Text == "")
                            WarningLabel.Text += "\nВ поле логин ничего не указано.";
                        if (RoleComboBox.Text == "")
                            WarningLabel.Text += "\nНе выбрана роль пользователя.";
                        if (LoginTextBox.Text == db.Users.Where(u => u.Login == LoginTextBox.Text).ToList()[0].Login)
                            WarningLabel.Text += "\nТакой пользователь уже зарегестрирован.";
                    }
                }
                else
                {
                    if (PasswordTextBox1.Text == PasswordTextBox2.Text && LoginTextBox.Text != ""
                        && RoleComboBox.Text != "" && PasswordTextBox1.Text != "" && PasswordTextBox2.Text != "")
                    {
                        MD5 mD5 = MD5.Create();
                        var hash = mD5.ComputeHash(Encoding.UTF8.GetBytes(PasswordTextBox1.Text));

                        string login = LoginTextBox.Text;
                        string password = Convert.ToBase64String(hash);
                        Role role = new Role();
                        foreach (Role r in db.Roles)
                        {
                            if (r.Name == RoleComboBox.Text)
                            {
                                role = r;
                                break;
                            }
                        }
                        User user = new User { Login = login, Password = password, Role = role };
                        db.Add(user);
                        db.SaveChanges();
                        WarningLabel.ForeColor = Color.Green;
                        WarningLabel.Text = "Регистрация прошла успешно";
                    }
                    else
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "";
                        if (PasswordTextBox1.Text == "" || PasswordTextBox2.Text == "")
                            WarningLabel.Text += "В поле пароля ничего не указано.";
                        if (PasswordTextBox1.Text != PasswordTextBox2.Text)
                            WarningLabel.Text += "\nПароли не совпадают.";
                        if (LoginTextBox.Text == "")
                            WarningLabel.Text += "\nВ поле логин ничего не указано.";
                        if (RoleComboBox.Text == "")
                            WarningLabel.Text += "\nНе выбрана роль пользователя.";
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
