using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Libraries;

namespace BLL
{
    public class Login
    {
        public void LogIn()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "abcd" || password != "1234") && (ctr != 5));

            if (ctr == 5)
                Console.Write("\nLogin attempt five reached. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }
    }

}
