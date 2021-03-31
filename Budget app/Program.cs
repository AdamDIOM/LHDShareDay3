using System;

namespace Budget_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you have to spend?");

            double budget = Convert.ToDouble(Console.ReadLine());
            double spent = 0.00;

            Console.WriteLine("Enter item name");
            string input = Console.ReadLine();
            while(input!="q"){
                Console.WriteLine($"How much does {input} cost?");
                spent += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter another item name");
                Console.WriteLine("enter 'q' to quit");
                input = Console.ReadLine();
            }

            Console.WriteLine($"You want to spend {Math.Round(spent,2)}, you have {Math.Round(budget,2)} in the budget.");
            if(spent < budget){
                Console.WriteLine($"Congratulations! You still have {Math.Round(budget-spent,2)} left!");
            }
            else{
                Console.WriteLine($"Oh no! You overspent by {Math.Round(spent-budget,2)}.");
            }
        }
    }
}
