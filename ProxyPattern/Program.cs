using System;
using ProxyPattern.StaticProxy;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态代理
            Console.WriteLine("静态代理:");
            SubjectProxy sp = new SubjectProxy();
            sp.Concrete();
            
            //动态代理
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("动态代理");



            Console.ReadLine();
        }
    }
}
