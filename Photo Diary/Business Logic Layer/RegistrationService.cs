using PhotoDiary.Data_Access_Layer;
using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary.Business_Logic_Layer
{
    class RegistrationService
    {
        RegistrationdataAccess registrationdataAccess;

        public RegistrationService()
        {

            this.registrationdataAccess = new RegistrationdataAccess();
        
        }

        public int AddNewUser(string name, string userName, string password, string email, string dob, string gender)
        {

            User user = new User()
            {

                Name = name,
                Username = userName,
                Password = password,
                Email= email,
                Dob = dob,
                Gender= gender
            };
            this.registrationdataAccess = new RegistrationdataAccess();
            return this.registrationdataAccess.AddUser(user);
        }


        public Registrations GetUser(int userId)
        {
            return this.registrationdataAccess.GetUser(userId);
        }


    }
}
