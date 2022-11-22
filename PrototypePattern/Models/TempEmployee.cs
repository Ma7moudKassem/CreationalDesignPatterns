namespace PrototypePattern;

public class TempEmployee : EmployeePrototype
{
    public override EmployeePrototype ShallowClone()
    {
        return (TempEmployee)this.MemberwiseClone();
    }

    public override EmployeePrototype DeepClone()
    {
        TempEmployee employee = new();
        employee = (TempEmployee)this.MemberwiseClone();
        employee.EmployeeAddress = new Address
        {
            Building = EmployeeAddress.Building,
            City = EmployeeAddress.City,
            StreetName = EmployeeAddress.StreetName,
        };
        employee.Name = this.Name;

        return employee;
    }
}
