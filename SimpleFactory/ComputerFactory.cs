using SimpleFactory.Computers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class ComputerFactory
    {
        public static Computer CreateComputer(int computerType)
        {
            Computer computer = null;
            switch (computerType)
            {
                case (int)ComputerType.Hp:
                    computer = new ComputerHp();
                    break;
                case (int)ComputerType.Lenovo:
                    computer = new ComputerLenovo();
                    break;
                case (int)ComputerType.Asus:
                    computer = new ComputerAsus();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(computerType), computerType, null);
            }

            return computer;
        }
        public enum ComputerType
        {
            Hp=1,
            Lenovo=2,
            Asus=3
        }
    }
}
