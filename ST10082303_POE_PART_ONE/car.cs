using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082303_POE_PART_ONE
{
    class car
    {
        Expenses exp = new Expenses();
        public void entry(double income)
        {
            Console.WriteLine("Would you like to buy a car? Press (Y) for Yes or (N) No");
            string ans = Console.ReadLine().ToUpper();
            while (!ans.Equals("YES") && !ans.Equals("NO"))
            {
                Console.WriteLine("Please enter either Yes or No");
                ans = Console.ReadLine().ToUpper();
            }
            if (ans.Equals("YES"))
            {
                getCarInfo(income);
            }
        }
        // get values and car info//
        public void getCarInfo(double income) 
        {
            Console.WriteLine("Enter Model and Make");
            string modelMake = Console.ReadLine();
            double purchasePrice = exp.GetDouble("Purchase Price");
            double totalDeposit = exp.GetDouble("Total Deposit");
            double interestRate = exp.GetDouble("Interest Rate");
            double insurance = exp.GetDouble("Estimated Insurance Premium");
            calculateCar(purchasePrice, totalDeposit, interestRate, insurance, income);
        }
        // Monthly cost calculations//
        double calculateCar(double price, double deposit, double interest, double insurance, double income)
        {
            double x = price - deposit;
            x = x * interest / 60 + insurance;
            Console.WriteLine("Total monthly cost of buying car: R" + x);
            if (x>.75*income) { Console.WriteLine("Warning! Repayment exceeds 75% of your income!"); }
            return x;
        }
    }
}
