using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300
{
    abstract class Person
    {
        public string name {  get; set; }
        public string address { get; set; }

        public Person(string name, string address)
        {
            this.name = name;   
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine($" Name : {name} Address : {address}");
        }
    }
}
