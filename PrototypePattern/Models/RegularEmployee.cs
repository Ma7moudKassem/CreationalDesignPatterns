namespace PrototypePattern;

public class RegularEmployee : EmployeePrototype
{
    public override EmployeePrototype DeepClone()
    {
        return (RegularEmployee)this.MemberwiseClone();
    }

    public override EmployeePrototype ShallowClone()
    {
        RegularEmployee employee = new();
        employee = (RegularEmployee)this.MemberwiseClone();
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
