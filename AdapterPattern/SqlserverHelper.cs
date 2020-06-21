using System;

namespace AdapterPattern
{
    public class SqlserverHelper:IHelper
    {
        public SqlserverHelper()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void Query<T>()
        {
            Console.WriteLine($"{typeof(T)}查询Sqlserver数据");
        }

        public void Add<T>()
        {
            Console.WriteLine($"{typeof(T)}添加Sqlserver数据");
        }

        public void Update<T>()
        {
            Console.WriteLine($"{typeof(T)}修改Sqlserver数据");
        }

        public void Delete<T>()
        {
            Console.WriteLine($"{typeof(T)}删除Sqlserver数据");
        }
    }
}