
using System;

class Employee
 {
    public void Salary()
    {
        double salary, bonus, totalsalary;

        for (int employeeNo = 1; employeeNo <= 8; employeeNo++)
        {
            Console.WriteLine("Employee" + employeeNo);
            Console.Write("Enter a salary");
            salary=Convert.ToDouble(Console.ReadLine());

             if (salary < 20000)
             {
                bonus = salary *20 / 100;
             }
             else if (salary < 40000)
             {
                bonus = salary * 15 / 100;
             }
             else if (salary < 60000)
             {
                bonus = salary *10 / 100;
             }
            else
            {
                bonus = salary * 5 / 100;
            }

             totalsalary = salary + bonus ;

             Console.WriteLine("Salary    : Rs." + salary);
             Console.WriteLine("Bonus Amount : Rs." + bonus);
             Console.WriteLine("Total Salary : Rs." + totalsalary);
        }

    }
 }