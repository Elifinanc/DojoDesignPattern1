using System;
using System.Collections.Generic;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    public class Developer : AbstractEmployee
    {
        public Developer (string name, float salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
