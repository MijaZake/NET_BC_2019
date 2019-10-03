using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            //parbaudes
            //1. Datums nedrikst but nakotne
            if (date > DateTime.Now)
            {
                throw new UserException("");
            }

            //2. Datums nedrikst but mazaks par 01.01.1800
            DateTime limit = new DateTime(01, 01, 1800);
            if (date < limit)
            {
                throw new UserException("");
            }

            //3. Pilnais vards nedrikst parsniegt 20 simbolus
            if (fullName.Length > 20)
                {
                throw new UserException("");
            }

            //lietotaja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            //lietotaja pievienosana
            users.Add(user);
        }
    }
}
