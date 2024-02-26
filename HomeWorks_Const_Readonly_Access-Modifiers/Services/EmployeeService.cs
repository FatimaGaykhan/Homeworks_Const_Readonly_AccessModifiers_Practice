using System;
using HomeWorks_Const_Readonly_Access_Modifiers.Models;

namespace HomeWorks_Const_Readonly_Access_Modifiers.Services
{
	public class EmployeeService:Employee
	{
		public Employee[] GetAll()
		{
            Employee employee1 = new()
            {
                id = 1,
                name = "Fatima",
                surname = "Gaykhanova",
                address = "Azerbaijan,Baku",
                email = "fatimaeg@code.edu.az",
                age = 22
            };
            Employee employee2 = new()
            {
                id = 2,
                name = "Sadigkhan",
                surname = "Gaykhanov",
                address = "Azerbaijan,Baku",
                email = "sadigkhaneg@code.edu.az",
                age = 26
            };

            Employee employee3 = new()
            {
                id = 3,
                name = "Inji",
                surname = "Gaykhanova",
                address = "Azerbaijan,Baku",
                email = "injieg@code.edu.az",
                age = 27

            };
            Employee employee4 = new()
            {
                id = 4,
                name = "Sharif",
                surname = "Gaykhanov",
                address = "Azerbaijan,Baku",
                email = "sharifeg@code.edu.az",
                age = 32

            };
            Employee employee5 = new()
            {
                id = 5,
                name = "Gunel",
                surname = "Hasanova",
                address = "United Kingdom,London",
                email = "gunelhasanova@gmail.com",
                age = 32

            };
            Employee employee6 = new()
            {
                id = 6,
                name = "Fatima",
                surname = "Gaykhanova",
                address = "Azerbaijan,Baku",
                email = "fatimaeg@code.edu.az",
                age = 20
            };

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5, employee6 };
            return employees;
        }

        public Employee[] GetAllByAge(Employee[] employees,int age) => employees.Where(m => m.age > age).ToArray();

        public int GetCountByAge(Employee [] employees, int firstAge,int lastAge)
        {
            return employees.Where(m => m.age > firstAge && m.age < lastAge).Count();
        }

        public int SumOfAges(Employee[] employees) => employees.Sum(m => m.age);

        public Employee[] GetAllByCheckedEmail(Employee[] employees,string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();
        } 
       

    }
}

