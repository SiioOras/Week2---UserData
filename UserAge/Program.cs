using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"Oled sündinud aastal {yearOfBirth};

            Console.WriteLine("Palun sisesta enda vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;
            Console.WriteLine("Oled sündinud aastal " + yearOfBirth + "!");


        }
    }
}
