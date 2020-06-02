using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonSort personSort = new PersonSort();
            for (int i = 0; i < 10; i++)
            {
                Random ran = new Random();
                int randKey = ran.Next(100, 999);
                PersonInfo p = new PersonInfo()
                {
                    Name = "sun"+ randKey,
                    Age = i,
                    Email = $"{randKey}3348328@qq.com",
                    Phone = randKey.ToString()
                };
                personSort.Add(p);
            }

            personSort.Display();
            personSort.SetPersonSortList(new NameSort());
            personSort.Sort();
            personSort.Display();
            Console.ReadKey();
        }
    }
}
