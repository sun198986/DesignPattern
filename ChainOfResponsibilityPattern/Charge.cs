using System;

namespace ChainOfResponsibilityPattern
{
    public class Charge:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            if (context.Hour <= 16)
            {
                context.AuditResult = true;
                context.AuditRemark = "享受你的假期";
                Console.WriteLine("主管审批通过");

            }
            else
            {
                //AbstractAuditor manager = new Manager()
                //{
                //    Name = "经理"
                //};
                //manager.Audit(context);
                base.AuditNext(context);
            }
        }
    }
}