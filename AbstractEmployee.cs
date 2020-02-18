using System;
using System.Collections.Generic;

namespace S10___DOJO_1___Design_Pattern_TDD
{
    public abstract class AbstractEmployee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public List<AbstractEmployee> Subordinates = new List<AbstractEmployee>();
        public List<AbstractEmployee> AllSubordinates
        {
            get
            {
                List<AbstractEmployee> subordinates = new List<AbstractEmployee>();

                foreach (AbstractEmployee employee in Subordinates)
                {
                    subordinates.Add(employee);
                    subordinates.AddRange(employee.AllSubordinates);
                }
                
                return subordinates;
            }
        }


    }
}