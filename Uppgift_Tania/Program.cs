using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Tania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age ");
            int enteredAge = int.Parse(Console.ReadLine());
            int money = 15000;

            
            
            do
            {
                if (money > 20000 )
                {
                    money = money + 500;
                    //enteredAge = enteredAge + 1;
                    Console.WriteLine("You are saving little."+money);
                    
                }
                else if (enteredAge < 60)
                {
                    money = money + 500;
                    //enteredAge = enteredAge + 1;
                    Console.WriteLine("You are saving little." +money+ "in thee age of "+enteredAge);
                    enteredAge = enteredAge + 1;

                }
                else
                {
                    money = money + 1000;
                   
                    Console.WriteLine("You are saving a lot."+money);
                    
                }
            } while (money < 20000 && enteredAge < 65);
            
            
            Console.ReadLine();
        }
    }
}
