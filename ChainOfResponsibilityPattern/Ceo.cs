using System;

namespace ChainOfResponsibilityPattern
{
    public class Ceo: AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            if (context.Hour <= 36)
            {
                context.AuditResult = true;
                context.AuditRemark = "享受你的假期";
                Console.WriteLine("ceo审批通过");

            }
            else
            {
                Console.WriteLine("审批不通过");
            }
        }
    }
}