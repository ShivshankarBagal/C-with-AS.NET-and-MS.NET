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




    class baseClass
    {

        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }


    // class 'baseClass' inherit 
    // class 'derived'
    class derived : baseClass
    {

        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class GFG
    {

        // Main Method
/*        public static void Main()
        {

            baseClass obj;

            // 'obj' is the object
            // of class 'baseClass'
            obj = new baseClass();

            // it invokes 'show()' 
            // of class 'baseClass'
            obj.show();


            // the same object 'obj' is now
            // the object of class 'derived'
            obj = new derived();

            // it invokes 'show()' of class 'derived'
            // 'show()' of class 'derived' is overridden
            // for 'override' modifier
            obj.show();

        }*/
    }
    class AnonymousMethod
    {

        // Create a delegate 
        public delegate void petanim(string pet);

        // Main method 
        static public void Main()
        {

            string fav = "Rabbit";

            // Anonymous method with one parameter 
            petanim p = delegate (string mypet)
            {
                Console.WriteLine("My favorite pet is {0}.",
                                                     mypet);

                // Accessing variable defined 
                // outside the anonymous function 
                Console.WriteLine("And I like {0} also.", fav);
            };
            p("Dog");
        }
    }
}
