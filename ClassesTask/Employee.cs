using System;
public class Employee
{
    private string name { get; set; }
    public string lastName { get; set; }

    enum JobPosition { Junior = 500, Middle = 1000, Senior = 2000, Lead = 2500, Head = 3000 }
    public Employee(string _name, string _lastName)
    {
        name = _name;
        lastName = _lastName;
    }


    public double Taxes(double salary)
    {
        return (salary / 100) * 18;
    }

    #region  Method witch count Salary and experience  
    public void Experience()
    {
        Console.Write("Enter your job position ( Junior: 1, Middle: 2, Senior: 3, Lead: 4, Head: 5 ): ");
        int jobPosition = Convert.ToInt32(Console.ReadLine());

        double taxes;

        switch (jobPosition)
        {
            case 1:
                taxes = Taxes(Convert.ToInt32(JobPosition.Junior));
                Console.WriteLine(name + " " + lastName + " " + JobPosition.Junior + " " + taxes + " uan");
                break;
            case 2:
                taxes = Taxes(Convert.ToInt32(JobPosition.Middle));
                Console.WriteLine(name + " " + lastName + " " + JobPosition.Junior + " " + taxes + " uan");
                break;
            case 3:
                taxes = Taxes(Convert.ToInt32(JobPosition.Senior));
                Console.WriteLine(name + " " + lastName + " " + JobPosition.Junior + " " + taxes + " uan");
                break;
            case 4:
                taxes = Taxes(Convert.ToInt32(JobPosition.Lead));
                Console.WriteLine(name + " " + lastName + " " + JobPosition.Junior + " " + taxes + " uan");
                break;
            case 5:
                taxes = Taxes(Convert.ToInt32(JobPosition.Head));
                Console.WriteLine(name + " " + lastName + " " + JobPosition.Junior + " " + taxes + " uan");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value is not valid!!! Please Enter again!");
                Console.ResetColor();
                Experience();
                break;
        }


    }

    #endregion
}