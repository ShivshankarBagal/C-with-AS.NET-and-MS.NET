using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    /* internal class Program
     {
         static void Main(string[] args)
         {

             int a ;

             OutMethod(out a);
             Console.WriteLine(a);

             int b=2;
             RefMethod(ref b);
             Console.WriteLine(b);


         }
         public static void OutMethod(out int x) {
            x=100;
             Console.WriteLine(x);

         }
         public static void RefMethod(ref int x)

         {
             Console.WriteLine(x);   
             x = 300;
             Console.WriteLine(x);

         }
     }*/



    //Encapsulation
    /*  public class OopsInCSharp 
      {
          private int studentId;

          public OopsInCSharp(int id) { 
            this.studentId = id;
          }
          public OopsInCSharp() { }
          private String StrudentName { get; set; }

         public static void Main(string[] args)
          {
              OopsInCSharp oopsInCSharp = new OopsInCSharp(11);
              oopsInCSharp.StrudentName = "Shivam";

              Console.WriteLine("ID ={0}  name= {1}", oopsInCSharp.studentId  , oopsInCSharp.StrudentName);
              Console.WriteLine("Name= " + oopsInCSharp.StrudentName);
          }
      }*/

    //Inheritance

    public class InhertanceExample {

        public class Animal 
        { 
           
            public void Eat() {
                System.Console.WriteLine("Animals are eating");
            }
        
        
        }

        public class Dog : Animal{

            public void Sound() {

                System.Console.WriteLine("Dogs are barking");
            }
        
        }
        public class Test { 
        
        public static void Main(string[] args)
            {

                Dog dog = new Dog();
                dog.Sound();
                dog.Eat();

                Animal animal = new Animal();
                animal.Eat();
                animal = new Dog();
                animal.Eat();
               // animal.Sound();
                Dog dog2 = (Dog)animal;
                dog2.Sound();
                dog2.Eat();
            }
        
        }
    
    
    }

}
