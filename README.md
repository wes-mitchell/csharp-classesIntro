## Initial Prompts for Exercise

### Instructions

Copy the following starter code into your `Program.cs` file to get started.

> Program.cs

```cs
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
```

---

Create a `Company.cs` file and copy the following code into the file to continue.

> Company.cs

```cs
using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}
```

1. Expand on the `Company` class code by
    1. Adding an **Employees** property (Its type should be **`List<Employee>`**)
    1. Setting the value of **Employees** in the constructor as a `new List<Employee>` (News Flash: Declaring a property gives it an initial vlaue of `null`). This will allow you to add newly created employees to the Employees list in the final step below.
1. Create an `Employee.cs` file and then define a class for `Employee`. An employee has the following properties.
    1. First name (_string_)
    1. Last name (_string_)
    1. Title (_string_)
    1. Start date (_DateTime_)
1. The `Company` class should also have a `ListEmployees()` method which writes a string to the console about each employee, such as _"Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."_
1. In the `Main` method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.