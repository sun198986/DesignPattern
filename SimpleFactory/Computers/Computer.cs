using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Computers
{
    public abstract class Computer
    {
        public virtual string ProductComputer() {
            return "生产电脑";
        }
    }
}
