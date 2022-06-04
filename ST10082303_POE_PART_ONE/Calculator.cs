using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10082303_POE_PART_ONE
{
    // Method to calculate cost
    class Calculator
    {
        public double Afford(double[] propertyCosts)
        {
            double homeLoanRepay;
            double timeToRepay;
            

            homeLoanRepay = propertyCosts[0] - propertyCosts[1];
            timeToRepay = propertyCosts[3] / 12;
            double IN = (propertyCosts[2] / 100) * timeToRepay;

            double totalRepayment = homeLoanRepay * (1 + IN);
            return totalRepayment / propertyCosts[3];

        }

    }
}

