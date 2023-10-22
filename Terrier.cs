using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
         //A subclass that inherit from class Dog
    internal class Terrier : Dog
    {    //property, how much musclemass the dog have
        public string _muscleMass { get; set; }
         //constructor that calls the constructor of the dog class
        public Terrier(string name, int age, string breed, string color, double weight, double catScares, string muscleMass) : base(name, age, breed, color, weight, catScares)
        {//Save the extra attribute in the object
            _muscleMass = muscleMass;
        }
         // New method to fight
        public void Fight()
        {
            Console.WriteLine($"{_name} fightar");
        }
         //New method to print info
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name} \nÅlder: {_age} \nRas: {_breed} \nFärg: {_color} \nVikt: {_weight} \nMuskelmassa: {_muscleMass}");
        }
    }
}
