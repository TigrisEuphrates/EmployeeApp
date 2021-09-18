using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    readonly struct User
    {
        public string Name { get; } // указывать readonly необязательно
        public int Age { get; } // свойство только для чтения
        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine(u.Name + " " + u.Age);
            User s = new User("Dredd", 23);
            Console.WriteLine(s.Name + " " + s.Age);
        }
    }
}
