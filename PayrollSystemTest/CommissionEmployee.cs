using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // CommissionEmployee class that extends Employee
    public class CommissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales
        private decimal commissionRate; // commission percentage
        public CommissionEmployee(string firstname, string lastname, 
            string socialSecurityNumber, decimal grossSales,
            decimal commissionRate) : base(firstname, lastname, socialSecurityNumber)
        {
            GrossSales = grossSales; // validates gross sales
            CommissionRate = commissionRate; // validates commission rate
        }

        // property that gets and sets commission employee´s gross sales
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
        public decimal CommissionRate 
        { 
            get => commissionRate;
            set 
            {
                if (value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                        value, $"{nameof(CommissionRate)} must be > 0 and <1");
                }
                commissionRate = value; 
            }
        }

        public override decimal Earnings() => CommissionRate * GrossSales;

        public override string ToString() =>
            $"commission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"commission rate: {CommissionRate:F2}";
    }
}
