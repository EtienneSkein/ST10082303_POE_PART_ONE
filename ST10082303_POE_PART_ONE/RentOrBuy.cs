using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082303_POE_PART_ONE
{
    class RentOrBuy
        // class doing rental or buying calculations
    {
        // parallel arrays for the costs and cost anmes of buying a property
        private string[] propertyCostNames = { "Property Price ", "Total Deposit", "Interest Rate in %", "Months to repay(240 - 360)" };
        private static double[] propertyCosts = new double[4];

        // method for retrieveing user choice between renting or buying and capturing inputs 
        public void rentOrBuy()
        {
            Console.WriteLine("\nDo you wish to rent accomadation (1) or buy a property (2)");
            String userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("Please enter you monthly rental amount:");
                double rental = Double.Parse(Console.ReadLine());
                propertyCosts[3] = rental;
            }
            else
            {
                if (userChoice == "2")
                {
                    for (int i = 0; i < propertyCosts.Length; i++)
                    {
                        propertyCosts[i] = GetDouble(string.Format("Enter the {0} : ", propertyCostNames[i], ""));

                    }
                    for (int i = 0; i < propertyCostNames.Length; i++)
                    {
                        if (propertyCosts[3] > 360 || propertyCosts[3] < 240)
                        {
                            propertyCosts[3] = GetDouble(string.Format("Enter a value between 240 and 360 for {0} : ", propertyCostNames[3]));
                        }
                    }
                }
            }

            // converting user input from string to double for calculation 
            double GetDouble(string s)
            {
                double rental = 0.0;
                string userInput = "";
                do
                {
                    Console.WriteLine(s);
                    userInput = Console.ReadLine();
                } while (!double.TryParse(userInput, out rental));
                return rental;
            }

        }
        public static double findRepay()
        {
            Calculator random = new Calculator();
            double repayment = random.Afford(propertyCosts);

            Expenses getNextIncome = new Expenses();
            double NextIncome = getNextIncome.nextIncomeValue();


            if (repayment < NextIncome)
            {
                Console.WriteLine("You have been approved for the house-loan");
            }
            else
            {
                Console.WriteLine("You are unable to afford this option");
            }

            Console.WriteLine("Your Monthly installment will  be :R " + repayment);
            
            return repayment;


        }
        public double findValue()
        {
            Calculator random = new Calculator();
            double repayment = random.Afford(propertyCosts);
            return repayment;
        }
    }
}


    