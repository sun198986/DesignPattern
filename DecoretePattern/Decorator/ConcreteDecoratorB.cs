using System;

namespace DecoretePattern.Decorator
{
    public class ConcreteDecoratorB:Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {

        }

        private void AttachBehavior()
        {
            Console.WriteLine("附加的行为B");
        }

        public override void Operation()
        {
            base.Operation();
            this.AttachBehavior();
        }
    }
}