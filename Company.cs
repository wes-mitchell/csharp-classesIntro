using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; }

        // Create a public property for holding a list of current employees
        public Company(string name, DateTime createOn, List<Employee> employees)
        {
          Name = name;
          CreatedOn = createOn;
          Employees = employees;
        }

        public void ListEmployees(List<Employee> employeesList)
        {
          foreach(Employee employee in employeesList) 
          {
          Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as a \"{employee.Title}\" since {employee.StartDate}.");
          }
        }



        /*

            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}