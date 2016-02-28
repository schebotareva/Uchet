using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class CurrentUser
    {

        private static int curUserId = -1;
        private static string lastName;
        private static string firstName;
        private static string middleName;

         public static int getUserId()
        {
            return curUserId;
        }

        public static void setUserId(int userId)
        {
            curUserId = userId;
        }

/*
        public static int getUserId()
        {
            return curUserId;
        }

        public static void setUserId(int userId)
        {
            curUserId = userId;
        }
        */

    }
}
