using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(" -> ");

            var companies = new Dictionary<string, List<string>>();

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeID = input[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeID))
                    {
                        companies[companyName].Add(employeeID);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeID);
                }

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
