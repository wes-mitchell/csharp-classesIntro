using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company wmdrums = new Company("WMDRUMS", new DateTime(1969, 04, 20), new List<Employee>{});


            Employee wes = new Employee("Wes", "Mitchell", "Drum Masta", new DateTime(1987, 12, 22));
            Employee lee = new Employee("Lee", "Jennings", "Drum Padawon", new DateTime(1991, 10, 02));
            Employee nathan = new Employee("Nathan", "Traczewski", "Double Pedal God", new DateTime(1994, 02, 19));

            wmdrums.Employees.Add(wes);
            wmdrums.Employees.Add(lee);
            wmdrums.Employees.Add(nathan);

            wmdrums.ListEmployees(wmdrums.Employees);

        }
    }
}

