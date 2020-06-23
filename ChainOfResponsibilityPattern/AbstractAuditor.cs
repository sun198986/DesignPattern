namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractAuditor
    {
        public string Name { get; set; }

        public abstract void Audit(ApplyContext context);

        private AbstractAuditor _nextAuditor = null;
        public void SetNext(AbstractAuditor auditor)
        {
            this._nextAuditor = auditor;
        }

        protected void AuditNext(ApplyContext context)
        {
            this._nextAuditor?.Audit(context);
        }
    }
}