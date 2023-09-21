using PayableInterfaceTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    // Employee abstract base class taht implements interface IPayable
    public abstract class Employee : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        // three-parameter constructor
        public Employee(string firstname, string lastname,
            string socialSecurityNumber)
        {
            FirstName = firstname;
            LastName = lastname;
            SocialSecurityNumber = socialSecurityNumber;
        }

        // return string representation of Employee object, using properties
        public override string ToString() => $"{FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}";

        // abstract method overridden by derived classes
        public abstract decimal Earnings(); // no implementation here

        // implementing GetPaymentAmount here eneables the entire employee 
        // class hierarchy to be used in an app that process IPayables
        public decimal GetPaymentAmount() => Earnings();
    }
}
