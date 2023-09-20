using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // SalariedEmployee class that extends Employee
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // four-parameter constructor
        public SalariedEmployee(string firstname, string lastname, 
            string socialSecurityNumber, decimal weeklySalary) 
            : base(firstname, lastname, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        // property that gets and sets salaried employee´s salary
        public decimal WeeklySalary
        { 
            get => weeklySalary;
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(weeklySalary)} must be >= o");
                }
                weeklySalary = value;
            }
        }

        // calculate earnigs; override abstract method Earning in Employee
        public override decimal Earnings() => weeklySalary;

        // return string representation of SalariedEmployee object
        public override string ToString() => $"salaried employee: {base.ToString()}\n" +
            $"weekly salary: {weeklySalary:C}";
    }
}
