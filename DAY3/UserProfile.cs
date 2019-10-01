using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    class UserProfile
    {
        public const char MALE = 'M';
        public const char FEMALE = 'F';

        public enum Genders
        {
            Male,
            Female
        }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public Genders Gender { get; set; }
        //public char Gender, if no enum

        public UserProfile(string fullName, DateTime birthDate, Genders gender)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
        }


    }
}
