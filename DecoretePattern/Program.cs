using System;
using DecoretePattern.Decorator;
using DecoretePattern.Demo;

namespace DecoretePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            //第一次修饰
            component = new ConcreteDecoratorA(component);
            //第二次装饰
            component = new ConcreteDecoratorB(component);

            component.Operation();

            //Person p = new Person("sun");
            //Shirt t  = new Shirt();
            //t.Decorate(p);
            //t.Show();
            Console.ReadLine();
        }
    }
}
