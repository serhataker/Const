using Const;
using System;
using System.ComponentModel.Design;

namespace Constructor
{


    class Constructor// create to the main classs
    {

        static void Main(string[] args)
        {
            Baby baby1 = new Baby();// call the constroctor method any parametres
            Console.WriteLine($"Baby's name:{baby1.Name} Baby's surname:{baby1.Surname} Baby's Birthdate: {baby1.BirthDate}");// write to the baby1 instance inforömation at the console


            Console.WriteLine("Please enter your babyS name");
            string babyName= Console.ReadLine();
            Console.WriteLine("Please enter your babyS surname");
            string babySurName= Console.ReadLine();

            Baby baby2 = new Baby(babyName, babySurName);//call the constructor2 with the name and surname parameters
           Console.WriteLine($"Baby's name:{baby2.Name} Baby's surname:{baby2.Surname} Baby's Birthdate: {baby2.BirthDate}");// write to the baby2 instance inforömation at the console

        }
    }
}