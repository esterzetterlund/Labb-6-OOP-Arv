using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
         //A subclass Rat that inherit from base class : animal
    public class Rat : Animal
    {    //property, how long the tail are
        public double _tailLength { get; set; }
         //constructor that calls the constructor of the base class
        public Rat(string name, int age, string breed, string color, double weight, double tailLength) : base(name, age, breed, color, weight)
        {//Save the extra attribute in the object
            _tailLength = tailLength;
        }
         //Overlay of the MakeSound method that prints the cats sound in the console
        public override void MakeSound()
        {
            Console.WriteLine("PIP");
        }
         // New method to search for cheese
        public void SearchForCheese()
        {
            Console.WriteLine($"{_name} letar efter ost");
        }
         //New method to print info
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name} \nÅlder: {_age} \nRas: {_breed} \nFärg: {_color} \nVikt: {_weight} \nSvanslängd: {_tailLength}");
        }
    }
}
