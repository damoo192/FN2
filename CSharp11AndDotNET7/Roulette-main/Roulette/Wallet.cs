using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Wallet
    {
        public int Value { get; set; }

        public Wallet(int value)
        {
            Value = value;
        }

        public void removeValue(int value)
        {
            Value -= value;
        }

        public void addValue(int value)
        {
            Value += value;
        }

        public int getValue()
        {
            return Value;
        }

        public override string? ToString()
        {
            return Value.ToString();
        }
    }
}
