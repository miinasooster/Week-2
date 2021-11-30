using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //''OLED LIIGA NOOR, ET JUHILUBE SAADA'';
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //''OLED PIISAVALT VANA, ET JUHILUBE SAADA'';
            // kui kasutaja on 18, siis programm kuvab konsoolis
            //''PALJU ÕNNE, NÜÜD SA SAAD JUHILUBA TAOTLEDA'';

            Console.WriteLine("Palun, sisesta oma sünniaasta!");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("OLED PIISAVALT VANA, ET JUHILUBE SAADA");
            }

            else if (userAge < 18)
            {
                Console.WriteLine("OLED LIIGA NOOR, ET JUHILUBE SAADA");
            }

            else
            {
                Console.WriteLine("PALJU ÕNNE, NÜÜD SA SAAD JUHILUBA TAOTLEDA ");
            }

            Console.WriteLine("Kena päeva");

        }
    }
}
