﻿using PhotoDiary.Data_Access_Layer;
using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Business_Logic_Layer
{
    class LoginService
    {

        LoginDataAccess loginDataAccess;
        public LoginService()
        {
            this.loginDataAccess = new LoginDataAccess();
        }
        public int LoginValidation(string username, string password)
        {
            User user = new User()
            {
                Username = username,
                Password = password
            };
            return loginDataAccess.UserLoginValidation(user);
        }



    }
}
