﻿using PayableInterfaceTest;

// create a list<IPayable> and initialize it whit four
// objects of classes that implement interface IPayable
var payableObjects = new List<IPayable>()
{
    new Invoice("01234", "seat", 2, 375.00M),
    new Invoice("56789", "tire", 4, 79.95M),
    new SalariedEmployee("Carlos", "Guevara", "111-11-1111", 800.00M),
    new SalariedEmployee("Carlos", "Guevara", "111-11-1111", 800.00M)
};

Console.WriteLine("Invoice and Employees processed" +
    "polymorphically:\n");

// generically process each element in payableObjects
foreach (var payable in payableObjects)
{
    // output payable ant its appropiate payment amount
    Console.WriteLine($"{payable}");
    Console.WriteLine(
        $"payment due: {payable.GetPaymentAmount():C}\n");
}

/****************************************************************/

using(IPayableSerializer serializer = new PayableFileSerializer())
{
    serializer.WritePayableObjects(payableObjects);
}

using (IPayableSerializer serializer = new PayableExcelSerializer())
{
    serializer.WritePayableObjects(payableObjects);
}