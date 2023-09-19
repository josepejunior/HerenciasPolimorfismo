using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // BasePlusComissionEmplyee class extends ComissionEmployee
    public class BasePlusComissionEmproyee : ComissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six parameter constructor
        public BasePlusComissionEmproyee(string firstname, string lastname,
            string socialSecurityNumber, decimal grossSales,
            decimal comissionRate, decimal baseSalary) 
            : base(firstname, lastname, socialSecurityNumber, grossSales, comissionRate)
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

        // return string representation of BasePlusComissionEmployee
        public override string ToString() =>
            $"base-salaried {base.ToString()}\n" +
            $"base salary: {BaseSalary:C}";
    }
}
