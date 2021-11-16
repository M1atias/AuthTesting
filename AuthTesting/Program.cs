using System;

namespace AuthTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string Something()
        {
            return "something";
        }

        public static bool Loguin(string user, string pass) =>
            user == "mmolina" && pass == "123456" ? true : false;

    }
}
