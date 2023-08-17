using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithObjects
{
    partial class Program
    {
        static void SectionTitle(string title)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("*");
            WriteLine($"* {title}");
            WriteLine("*");
            ForegroundColor = previousColor;
        }
    }
}
