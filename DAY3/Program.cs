using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList list = new UserList();

            //1. cikliski vaicaa pievienot lietotajus
            while(true)
            {
                try
                {
                    //1.1 Ievada vardu
                    string name = GetName("Enter your name: ");
                    //1.2 Ievada datumu (DateTime.TryParse) ja neizdevas, vaica ievadit velreiz
                    DateTime date = GetDate("Enter your birth date (DD/MM/YYYY): ");
                    //1.3 Ievada dzimumu (Enum.TryParse)
                    UserProfile.Genders gender = GetGender("Enter your gender (Male/Female) : ");

                    //2. Izsauc lietotaja pievienosna ar vertibam augstak
                    list.Add(name, gender, date);
                }
                //3. Ja neizdevas pievienot, attelo kludas pazinojumu un sak 1.soli no jauna
                catch (Exception)
                {
                    Console.WriteLine("Neparedzeta kluda!");
                }
            }

            Console.Read();
        }

        public static string GetName(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            input = input.Trim();

            if (!String.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Empty text!");
                return GetName(text);
            }
        }

        public static DateTime GetDate(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out DateTime date))
            {
                return date;
            }
            else
            {
                Console.WriteLine("Invalid date!");
                return GetDate(text);
            }
        }

        public static UserProfile.Genders GetGender(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Incorrect value!");
                return GetGender(text);
            }
        }
    }
}
