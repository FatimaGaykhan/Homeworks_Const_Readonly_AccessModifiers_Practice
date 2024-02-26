using System;
using HomeWorks_Const_Readonly_Access_Modifiers.Helpers.Constants;
using HomeWorks_Const_Readonly_Access_Modifiers.Models;
using HomeWorks_Const_Readonly_Access_Modifiers.Services;

namespace HomeWorks_Const_Readonly_Access_Modifiers.Controllers
{
	public class EmployeeController
	{
        private readonly EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }
        public void GetAll()
        {

            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname);
            }
        }

        public void GetAllByAge()
        {
            var employees = employeeService.GetAll();

            var result = employeeService.GetAllByAge(employees,30);

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname+" "+item.age);
            }
        }

        public void GetCountByAge()
        {

            Console.WriteLine("Add first age:");
            int firstAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Add last age:");
            int lastAge = int.Parse(Console.ReadLine());

            var employees = employeeService.GetAll();

            int count = employeeService.GetCountByAge(employees, firstAge,lastAge);

            Console.WriteLine($"Count:{count}");
        }

        public void GetSumOfAges()
        {
            var employees = employeeService.GetAll();
            int result = employeeService.SumOfAges(employees);
            Console.WriteLine(result);
        }
        public void GetAllByCheckedEmails()
        {
            Console.WriteLine("Add string:");
            string str = Console.ReadLine();

            Employee [] employees = employeeService.GetAll();

            var checkedEmails = employeeService.GetAllByCheckedEmail(employees,str);

            if (checkedEmails.Count()==0)
            {
                Console.WriteLine( ResponseMessages.NotFound );
                return;
            }

            foreach (var item in checkedEmails)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.email);
            }
        }
    }
   
}

