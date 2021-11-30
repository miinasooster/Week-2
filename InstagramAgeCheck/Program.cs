using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32 (Console.ReadLine());

            if(userAge > 13)
            {
            Console.WriteLine("Oled piisavalt vana, et Instagrammi kontot luua");
            }

            else if (userAge < 13)
            {
            Console.WriteLine("Oled liiga noor, et Instagrammi kontot luua");
            }

            else 
            {
            Console.WriteLine("Oledki 13, nüüd saad endale Instagrammi konto luua ");
            }

            Console.WriteLine ("Kena päeva");

        }
    }
}