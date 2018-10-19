using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    static class MathOperations
    {
        public static int GetMin(Password[] ArrayPass)
        {
            int min = ArrayPass[0].GetLength();
            for (int i = 0; i < ArrayPass.Length; i++)
            {
                if (ArrayPass[i].GetLength() < min)
                    min = ArrayPass[i].GetLength();
            }
            return min;
        }

        public static int GetMax(Password[] ArrayPass)
        {
            int max = 0;
            for (int i = 0; i < ArrayPass.Length; i++)
            {
                if (ArrayPass[i].GetLength() > max)
                    max = ArrayPass[i].GetLength();
            }
            return max;
        }

        public static int GetLength(Password[] ArrayPass)
        {
            return ArrayPass.Length;
        }

        public static bool RightLength(this Password pass)
        {
            if (pass.Pass.Length >= 6 && pass.Pass.Length <= 12)
                return true;
            else
                return false;
        }

        public static char MidSymbol(this Password pass)
        {
            char[] Password = pass.Pass.ToCharArray();
            char MS = Password[pass.Pass.Length / 2];
            return MS;
        }

    }
}
