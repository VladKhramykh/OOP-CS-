using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    static class MathOperations
    {
        public static int GetMin(Password<int>[] ArrayPassInt, Password<string>[] ArrayPassString)
        {
            int minInt = ArrayPassInt[0].GetLength();
            for (int i = 0; i < ArrayPassInt.Length; i++)
            {
                if (ArrayPassInt[i].GetLength() < minInt)
                    minInt = ArrayPassInt[i].GetLength();
            }

            int minString = ArrayPassString[0].GetLength();
            for (int i = 0; i < ArrayPassString.Length; i++)
            {
                if (ArrayPassString[i].GetLength() < minString)
                    minString = ArrayPassString[i].GetLength();
            }

            if (minInt > minString)
                return minInt;

            return minString;

        }

        public static int GetMax(Password<int>[] ArrayPassInt, Password<string>[] ArrayPassString)
        {
            int maxInt = ArrayPassInt[0].GetLength();
            for (int i = 0; i < ArrayPassInt.Length; i++)
            {
                if (ArrayPassInt[i].GetLength() > maxInt)
                    maxInt = ArrayPassInt[i].GetLength();
            }

            int maxString = ArrayPassString[0].GetLength();
            for (int i = 0; i < ArrayPassString.Length; i++)
            {
                if (ArrayPassString[i].GetLength() > maxString)
                    maxString = ArrayPassString[i].GetLength();
            }

            if (maxString > maxInt)
                return maxString;

            return maxInt;
        }

        public static int GetLength(Password<int> [] ArrayPass)
        {
            return ArrayPass.Length;
        }

        public static int GetLength(Password<string>[] ArrayPass)
        {
            return ArrayPass.Length;
        }

        public static bool RightLength(this Password<int> pass)
        {
            if (pass.Pass.Length >= 6 && pass.Pass.Length <= 12)
                return true;
            else
                return false;
        }

        public static bool RightLength(this Password<string> pass)
        {
            if (pass.Pass.Length >= 6 && pass.Pass.Length <= 12)
                return true;
            else
                return false;
        }

        public static char MidSymbol(this Password<int> pass)
        {
            char[] Password = pass.Pass.ToCharArray();
            char MS = Password[pass.Pass.Length / 2];
            return MS;
        }

        public static char MidSymbol(this Password<string> pass)
        {
            char[] Password = pass.Pass.ToCharArray();
            char MS = Password[pass.Pass.Length / 2];
            return MS;
        }

    }
}
