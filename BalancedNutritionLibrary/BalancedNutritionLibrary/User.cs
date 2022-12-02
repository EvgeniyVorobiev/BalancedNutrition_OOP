using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class User : BaseClass
    {
        public User(int Id, string Login, int Password)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
        }
        public string Login { get; set; }
        public int Password { get; set; }

    }
}
