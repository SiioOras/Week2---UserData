using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvad kasutaja vanust konsoolis;
            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;
            //Console.WriteLine("Oled " + userAge + "aastat vana.");

            //string interpolation
            Console.WriteLine($"Oled {userAge} aastat vana.");


        }
    }
}
