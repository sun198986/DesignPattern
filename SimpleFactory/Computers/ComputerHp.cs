using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Computers
{
    public class ComputerHp:Computer
    {
        public override string ProductComputer()
        {
            return "生产惠普电脑";
        }
    }
}
