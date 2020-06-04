using System;

namespace ProxyPattern.StaticProxy
{
    public class SubjectProxy:Subject
    {
        private Subject _subject = null;

        public SubjectProxy()
        {
            _subject = new ConcreteSubject();
        }

        public override void Concrete()
        {
            this.Before();
            _subject.Concrete();
            this.After();
        }

        public void Before()
        {
            Console.WriteLine("具体方法调用之前");
        }

        public void After()
        {
            Console.WriteLine("具体方法调用之后");
        }
    }
}