using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "john";
            string password = "pass123";
            int attempt = 3;
           


            while(attempt > 0)
            {
                Console.WriteLine("Enter username: ");
                string inputUsername = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string inputPassword = Console.ReadLine();

                if(inputUsername == username && inputPassword == password) 
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else if(inputUsername == username)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }
                attempt --;
            }
            if(attempt == 0)
            {
                Console.WriteLine("Login Failed. ");
            }
            Console.ReadKey();
        }
    }
}
