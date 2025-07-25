using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03OOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Session03OOP.Interface_Ex02
    {
        internal class Employee
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
        }
    }

}
