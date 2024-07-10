using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    internal class Program
    {
        public void Text() {

            System.Console.WriteLine("This is text()");
        
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
            Console.WriteLine(2 + 8);

            
            Class1.Display();
            Class1.Display(a:22,11);

            Program p = new Program();

            p.Text();
          
            Console.ReadLine();

            
        }
        
    }
    public  static class Class1 {

        public static void Display() {

            Console.WriteLine("Display() method");
        }
        public static void Display(int a, int b)
        {

            Console.WriteLine("Display(String) method"+"A"+a+"B"+b);
            LocaFun();
          void LocaFun() { 

                System.Console.WriteLine("Local function");
            }
        }
    }

}
