using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
         //subclass Dog that inherit from base class : animal
    public class Dog : Animal
    {    //property, how many cats the dog have scared away
        public double _catScares { get; set; }
         //constructor that calls the constructor of the base class
        public Dog(string name, int age, string breed, string color, double weight, double catScares) : base(name, age, breed, color, weight)
        {//Save the extra attribute in the object
            _catScares = catScares;
        }
         //Overlay of the MakeSound method that prints the dogs sound in the console
        public override void MakeSound()
        {
            Console.WriteLine("VOFF");
        }
         // New method to scare a cat
        public void ScareACat()
        {
            Console.WriteLine($"{_name} skrämmer iväg en katt");
        }
         //New method to print info
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name} \nÅlder: {_age} \nRas: {_breed} \nFärg: {_color} \nVikt: {_weight} \nAntal skrämda katter: {_catScares}");
        }
    }
}
