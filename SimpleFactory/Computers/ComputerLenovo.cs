using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Computers
{
    /// <summary>
    /// 联想电脑
    /// </summary>
    public class ComputerLenovo:Computer
    {
        public override string ProductComputer()
        {
            return "生产联想电脑";
        }
    }
}
