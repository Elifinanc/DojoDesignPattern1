using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    [TestFixture]
    class FactoryTest
    {
        [Test]
        public void TestManagerCreation()
        {
            List<AbstractEmployee> subordinates = new List<AbstractEmployee>
            {
                new Developer("Paul", 25000)
            };

            AbstractEmployee manager = EmployeeFactory.Create("Manager", 100000, subordinates);

            String typeName = typeof(Manager).ToString();
            Assert.AreEqual(typeName, manager.GetType().ToString());
        }

        [Test]
        public void TestDeveloperCreation()
        {
            AbstractEmployee developer = EmployeeFactory.Create("Developer", 40000);

            String typeName = typeof(Developer).ToString();
            Assert.AreEqual(typeName, developer.GetType().ToString());
        }
    }
    
    [TestFixture]
    class CompositeTest
    {
        private Manager _boss, _lowLevelManager;
        private List<AbstractEmployee> _managerSubordinates;
        
        [SetUp]
        public void SetUp()
        {
            _managerSubordinates = new List<AbstractEmployee>
            {
                new Developer("Robert", 35000),
                new Developer("John", 40000),
                new Developer("Bill", 65000)
            };
            _lowLevelManager = new Manager("Moron", 75000, _managerSubordinates);
            _boss = new Manager("Asshole", 100000, new List<AbstractEmployee> { _lowLevelManager });
        }

        [Test]
        public void TestAllSubordinatesSalary()
        {

            IEnumerable<float> salaries = _boss.AllSubordinates.Select(employee => employee.Salary);
            float totalTeamSalary = salaries.Aggregate((x, y) => x + y);

            Assert.AreEqual(75000 + 35000 + 40000 + 65000, totalTeamSalary);
        }

        [Test]
        public void TestAllSubordinatesSalary50000()
        {

            IEnumerable<AbstractEmployee> employee = _boss.AllSubordinates.Where(employee => employee.Salary >50000); //selectionne les employés qui ont un salair supérieur à  50000
            IEnumerable<float> salaries = employee.Select(employee => employee.Salary); //selectionne les salaires des employés qui ont été sélectionné plus haut
            float totalTeamSalary = salaries.Aggregate((x, y) => x + y);

            Assert.AreEqual(75000 + 65000, totalTeamSalary);
        }
    }
}
