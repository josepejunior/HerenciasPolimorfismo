using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // BasePlusCommissionEmplyee class extends ComissionEmployee
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six parameter constructor
        public BasePlusCommissionEmployee(string firstname, string lastname,
            string socialSecurityNumber, decimal grossSales,
            decimal commissionRate, decimal baseSalary) 
            : base(firstname, lastname, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary 
        { 
            get => baseSalary;
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(BaseSalary)} must be >= 0");
                }
                baseSalary = value;
            }

        }

        // Calculate earnings
        public override decimal Earnings() => BaseSalary + base.Earnings();

        // return string representation of BasePlusCommissionEmployee
        public override string ToString() =>
            $"base-salaried {base.ToString()}\n" +
            $"base salary: {BaseSalary:C}";
    }
}
