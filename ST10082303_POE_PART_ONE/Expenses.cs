using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082303_POE_PART_ONE
{
    class Expenses
    {
        // filling array with values needed//
        public double monthlyIncome;
        private string[] costsName = { "Monthly income tax", "Food and Drink","Utilities", "Travel expenses ", "Phone contract", "Other expenses"};
        public double[] costs = new double[6];


        public void Hello()
        {
            Console.WriteLine("Welcome to your expense calculator:\n");


            Console.WriteLine("Would you like to make a new calculation?\nEnter y / n\n");
            String userChoice = Console.ReadLine();
            if(userChoice == "y")
            {
                Console.WriteLine("\nLets get started:");
            }
            else
            {
                Console.WriteLine("Goodbye");
                System.Environment.Exit(0);
            }
        }

        public double GetDouble(string s)
        {
            double userOutput = 0;
            string userInput = "";
            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out userOutput));

            return userOutput;
        }


        public void getUserInfo()
        {
            for (int i = 0; i < costs.Length; i++)
            {
                costs[i] = GetDouble(string.Format("Enter cost for {0} : ", costsName[i]));
            }
        }

        public double getMonthlyIncome()
        {
            Console.Write("Enter your gross monthly income: ");
            monthlyIncome = Convert.ToDouble(Console.ReadLine());
            return monthlyIncome;
        }

        public double MonthlyIncome { get => monthlyIncome; set => monthlyIncome = value; }

        public double nextIncomeValue()
        {
            double nextIncomeValue = getMonthlyIncome() * 0.3333;
            return nextIncomeValue;
        }

        public static void remainder(double[] costs, double monthlyIncome)
        {
            RentOrBuy fetch = new RentOrBuy();
            double remainder = monthlyIncome - (costs[0] + costs[1] + costs[2] + costs[3] + costs[4] + costs[5] + fetch.findValue());
            Console.WriteLine("You have R " + remainder + " left after all monthly deductions");
        }
    }
}
    

