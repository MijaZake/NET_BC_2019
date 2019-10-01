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
                //1.1 Ievada vardu
                //1.2 Ievada datumu (DateTime.TryParse) ja neizdevas, vaica ievadit velreiz
                //1.3 Ievada dzimumu (Enum.TryParse)
                string name = GetName("Enter your name: ");
                DateTime date = GetDate("Enter your birth date (DD/MM/YYYY): ");
                UserProfile.Genders gender = GetGender("Enter your gender (M/F) : ");


                //2. Izsauc lietotaja pievienosna ar vertibam augstak
                list.Add(name,gender,date);
                //3. Ja neizdevas pievienot, attelo kludas pazinojumu un sak 1.soli no jauna
            }

            Console.Read();
        }

        static string GetName(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();

            return input;
        }

        static DateTime GetDate(string text)
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

        static UserProfile.Genders GetGender(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            if (UserProfile.Genders.TryParse(input, out UserProfile.Genders gender))
            {
                return gender;
            }
            else
            {
                Console.WriteLine("Invalid gender!");
                return GetGender(text);
            }
        }
    }
}
