using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class AreaOfTriange
    {
        public static int Test(int parametar1, int parametar2)
        {
        return (parametar1 * parametar2) / 2;

        }

        public static int Test2(int houre)
        {
            return houre * 60;
        }

        public static bool Test3(int number) 
        {
            if (number <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Test4(string text) 
        {
            return $"something {text}";
        }

        public static bool Test5(int numberDiv5)
        {
            int numberDivBy5 = numberDiv5 % 5;


            if (numberDivBy5 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
