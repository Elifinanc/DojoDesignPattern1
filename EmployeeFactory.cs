using System;
using System.Collections.Generic;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    public abstract class EmployeeFactory
    {
        public static AbstractEmployee Create(string Type, float Salary, List<AbstractEmployee> manySubordinates=null)
        {
            if (manySubordinates != null)
            {
                AbstractEmployee newEmployee = new Manager(Type, Salary,manySubordinates);
                return newEmployee;
            }
            else
            {
                AbstractEmployee newEmployee = new Developer(Type, Salary);
                return newEmployee;
            }
        }

    }
}
