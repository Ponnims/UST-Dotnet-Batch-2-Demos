using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }

        public string Address { get; set; }
    }
    internal class ObjectInitializerdemo
    {
        static void Main(string[] args)
        {
            // This is old way of creating an object and initializing its properties. It requires multiple lines of code and can be less concise.
            //    Person pobj = new Person();
            //    pobj.PersonId = 101;
            //    pobj.PersonName = "John";
            //    pobj.Address = "Noida";

            // Object initializer syntax allows you to create an object and initialize its properties in a single expression. This can make your code more concise and easier to read. For example, you can create a Person object and initialize its properties like this:
            Person pobj = new Person() 
            { 
                PersonId = 101, 
                PersonName = "John", 
                Address = "Noida",  
            };

            //collection initializer syntax allows you to create and initialize collections in a single expression. For example, you can create a List of Person objects and initialize it like this:
            //List<int> scores= new List<int>() { 90, 80, 85, 95 };
            // scores.Add(88);
            // scores.Add(92);

            //List<Person> people = new List<Person>();
            //people.Add(new Person() { PersonId = 102, PersonName = "Jane", Address = "Delhi" });
            //people.Add(new Person() { PersonId = 103, PersonName = "Mike", Address = "Mumbai" });
            //people.Add(new Person() { PersonId = 104, PersonName = "Sara", Address = "Bangalore" });



            List<Person> people = new List<Person>() 
            {
                new Person() { PersonId = 102, PersonName = "Jane", Address = "Delhi" },
                new Person() { PersonId = 103, PersonName = "Mike", Address = "Mumbai" },
                new Person() { PersonId = 104, PersonName = "Sara", Address = "Bangalore" }
            };

        }
    }
}
