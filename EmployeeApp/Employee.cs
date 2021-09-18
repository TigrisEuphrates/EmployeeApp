using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        public string GetName()
        {
            return empName;
        }

        public void SetName(string name)
        {
            if (name.Length>15)
            {
                Console.WriteLine("Error.");
            }
            else
            {
                empName = name;
            }
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}
