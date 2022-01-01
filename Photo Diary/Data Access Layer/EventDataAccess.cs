using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer
{
    class EventDataAccess:DataAccess
    {
        public int AddEvent(Event events)
        {
            //string sql = "INSERT INTO events(Image,Title,Description,Importance,id) VALUES('" + events.Image + "','" + events.Title + "','" + events.Description + "','" + events.Importance + "'," + events.Id + ")";

            string sql = "INSERT INTO events(Image,Title,Description,Importance,id,UploadTime) VALUES('" + events.Image + "','" + events.Title + "','" + events.Description + "','" + events.Importance + "'," + events.Id + ",'" + events.UploadTime+ "')";
            return this.ExecuteQuery(sql);
        }


        public int UpdateEvent(Event events)
        {
            string sql = "UPDATE events SET Image='" + events.Image + "',Title='" + events.Title + "',Description='" + events.Description + "',Importance='" + events.Importance + "',id='" + events.Id + "',UploadTime='" + events.UploadTime + "',EditTime='" + events.EditTime + "' WHERE EventId=" + events.EventId;
            return this.ExecuteQuery(sql);
        }



        public Event GetEvent(int eventId) 
        {
            string sql = "SELECT * FROM events WHERE EventId=" + eventId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Event eventt = new Event();
                eventt.EventId = Convert.ToInt32(reader["EventId"]);
                eventt.Image = reader["Image"].ToString();
                eventt.Title = reader["Title"].ToString();
                eventt.Description = reader["Description"].ToString();
                eventt.Importance = reader["Importance"].ToString();
                eventt.UploadTime = reader["UploadTime"].ToString();
                eventt.EditTime = reader["EditTime"].ToString();
                return eventt;
            }
            return null;
        }

        public List<Event> GetEvents(int id)
        {
            string sql = "SELECT * FROM events WHERE id="+id;
            SqlDataReader reader = this.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event eventt = new Event();
                eventt.EventId = Convert.ToInt32(reader["EventId"]);
                eventt.Image = reader["Image"].ToString();
                eventt.Title = reader["Title"].ToString();
                eventt.Description = reader["Description"].ToString();
                eventt.Importance = reader["Importance"].ToString();
                eventt.UploadTime = reader["UploadTime"].ToString();
                eventt.EditTime = reader["EditTime"].ToString();

                events.Add(eventt);
            }
            return events;
        }




        public int DeleteEvent(int eventId)
        {
            string sql = "DELETE FROM events WHERE EventId=" + eventId;
            return this.ExecuteQuery(sql);
        }


    }
}
