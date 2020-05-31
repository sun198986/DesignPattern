using System;
using SimpleFactory.Computers;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.Write("请输入要生产的电脑类型:");
                //string computerType = Console.ReadLine();
                Computer computer = ComputerFactory.CreateComputer((int)ComputerFactory.ComputerType.Asus);
                Console.WriteLine(computer.ProductComputer());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
