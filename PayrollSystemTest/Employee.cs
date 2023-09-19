using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemTest
{
    // Employee abstract base class
    public abstract class Employee
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
            $"{SocialSecurityNumber}";

        // abstract method overridden by derived classes
        public abstract decimal Earnings(); // no implementation here
    }
}
