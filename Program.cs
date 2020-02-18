using System;
using System.Collections.Generic;
using System.Linq;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractEmployee> managerSubordinates = new List<AbstractEmployee>
            {
                new Developer("Robert", 35000),
                new Developer("John", 40000),
                new Developer("Bill", 65000)
            };

            Manager lowLevelManager = new Manager("Moron", 75000, managerSubordinates);
            Manager boss = new Manager("Asshole", 100000, new List<AbstractEmployee> { lowLevelManager });

            IEnumerable<float> salaries = boss.AllSubordinates.Select(employee => employee.Salary);
            float totalTeamSalary = salaries.Aggregate((x, y) => x + y);
        }

    }
}
