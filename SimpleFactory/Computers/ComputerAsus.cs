using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Computers
{
    public class ComputerAsus:Computer
    {
        public override string ProductComputer()
        {
            return "生产华硕电脑";
        }
    }
}
