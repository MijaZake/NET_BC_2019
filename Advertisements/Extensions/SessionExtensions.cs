using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertisements.Extensions
{
    public static class SessionExtensions
    {
        //User Email get set
        //User Id get set
        private static string MAIL = "usermail";
        private static string ID = "userid";

        public static void SetUserEmail(this ISession session, string email)
        {
            session.SetString(MAIL, email);
        }

        public static string GetUserEmail(this ISession session)
        {
            return session.GetString(MAIL);
        }

        public static void SetUserId(this ISession session, int id)
        {
            session.SetInt32(ID, id);
        }

        public static int? GetUserId(this ISession session)
        {
            return session.GetInt32(ID);
        }
    }
}
