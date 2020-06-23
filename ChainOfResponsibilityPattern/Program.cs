using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ApplyContext context = new ApplyContext()
            {
                Id = 506,
                Name = "mark",
                Hour = 18,
                Description = "i want to go home",
                AuditResult = false,
                AuditRemark = ""
            };
            //面向过程
            //oop 考虑问题方式的变化 面相对象
            //if (context.Hour <= 8)
            //{
            //    Console.WriteLine("PM审批通过");
            //}
            //else if (context.Hour <= 16)
            //{
            //    Console.WriteLine("主管审批通过");
            //}
            //else
            //{
            //    Console.WriteLine("......");
            //}

            //AbstractAuditor pm = new PM()
            //{
            //    Name = "清风扰梦"
            //};


            //pm.Audit(context);
            //if (!context.AuditResult)
            //{
            //    AbstractAuditor charge = new Charge()
            //    {
            //        Name = "中国加油"
            //    };
            //    charge.Audit(context);
            //}

            //不具备拓展性
            // AbstractAuditor pm = new PM()
            // {
            //     Name = "清风扰梦"
            // };
            // pm.Audit(context);

            // Console.WriteLine("Hello World!");

            PM pm = new PM()
            {
                Name = "清风扰梦"
            };
            AbstractAuditor charge = new Charge()
            {
                Name = "中国加油"
            };
            AbstractAuditor manager = new Manager()
            {
                Name = "22"
            };
            AbstractAuditor chief = new Chief()
            {
                Name = "33"
            };
            AbstractAuditor ceo = new Ceo()
            {
                Name = "44"
            };
            pm.SetNext(charge);
            charge.SetNext(manager);
            manager.SetNext(chief);
            chief.SetNext(ceo);
            pm.Audit(context);
            Console.WriteLine("Hello World!");

        }
    }
}
