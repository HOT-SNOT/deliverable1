using System;
using System.Threading.Tasks.Dataflow;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            int passwordSize = password.Length;
            bool hasUpperCase = false;
            for (int i = 0; i < passwordSize; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    hasUpperCase = true;
                }
            }
            bool hasLowerCase = false;
            for (int i = 0; i < passwordSize; i++)
            {
                if (Char.IsLower(password, i))
                {
                   hasLowerCase = true;
                }
            }
            if (passwordSize > 12)
            {
                Console.WriteLine("Error");
            }
            else if (passwordSize < 7)
            {
                Console.WriteLine("Error");
            }
            else if (!password.Contains("!"))
            {
                Console.WriteLine("Error");
            }
            else if (!hasUpperCase)
            {
                Console.WriteLine("Error");
            }
            else if (!hasLowerCase)
            {
                 Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("Password valid and accepted");
            }
            

       
        }
    }
}
