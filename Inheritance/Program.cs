using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirsName="Engin"},
                new Student{FirsName="Yakup" },
                new Person{FirsName="Halo"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirsName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
                  
    }

    class Customer : Person //interfaces ler 2 kere yazılabilir ancak inheritancesler yazılamaz
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
