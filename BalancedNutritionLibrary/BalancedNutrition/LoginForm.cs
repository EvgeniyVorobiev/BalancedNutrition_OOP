using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
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
    public partial class LoginForm : Form
    {
        public string log = "";
        public string role = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog();
            LoginForm loginForm = new LoginForm();
            loginForm.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                if (loginTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    MD5 mD5 = MD5.Create();
                    var hash = mD5.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text));
                    string login = loginTextBox.Text;
                    string password = Convert.ToBase64String(hash);


                    List<User> roles = db.Users
                        .Include(u => u.Role)
                        .Where(u => (u.Login == login) && (u.Password == password))
                        .ToList();
                    if (roles.Count > 0)
                        role = roles[0].Role.Name;
                    foreach (User u in db.Users)
                    {
                        if (login == u.Login)
                            if (password == u.Password)
                                {
                                log = u.Login;
                                Close();
                                }
                            else
                            {
                                WarningLabel.Text = "Пароль указан не верно";
                                
                            }
                        else
                        {
                            WarningLabel.Text = "пользователь не найден";
                            
                        }
                    }
                }
                else
                {
                    WarningLabel.Text = "";
                    if (passwordTextBox.Text == "")
                        WarningLabel.Text += "В поле пароля ничего не указано.";
                    if (loginTextBox.Text == "")
                        WarningLabel.Text += "\nВ поле логин ничего не указано.";
                }
            }
        }
    }
}
