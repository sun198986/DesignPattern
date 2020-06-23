using System;

namespace ChainOfResponsibilityPattern
{
    public class PM:AbstractAuditor
    {
        //private AbstractAuditor _nextAuditor = null;
        //public void SetNext(AbstractAuditor auditor){
        //    this._nextAuditor = auditor;
        //}
        public override void Audit(ApplyContext context)
        {
            
            if (context.Hour <= 8)
            {
                context.AuditResult = true;
                context.AuditRemark = "享受你的假期";
                Console.WriteLine("PM审批通过");
            }
            else
            {
                // AbstractAuditor charge = new Charge()
                // {
                //     Name = "中国加油"
                // };
                // charge.Audit(context);
                //_nextAuditor?.Audit(context);
                base.AuditNext(context);
            }
        }
    }
}