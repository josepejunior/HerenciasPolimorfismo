using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // ComissionEmployee class that extends Employee
    public class ComissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales
        private decimal comissionRate; // comission percentage
        public ComissionEmployee(string firstname, string lastname, 
            string socialSecurityNumber, decimal grossSales,
            decimal comissionRate) : base(firstname, lastname, socialSecurityNumber)
        {
            GrossSales = grossSales; // validates gross sales
            ComissionRate = comissionRate; // validates comission rate
        }

        // property that gets and sets comission employee´s gross sales
        public decimal GrossSales 
        { 
            get => grossSales;
            set 
            { 
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GrossSales)} must be >= 0");
                }
                grossSales = value;
            }
        }
        public decimal ComissionRate 
        { 
            get => comissionRate;
            set 
            {
                if (value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                        value, $"{nameof(ComissionRate)} must be > 0 ");
                }
                comissionRate = value; 
            }
        }

        public override decimal Earnings() => ComissionRate * GrossSales;

        public override string ToString() =>
            $"comission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"comission rate: {ComissionRate:C}";
    }
}
