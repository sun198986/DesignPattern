using System;

namespace AdapterPattern
{
    public class MySqlHelper:IHelper
    {
        public MySqlHelper()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void Query<T>()
        {
            Console.WriteLine($"{typeof(T)}查询数据");
        }

        public void Add<T>()
        {
            Console.WriteLine($"{typeof(T)}添加数据");
        }

        public void Update<T>()
        {
            Console.WriteLine($"{typeof(T)}修改数据");
        }

        public void Delete<T>()
        {
            Console.WriteLine($"{typeof(T)}删除数据");
        }
    }
}