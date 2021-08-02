using System;

public class EMP
{
    public string Department;
    public double Salary;
    public void calculate_Bonus(string Department, double salary)
    {
        if (Department == "Sales" || Department=="Marketing")
        {
            Salary = salary + 0.2 * salary;
            Console.WriteLine($"{Salary} 20% bonus ");
        }
       else if (Department == "Production")
        {
            Salary = salary + 0.1 * salary;
            Console.WriteLine($" {Salary}10% bonus ");
        }

        else
        {
            Console.WriteLine($" {salary} Not available ");
        }
    }
}

class Employee :EMP
{
    public static void Main()
    {
        int id,exp;
        string name,gender,dept;
        double salary;
        
        Console.WriteLine("Enter Employe Id :");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employe Name :");
        name = Console.ReadLine();

        Console.WriteLine("Enter Employe Gender :");
        gender = Console.ReadLine();

        Console.WriteLine("Enter Employee experience in years :");
        exp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Employee Department :");
        dept  = Console.ReadLine();
        EMP E=new EMP();
        E.calculate_Bonus(dept, salary);

        Console.WriteLine($"Employee id is :{id}");
        Console.WriteLine($"Employee name is :{name}");
        Console.WriteLine($"Employee gender is :{gender}");
        Console.WriteLine($"Employee department is :{dept}");
        Console.WriteLine($"Employee experience is :{exp}");
        Console.ReadLine();
    }
}