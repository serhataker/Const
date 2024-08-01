using Const;
using System;
using System.ComponentModel.Design;

namespace Constructor
{


    class Constructor
    {

        static void Main(string[] args)
        {
            Baby baby1 = new Baby();
            Console.WriteLine($"Baby's name:{baby1.Name} Baby's surname:{baby1.Surname} Baby's Birthdate: {baby1.BirthDate}");


            Console.WriteLine("Please enter your babyS name");
            string babyName= Console.ReadLine();
            Console.WriteLine("Please enter your babyS surname");
            string babySurName= Console.ReadLine();

            Baby baby2 = new Baby(babyName, babySurName);
           Console.WriteLine($"Baby's name:{baby2.Name} Baby's surname:{baby2.Surname} Baby's Birthdate: {baby2.BirthDate}");

        }
    }
}