using System;

namespace AdapterPattern
{
    public class RedisHelper
    {
         public RedisHelper()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void RedisQuery<T>()
        {
            Console.WriteLine($"{typeof(T).Name}查询Redis数据");
        }

        public void RedisAdd<T>()
        {
            Console.WriteLine($"{typeof(T).Name}添加Redis数据");
        }

        public void RedisUpdate<T>()
        {
            Console.WriteLine($"{typeof(T).Name}修改Redis数据");
        }

        public void RedisDelete<T>()
        {
            Console.WriteLine($"{typeof(T).Name}删除Redis数据");
        }
    }
}