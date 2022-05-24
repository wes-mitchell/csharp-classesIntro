using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {
      public string FirstName { get; set;}
      public string LastName { get; set; }
      public string Title { get; set; }
      public DateTime StartDate { get; set; }

      public Employee(string firstName, string lastName, string title, DateTime startDate)
      {
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StartDate = startDate;
      }
    }
}