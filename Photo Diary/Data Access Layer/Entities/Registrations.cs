using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Data_Access_Layer.Entities
{
    class Registrations
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

    }
}
