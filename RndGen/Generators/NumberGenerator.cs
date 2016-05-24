using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndGen.Generators
{
    public class NumberGenerator
    {

        // int generator
        public static int[] GenerateNumbers (int limit, int number = 1)
        {
            int[] generatedNumbers = new int[number];
            Random rn = new Random();

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                generatedNumbers[i] = rn.Next(limit);
            }

            return generatedNumbers;
        }

        // double generator
        public static double[] GenerateNumbers(double upperLimit, int number = 1)
        {
            double[] generatedNumbers = new double[number];
            Random rn = new Random();

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                string num = rn.Next((int)upperLimit).ToString() + "." + rn.Next(9);
                generatedNumbers[i] = Convert.ToDouble(num);
            }
            return generatedNumbers;
        }
    }
}
