using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    internal class Program
    {
       /* static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";

            // Accessing methods from the base class
            myDog.Eat();
            myDog.Sleep();

            // Accessing method from the derived class
            myDog.Bark();
        }*/
    }


    internal class Base { 
    
    
     public virtual String Name { get; set; }
    
    }
    internal class Derived : Base
    {

        public String _name;

        public override String Name { 
        

            get { return base.Name; }
            set { base.Name = value+"Base"; 
                 _name = value;
            }
            
        }

        public String DerivedNumber { 
        get { return _name; }
                
                
                
                }
        

        



    }

    


    internal class Pro4 {

        static void Main(string[] args) {


            Derived derived = new Derived();
            derived.Name = "abc";
            System.Console.WriteLine(derived.Name);
            System.Console.WriteLine(derived.DerivedNumber);



        }






    }
}
