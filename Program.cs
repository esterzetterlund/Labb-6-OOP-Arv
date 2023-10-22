namespace Labb_6_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("namn", 0, "ras", "färg", 0);
       
            Cat svante = new Cat("Svante", 7, "Katt", "vit", 4, 50);
            svante.PrintInfo();
            svante.CatchRat();
            svante.MakeSound();

            Console.WriteLine("----------------");

            Dog harry = new Dog("Harry", 2, "Hund", "Partymix", 7, 20);
            harry.PrintInfo();
            harry.Sleep();
            harry.MakeSound();

            Console.WriteLine("----------------");

            Rat sammy = new Rat("Sammy", 23, "Råtta", "Grå", 0.2, 5);
            sammy.PrintInfo();
            sammy.SearchForCheese();
            sammy.Eat();
            sammy.MakeSound();

            Console.WriteLine("----------------");

            Spaniel ted = new Spaniel("Ted", 1, "Tibetansk Spaniel", "Svart", 3, 0, "Långt");
            ted.PrintInfo();
            ted.GetDirty();
            ted.MakeSound();

            Console.WriteLine("----------------");

            Terrier ralf = new Terrier("Ralf", 4, "Amstaff", "Brun", 14, 100, "Mycket");
            ralf.PrintInfo();
            ralf.Fight();
            ralf.MakeSound();
           
        }
    }
    
    
    
    
}