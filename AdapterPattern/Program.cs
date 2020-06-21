using System;
//适配器的核心 包一层
//没有什么技术问题是包一层不能解决的,如果有,就再包一层
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("************************");
                IHelper helper = new MySqlHelper();
                helper.Query<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Add<Program>();
            }
            {
                Console.WriteLine("************************");
                IHelper helper = new OracleHelper();
                helper.Query<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Add<Program>();
            }
            {
                Console.WriteLine("************************");
                IHelper helper = new SqlserverHelper();
                helper.Query<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Add<Program>();
            }
            {
                //引入第三方的redis,不适配
                Console.WriteLine("************************");
                IHelper helper = new RedisHelperInherit();//类适配器
                helper.Query<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Add<Program>();
            }
            {//组合优于继承
                Console.WriteLine("***************");
                Console.WriteLine("************************");
                IHelper helper = new RedisHelperCombination();//对象适配器
                helper.Query<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Add<Program>();
            }
            //都做到了适配,都能新旧适配起来
            //组合优于继承 1.继承是强侵入形的 会带过来父类的方法(有多余的东西)
            //            2.灵活性问题(组合是依赖抽象的,继承是依赖细节的)
            //应用总结:
            //属于不救模式,全新引入新的组件要用上的
            //不能在项目一开始设计的时候就搞适配器,徒增难度
            //时机选择
            

            Console.WriteLine("Hello World!");
        }
    }
}
