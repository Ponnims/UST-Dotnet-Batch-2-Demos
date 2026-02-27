using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    // Classic way of defining properties in C# is to use private fields and public properties. The private fields are used to store the data, and the public properties are used to access and modify the data. The properties have get and set accessors, which allow you to control how the data is accessed and modified. For example, you can make a property read-only by only providing a get accessor, or you can make it write-only by only providing a set accessor.
    class Employee
    {
        private string name;
        private int age;
        private string department;
        private double salary;

        // classic way of defining properties in C#
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Department
        {
            // get { return department; } this is an example of write-only property, as it only has a set accessor and no get accessor. This means that you can set the value of the Department property, but you cannot retrieve it.
            get { return department; }
            // set { department = value; } this is an example of read-only property, as it only has a get accessor and no set accessor. This means that you can retrieve the value of the Department property, but you cannot set it.
            set { department = value; }
        }

        //public double Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}

    }

    // Auto-implemented properties in C# are a shorthand syntax for defining properties without the need for explicit private fields. When you declare an auto-implemented property, the compiler automatically generates a private, anonymous backing field that can only be accessed through the property's get and set accessors. This allows you to quickly define properties without having to write additional code for the backing fields. For example, you can define an auto-implemented property like this: public string Name { get; set; }.
    class Traineee
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; }
        public string Technology { get; set; }
        public int Score { get; set; }
    }

    class Student
    {
        // Auto property initializer allows you to set a default value for an auto-implemented property. This means that if you create an instance of the class and do not explicitly set a value for the property, it will have the default value specified in the initializer. For example, in the Student class, the Name property is initialized with the default value "Unknown". If you create a Student object without setting the Name property, it will automatically have the value "Unknown".
        public int Id { get; set; } = 10;
        public string Name { get; set; }= "Unknown"; // this is an example of auto-implemented property with initializer, which allows you to set a default value for the property. In this case, if you create a Student object without setting the Name property, it will have the default value of "Unknown".
        public int Age { get; set; }
        public string Course { get; set; }
    }


    internal class ClassConcepts
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John Doe";// setting the name property
            Console.WriteLine($"Employee Name: {employee.Name}");// getting the name property
            employee.Age = 30;
            Console.WriteLine($"Employee Age: {employee.Age}");// getting the age property
            employee.Department = "HR";
            Console.WriteLine($"Employee Department: {employee.Department}");// getting the department property
 //employee.salary = 50000;// as slalary is private field, we can access it directly within the class, but not outside the class. So this line will cause a compilation error.
// Console.WriteLine($"Employee Salary: {employee.salary}"); // as slalary is private field, we can access it directly within the class, but not outside the class. So this line will cause a compilation error.


            Traineee tobj= new Traineee();
                tobj.TraineeId = 101;
                tobj.TraineeName = "Alice";
                tobj.Technology = "C#";
                tobj.Score = 85;
    
                Console.WriteLine($"Trainee ID: {tobj.TraineeId}");
                Console.WriteLine($"Trainee Name: {tobj.TraineeName}");
                Console.WriteLine($"Trainee Technology: {tobj.Technology}");
                Console.WriteLine($"Trainee Score: {tobj.Score}");
        }
    }
}
