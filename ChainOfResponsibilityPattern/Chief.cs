using System;

namespace ChainOfResponsibilityPattern
{
    public class Chief:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            if (context.Hour <= 36)
            {
                context.AuditResult = true;
                context.AuditRemark = "享受你的假期";
                Console.WriteLine("总监审批通过");

            }
            else
            {
                base.AuditNext(context);
            }
        }
    }
}