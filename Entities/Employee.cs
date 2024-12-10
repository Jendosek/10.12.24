namespace _10._12._24.Entities;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Salary { get; set; }
    
    public Employee()
    {
        Name = "Unknown";
        Age = 0;
        Salary = "Unknown";
    }
    
    public Employee(string name, int age, string salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public static Employee operator +(Employee emp, double amount)
    {
        double salary = double.Parse(emp.Salary);
        salary += amount;
        emp.Salary = salary.ToString();
        return emp;
    }
    
    public static Employee operator -(Employee emp, double amount)
    {
        double salary = double.Parse(emp.Salary);
        salary -= amount;
        emp.Salary = salary.ToString();
        return emp;
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.Salary != emp2.Salary;
    }

    public static bool operator <(Employee emp1, Employee emp2)
    {
        double salary1 = double.Parse(emp1.Salary);
        double salary2 = double.Parse(emp2.Salary);
        return salary1 < salary2;
    }
    
    public static bool operator >(Employee emp1, Employee emp2)
    {
        double salary1 = double.Parse(emp1.Salary);
        double salary2 = double.Parse(emp2.Salary);
        return salary1 > salary2;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Employee emp = (Employee) obj;
        return Name == emp.Name && Age == emp.Age && Salary == emp.Salary;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
    }
}