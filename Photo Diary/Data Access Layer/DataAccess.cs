﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer
{
    class DataAccess : IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PhotoDiary"].ConnectionString);
                this.connection.Open();
            }
            catch (Exception exp)
            {

            }
        }

        public SqlDataReader GetData(string sql) //Ex: search,..,..
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)//Ex: show,edit,..
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }

        ~DataAccess()
        {
            //this.connection.Close();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}