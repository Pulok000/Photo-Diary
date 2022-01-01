using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer
{
    class LoginDataAccess : DataAccess
    {
        public int UserLoginValidation(User user)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + user.Username + "' AND Password='" + user.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["id"]); 

            }
            return -1;
        }

        //public int GetUserId(string id)
        //{
        //    string sql = "SELECT id FROM users WHERE id='" + id + "'";
        //    SqlDataReader reader = this.GetData(sql);
        //    if (reader.Read())
        //    {
        //        return Convert.ToInt32(reader["id"]);
        //    }
        //    return -1;
        //}


    }
}
