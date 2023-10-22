using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{        //subclass Cat that inherit from base class : animal
    public class Cat : Animal
    {    //property, how many rats the cat have catch
        public double _ratScores { get; set; }

         //constructor that calls the constructor of the base class
        public Cat(string name, int age, string breed, string color, double weight, double ratScores) : base(name, age, breed, color, weight)
        {//Save the extra attribute in the object
            _ratScores = ratScores;
        }
         //Overlay of the MakeSound method that prints the cats sound in the console
        public override void MakeSound()
        {
            Console.WriteLine($"MJAU");
        }
         // New method to catch a rat
        public void CatchRat()
        {
            Console.WriteLine($"{_name} fångar en råtta, så nu har {_name} fångat {_ratScores + 1} råttor.");
        }
         //New method to print info
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name} \nÅlder: {_age} \nRas: {_breed} \nFärg: {_color} \nVikt: {_weight} \nAntal fångade råttor: {_ratScores}");

        }
    }
}
