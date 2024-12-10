namespace _10._12._24;
using Entities;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("John", 30, "5000");
        Employee emp2 = new Employee("Jane", 25, "5000");

        if (emp1 == emp2)
        {
            Console.WriteLine("Both employees have the same salary.");
        }
        else
        {
            Console.WriteLine("Both employees have different salaries.");
        }

        if (emp1 > emp2)
        {
            Console.WriteLine("John has a higher salary than Jane.");
        }
        else
        {
            Console.WriteLine("Jane has a higher salary than John.");
        }

        emp1 = emp1 + 500;
        emp2 = emp2 - 500;

        Console.WriteLine($"John's new salary: {emp1.Salary}");
        Console.WriteLine($"Jane's new salary: {emp2.Salary}");
    }
}