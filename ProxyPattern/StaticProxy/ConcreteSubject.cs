using System;

namespace ProxyPattern.StaticProxy
{
    public class ConcreteSubject:Subject

    {
        public override void Concrete()
        {
            Console.WriteLine("具体业务的实现");
        }
    }
}