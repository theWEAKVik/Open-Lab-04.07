using NUnit.Framework;
using System;
using System.Linq;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] blyat = new char[original.Length];
            for (int i=0; i<original.Length; i++)
            {
                blyat[i] = original[i];
            }
            Array.Reverse(blyat);
            string hotovo = string.Join("", blyat);
            return hotovo;
        }
    }
}
