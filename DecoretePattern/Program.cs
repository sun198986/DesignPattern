using System;
using DecoretePattern.Decorator;

namespace DecoretePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            //第一次修饰
            component = new ConcreteDecoratorA(component);

            component = new ConcreteDecoratorB(component);

            component.Operation();
            Console.ReadLine();
        }
    }
}
