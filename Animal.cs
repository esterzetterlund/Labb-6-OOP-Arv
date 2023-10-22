using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_OOP_Arv
{        //A base class
    public class Animal   
    {    //With 5 properties
        public string _name { get; set; }   
        public int _age { get; set; }
        public string _breed { get; set; }
        public string _color { get; set; }
        public double _weight { get; set; }
        //constructor that takes name, age, breed, color, weight
        public Animal(string name, int age, string breed, string color, double weight)
        {// saves parameters as attributes in the object
            _name = name;
            _age = age;
            _breed = breed;
            _color = color;
            _weight = weight;
        }
        
         // 3 methods that every animal shares
        public virtual void Eat() 
        {
            Console.WriteLine($"{_name} äter");
        }
        public virtual void Sleep() 
        {
            Console.WriteLine($"{_name} sover");
        }
        public virtual void MakeSound() 
        {
            Console.WriteLine();
        }
        


    }
}
