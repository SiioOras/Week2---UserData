using System;

namespace InstaAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on 13 aastat vana või vanem kui 13 aastat;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrami kasutada;
            //kui kasutaja on noorem kui 13 aastat, siis ta on liiga noor.

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua!");
            }

            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor Instagrami konto loomiseks!");
            }

            else
            {
                Console.WriteLine("Oled täpselt piiri peal, et Instagrami kontot luua!");
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
