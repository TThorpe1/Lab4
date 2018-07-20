using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string Input2 = "Number";
            string Calc1 = "Squared";
            string Calc2 = "Cubed";
            string Marks = "=======";

            string userChoice = "y";
            Console.WriteLine("Learn your squares and cubes!"); 

            while(userChoice.ToLower() == "y")



            {
                
                Console.WriteLine("Please enter an integer.");

                int num = int.Parse(Console.ReadLine());

                string header = string.Format("{0,10} {1,10} {2,10}", Input2, Calc1, Calc2);
                Console.WriteLine(header);

                string border = string.Format("{0,10} {1,10} {2,10}", Marks, Marks, Marks);
                Console.WriteLine(border);

                for (int i=1;i<=num;i++)
                {
                    int Squared = i * i;
                    int Cubed = i * i * i;

                    string result = string.Format("{0,10} {1,10} {2,10}", i, Squared, Cubed);                  
                     
                    Console.WriteLine(result);                                        
                }

                Console.WriteLine("do you want to continue \"(y/n)\"?");
                userChoice = Console.ReadLine();
            }


        }
    }
}
