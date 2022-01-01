using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer
{
    class RegistrationdataAccess : DataAccess
    {

        public int AddUser(User user)
        {
            string sql = "INSERT INTO users(Name,UserName,Password,Email,Dob,Gender) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.Dob + "','" + user.Gender + "')";
            return this.ExecuteQuery(sql);
        }

        public Registrations GetUser(int userId)
        {
            string sql = "SELECT * FROM users WHERE id=" + userId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Registrations registration = new Registrations();
                registration.Id = Convert.ToInt32(reader["id"]);
                registration.Name = reader["Name"].ToString();
                registration.Username = reader["UserName"].ToString();
                registration.Password = reader["Password"].ToString();
                registration.Email = reader["Email"].ToString();
                registration.Dob = reader["Dob"].ToString();
                registration.Gender = reader["Gender"].ToString();
                return registration;
            }
            return null;
        }




    }
}
