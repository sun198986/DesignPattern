using System;

namespace ChainOfResponsibilityPattern
{
    public class Manager:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            if (context.Hour <= 24)
            {
                context.AuditResult = true;
                context.AuditRemark = "享受你的假期";
                Console.WriteLine("经理批通过");

            }
            else
            {
                //AbstractAuditor chief = new Chief()
                //{
                //    Name = "总监"
                //};
                //chief.Audit(context);
                base.AuditNext(context);
            }
        }
    }
}