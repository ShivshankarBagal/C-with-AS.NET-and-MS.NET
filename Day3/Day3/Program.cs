using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{


    public class Pro2 {

        private int id= 12;
        private string name;
        private int age;

        public int Id { get; private set; }
        public string Name { get { return name; } set { name = value; } }   

        public int Age { get { return age; }
            set {

                if (value < 21 || value > 65)
                    throw new ArgumentOutOfRangeException(" Sorry, You are not eligible for this position");               
            age = value;
            }
        
        }
        
    
    }
    internal class Program
    {

        public static int e;

        Program() { }
        static void Main(string[] args)
        {
           
            //System.Console.WriteLine("This is main() method");
            Pro2 p = new Pro2();
            try
            {
              //  p.Name = "test";
                p.Age = 33;

               // System.Console.WriteLine("Id " + p.Id);
                //System.Console.WriteLine("Name " + p.Name);
                System.Console.WriteLine("Age" +  p.Age);
            }
            catch(ArgumentOutOfRangeException ag)
            {
                Console.WriteLine(ag.Message);

            }
            
        }
        
        
    }

    public class Class1 { 
    
    
    
    
    }
}
