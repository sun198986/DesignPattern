using System;

namespace DecoretePattern.Demo
{
    public class Shirt:Finery
    {

        public override void Show()
        {
            base.Show();
            Console.WriteLine("T恤");
        }
    }
}