using System.Xml.Linq;

namespace NguyenManhHung_He172300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();

            employees.Add(new Employee("Nguyen Van A","Ha Noi", 1000));
            employees.Add(new Employee("Nguyen Van B", "Bac Ninh", 1400));
            employees.Add(new Employee("Nguyen Van C", "Hai Duong", 1500));
            employees.Add(new Employee("Nguyen Van D", "Ha Noi", 1600));
            employees.Add(new Employee("Nguyen Van E", "Ha Noi", 1700));

            customers.Add(new Customer("Nguyen Thi A","Ha Noi",3000));
            customers.Add(new Customer("Nguyen Thi B", "Ha Noi", 5000));
            customers.Add(new Customer("Nguyen Thi C", "Ha Noi", 4000));
            customers.Add(new Customer("Nguyen Thi D", "Ha Noi", 6000));

            // Nhan vien co luong cao nhat
            (employees.MaxBy(em => em.salary)as Employee).display();
            // khach hang co banlace thap nhat
            (customers.MinBy(cus => cus.balance) as Customer).display();

            string name = "nguyen";
            // tim nhanvien theo ten
            var em = from employee in employees
                     where employee.name.Contains(name, StringComparison.OrdinalIgnoreCase)
                     select employee;

            // Output the result
            foreach (var emp in em)
            {
                emp.display();
            }

        }
    }
}
