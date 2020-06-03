using System;
using System.Net.NetworkInformation;

namespace DecoretePattern.Decorator
{
    public class ConcreteDecoratorA:Decorator
    {
        public ConcreteDecoratorA(Component component):base(component)
        {
            
        }

        private void AttachBehavior()
        {
            Console.WriteLine("附加的行为A");
        }

        public override void Operation()
        {
            base.Operation();
            this.AttachBehavior();
        }
    }
}