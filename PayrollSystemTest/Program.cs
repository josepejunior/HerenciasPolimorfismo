using PayrollSystemTest;
// Employee hierachy test app.

// create derived-class objects

var salariedEmployee = new SalariedEmployee("Juan", "Espinoza", "111-11-1111", 800.00M);
var hourlyEmployee = new HourlyEmployee("Karen", "Pérez", "222-22-2222", 16.75M, 40.0M);
var commissionEmployee = new CommissionEmployee("Susana", "Júarez", "333-33-3333", 10000.00M, .06M);
var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Roberto", "López",
    "444-44-4444", 5000.00M, .04M, 300.00M);

Console.WriteLine("Employees processed individually:\n");

Console.WriteLine($"{salariedEmployee}\n" +
    $" earned: {salariedEmployee.Earnings():C}\n");
Console.WriteLine($"{hourlyEmployee}\n" +
    $" earned: {hourlyEmployee.Earnings():C}\n");
Console.WriteLine($"{commissionEmployee}\n" +
    $"earned: {commissionEmployee.Earnings():C}\n");
Console.WriteLine($"{basePlusCommissionEmployee}\n" +
    $"earned: {basePlusCommissionEmployee.Earnings():C}\n");

// create list<Employee> and initialize whit employee objects
var employees = new List<Employee>() {salariedEmployee, hourlyEmployee, 
    commissionEmployee, basePlusCommissionEmployee};

Console.WriteLine("Employees processed polymorphically:\n");

// generically process each element in employees
foreach (var currentEmployee in employees)
{
    Console.WriteLine(currentEmployee); // invokes ToString

    // determine whether element is a basePlusCommissionEmployee
    if (currentEmployee is BasePlusCommissionEmployee)
    {
        // downcast Employee reference to basePlusCommissionEmployee reference
        var employee = (BasePlusCommissionEmployee)currentEmployee;

        employee.BaseSalary += 1.10M;
        Console.WriteLine("new base salary with 10% increase is: " +
            $"{employee.BaseSalary:C}");
    }

    Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
}

// get type name of each object in employees
for (int i = 0; i < employees.Count; i++)
{
    Console.WriteLine($"Employee {i} is a {employees[i].GetType()}");
}