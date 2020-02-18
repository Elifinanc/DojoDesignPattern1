using System;
using System.Collections.Generic;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    public class Manager : AbstractEmployee
    {
        

        public Manager(string name, float salary, List<AbstractEmployee> subordinates)
        {
            Name = name;
            Salary = salary;
            Subordinates = subordinates;
        }

    }
}
