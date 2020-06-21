using System;

namespace AdapterPattern
{
    public class RedisHelperCombination:IHelper
    {
        //内置字段直接初始化--构造函数注入/方法注入  内部组合
        private RedisHelper _redisHelper = new RedisHelper();
         public RedisHelperCombination()
        {
            Console.WriteLine($"构造函数helper");
        }

        public void Query<T>()
        {
            _redisHelper.RedisQuery<T>();
        }

        public void Add<T>()
        {
           _redisHelper.RedisAdd<T>();
        }

        public void Update<T>()
        {
           _redisHelper.RedisUpdate<T>();
        }

        public void Delete<T>()
        {
            _redisHelper.RedisDelete<T>();
        }
    }
}