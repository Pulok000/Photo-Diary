using PhotoDiary.Data_Access_Layer;
using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Business_Logic_Layer
{
    class EventService
    {
        EventDataAccess eventDataAccess;
        

        public EventService()
        {

            this.eventDataAccess = new EventDataAccess();
        
        }

        public int AddEvent(string image, string title, string description, string importance, int id,string uploadTime)
        {

            Event events = new Event()
            {

                Image = image,
                Title = title,
                Description = description,
                Importance = importance,
                Id = id,
                UploadTime=uploadTime
            };
            this.eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddEvent(events);
        }

        public int UpdateEvent(string image, string title, string description, string importance, int id, string uploadTime, string editTime,int eventId)
        {
            Event events = new Event()
            {
                EventId = eventId,
                Image = image,
                Title = title,
                Description = description,
                Importance = importance,
                Id = id,
                UploadTime = uploadTime,
                EditTime=editTime
            };
            this.eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.UpdateEvent(events);
        }


        public Event GetEvent(int eventId)
        {
            return this.eventDataAccess.GetEvent(eventId);
        }

        public List<Event> GetAllEvents(int id)
        {

            return this.eventDataAccess.GetEvents(id);
        }

        public int DeleteEvent(int eventId)
        {
            return this.eventDataAccess.DeleteEvent(eventId);
        }

    }
}
