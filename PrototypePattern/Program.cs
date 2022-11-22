#region PrototypePattern

EmployeePrototype tempEmployee1 = new TempEmployee();

tempEmployee1.Name = "Temp employee 1";
tempEmployee1.Id = 1;
tempEmployee1.EmployeeAddress = new Address { City = "Tanta", Building = "B1", StreetName = "Street name" };

EmployeePrototype tempEmployee2 = tempEmployee1.DeepClone();

Console.WriteLine("***************** Temp Employee 1 Original Valure *****************");
Console.WriteLine(tempEmployee1.ToString());
Console.WriteLine("***************** Temp Employee 2 clone Valure *****************");
Console.WriteLine(tempEmployee2.ToString());

tempEmployee1.EmployeeAddress.City = "Cairo";

Console.WriteLine("***************** Temp Employee 1 After change *****************");
Console.WriteLine(tempEmployee1.ToString());
Console.WriteLine("***************** Temp Employee 2 *****************");
Console.WriteLine(tempEmployee2.ToString());

#endregion