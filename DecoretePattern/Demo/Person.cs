using System;

namespace DecoretePattern.Demo
{
    public class Person
    {
        private string _name;

        public Person()
        {
            
        }

        public Person(string name)
        {
            this._name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"{_name}的装扮:");
        }
    }
}