using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Testanto titulo";

            Employee ep = new Employee();

            Console.Write("How Many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> emp = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.Add(new Employee(id, name, salary)); // chamando o método Add a partir do objeto da lista e ai instanciando os atributos da classe.
                Console.WriteLine();

            }

            Console.Write("Enter the employee id the will have salary increase: ");
            int idInc = int.Parse(Console.ReadLine());


            Employee Incr = emp.Find(X => X.Id == idInc); // Expressão Lambda
            if (Incr != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Incr.increaseSalary(percentage);
                
            }
            else
            {
                Console.WriteLine("This id does not exist! ");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");
            foreach (Employee z in emp)
            {
                Console.WriteLine(z);
            }


        }
    }
}
