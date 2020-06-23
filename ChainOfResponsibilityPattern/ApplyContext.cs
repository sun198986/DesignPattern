namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 请假审批
    /// </summary>
    public class ApplyContext
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Hour { get; set; }

        public string Description { get; set; }

        public bool AuditResult { get; set; }//审批结果

        public string AuditRemark { get; set; }//审批备注
    }
}