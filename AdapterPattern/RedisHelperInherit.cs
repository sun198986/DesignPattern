using System;

namespace AdapterPattern
{
    public class RedisHelperInherit:RedisHelper, IHelper
    {
        //外部继承
         public RedisHelperInherit()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void Query<T>()
        {
            base.RedisQuery<T>();
        }

        public void Add<T>()
        {
           base.RedisAdd<T>();
        }

        public void Update<T>()
        {
           base.RedisUpdate<T>();
        }

        public void Delete<T>()
        {
            base.RedisDelete<T>();
        }
    }
}