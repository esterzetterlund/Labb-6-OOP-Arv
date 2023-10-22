using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{
         //A subclass that inherit from class Dog
    internal class Spaniel : Dog
    {    //property, how long the fur is
        public string _furLength { get; set; }
         //constructor that calls the constructor of the dog class
        public Spaniel(string name, int age, string breed, string color, double weight, double catScares, string furLength) : base(name, age, breed, color, weight, catScares)
        {//Save the extra attribute in the object
            _furLength = furLength;
        }
         //New method to get dirty
        public void GetDirty()
        {
            Console.WriteLine($"{_name} blir smutsig");
        }
         //New method to print info
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name} \nÅlder: {_age} \nRas: {_breed} \nFärg: {_color} \nVikt: {_weight} \nPälslängd: {_furLength}");
        }
    }
}
