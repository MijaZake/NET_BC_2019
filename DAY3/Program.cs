using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHelper;

namespace DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserList list = new UserList();

                //1. cikliski vaicaa pievienot lietotajus
                while (true)
                {
                    try
                    {
                        //1.1 Ievada vardu
                        string name = ConsoleInput.GetText("Enter your name: ");
                        //1.2 Ievada datumu (DateTime.TryParse) ja neizdevas, vaica ievadit velreiz
                        DateTime date = ConsoleInput.GetDate("Enter your birth date (DD/MM/YYYY): ");
                        //1.3 Ievada dzimumu (Enum.TryParse)
                        UserProfile.Genders gender = GetGender("Enter your gender (Male/Female) : ");

                        //2. Izsauc lietotaja pievienosna ar vertibam augstak
                        list.Add(name, gender, date);

                        Console.Write("Add another? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        if (input == "n")
                        {
                            break;
                        }
                    }
                    //3. Ja neizdevas pievienot, attelo kludas pazinojumu un sak 1.soli no jauna
                    catch (UserException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error! {0}", ex.Message);
            }

            Console.Read();
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
