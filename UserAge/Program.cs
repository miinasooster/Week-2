using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja vanust
            // programm arvutab kasutaja sünniaasta
            // programm kuvad kasutaja sünniaasta konsoolis
            // ''Oled sündinud aastal {yearOfBirth}''

            Console.WriteLine("Palun, sisesta vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 -userAge;

            //Console.WriteLine("Oled " + yearOfBirth + " aastal sündinud");

            //string interpolation

            Console.WriteLine($"oled {yearOfBirth} aastal sündinud");



        }
    }
}
