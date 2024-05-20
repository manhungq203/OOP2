using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300
{
    internal class Employee : Person
    {
        public int salary {  get; set; }

        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Salary : {salary} ");
        }
    }
}
