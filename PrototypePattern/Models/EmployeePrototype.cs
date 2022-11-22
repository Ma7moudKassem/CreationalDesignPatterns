namespace PrototypePattern;

public abstract class EmployeePrototype
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Address EmployeeAddress { get; set; }

    public abstract EmployeePrototype ShallowClone();
    public abstract EmployeePrototype DeepClone();

    public override string ToString()
    {
        return $"Id: {this.Id}\n Name: {this.Name}\n Address: {this.EmployeeAddress.City},{this.EmployeeAddress.StreetName},{this.EmployeeAddress.Building}";
    }
}
