using System;

namespace AdapterPattern
{
    public class OracleHelper:IHelper
    {
        public OracleHelper()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void Query<T>()
        {
            Console.WriteLine($"{typeof(T).Name}查询Oracle数据");
        }

        public void Add<T>()
        {
            Console.WriteLine($"{typeof(T).Name}添加Oracle数据");
        }

        public void Update<T>()
        {
            Console.WriteLine($"{typeof(T).Name}修改Oracle数据");
        }

        public void Delete<T>()
        {
            Console.WriteLine($"{typeof(T).Name}删除Oracle数据");
        }
    }
}