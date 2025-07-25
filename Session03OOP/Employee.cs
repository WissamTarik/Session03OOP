using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Session03OOP.Interface_Ex02
    {
        class EmployeeComparerSalary : IComparer
        {
            public int Compare(object? x, object? y)
            {
                Employee X=(Employee)x;
                Employee Y=(Employee)y;
                if (X.Salary > Y.Salary) return 1;
                if (X.Salary < Y.Salary) return -1;
                else return 0;
                
            }
        }

        class EmployeeComparerNameLength : IComparer
        {
            public int Compare(object? x, object? y)
            {
                Employee X = (Employee)x;
                Employee Y = (Employee)y;
                if (X.Name.Length > Y.Name.Length) return 1;
                if (X.Name.Length < Y.Name.Length) return -1;
                else return 0;
            }
        }
        internal class Employee : IComparable
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { set; get; }

            //Copy constructor
            public Employee()
            {

            }
            public Employee(Employee employee)
            {
                this.Id = employee.Id;
                this.Name = employee.Name;
                this.Salary = employee.Salary;
                this.Age = employee.Age;


            }
            public object Clone()
            {
                return new Employee(this);
                //return new Employee() {Id= this.Id,Name=this.Name,Age=this.Age,Salary=this.Salary};
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name :{Name} , Age: {Age} , Salary: {Salary}"
                ;
            }

            public int CompareTo(object? obj)
            {
                //Employee employee = (Employee)obj
                Employee e = (Employee)obj;
                //if (this.Age > employee.Age) return 12;
                //else if (this.Age < employee.Age) return -12;
                //else return 0;
                //return this.Age.CompareTo(employee.Age);
                return this.Name.Length.CompareTo(e.Name.Length);
            }
        }
    }

}
