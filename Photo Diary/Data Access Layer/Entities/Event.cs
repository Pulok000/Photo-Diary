using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer.Entities
{
    class Event
    {
        public int EventId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Importance { get; set; }
        public int Id { get; set; }
        public string UploadTime { get; set; }
        public string EditTime { get; set; }
    }
}
