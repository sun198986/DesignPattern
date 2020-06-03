using System;

namespace DecoretePattern
{
    public class ConcreteComponent:Component
    {
        public override void Operation()
        {
             Console.WriteLine("具体的实现对象");
        }
    }
}