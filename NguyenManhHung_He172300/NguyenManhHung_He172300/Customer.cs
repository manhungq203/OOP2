using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300
{
    internal class Customer : Person
    {
        public int balance {  get; set; }

        public Customer(string name, string address, int balance) : base(name, address)
        {
            this.balance = balance;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Balance : {balance}");
        }
    }
}
