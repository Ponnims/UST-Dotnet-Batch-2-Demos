using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CsharpFeatures
{
    class Employeee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    internal class SerializationDemo
    {
        static void Main(string[] args)
        {
            //Employeee emp= new Employeee
            //{
            //    Id = 1,
            //    Name = "John Doe",
            //    Department = "HR"
            //};

            List<Employeee> employees = new List<Employeee>
            {
                new Employeee { Id = 1, Name = "John Doe", Department = "HR" },
                new Employeee { Id = 2, Name = "Jane Smith", Department = "IT" },
                new Employeee { Id = 3, Name = "Bob Johnson", Department = "Finance" }
            };

            var options= new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(employees, options);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(jsonString);

            List<Employeee> deserializedEmps = JsonSerializer.Deserialize<List<Employeee>>(jsonString);
            Console.WriteLine("\nDeserialized Employees:");
            foreach (var emp in deserializedEmps)
            {
                Console.WriteLine($"Id: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Department: {emp.Department}");
            }
        }
    }
}
