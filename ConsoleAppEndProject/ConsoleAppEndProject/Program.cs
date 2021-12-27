using Domain.Models;
using Service.Helpers;
using Service.Services;
using Service.Services.Interfaces;
using System;

namespace ConsoleAppEndProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();

            Helper.WriteToConsole(ConsoleColor.Blue, "Select options");

            while (true)
            {
                GetMenus();

                Console.ReadLine();

                Helper.WriteToConsole(ConsoleColor.Cyan, "Add company name: ");
                string companyName = Console.ReadLine();
                Helper.WriteToConsole(ConsoleColor.Cyan, "Add company address: ");
                string companyAddress = Console.ReadLine();

                Company company = new Company
                {
                    Name = companyName,
                    Address = companyAddress
                };
                companyService.Create(company);

                Helper.WriteToConsole(ConsoleColor.Green, $"{company.Id} - {company.Name} Company created!");
            }
        }
        private static void GetMenus()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company, 2 - Update Company, 3 - Delete Company, 4 - Get Company by id" +
                "5 - Get all Company by name, 6 - Get all Company, 7 - Create Employee, 8 - Update Employee, 9 - Delete Employee" +
                "10 - Get Employee by id, 11 - Get Employee by age, 12 - Get all Employee by Compnay id");
        }
    }
}
