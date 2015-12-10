using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EuclidAlgoLogik
{
    public class EuclidAlgo
    {

        public static int EuclidAlgoMethod(Stopwatch timer, int a, int b)
        {
            if (a==0||b==0)
            {
                throw new ArgumentException();
            }

            timer.Start();
            a = Math.Abs(a);
            b = Math.Abs(b);
            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            timer.Stop();
            return a;

        }

        public static int EuclidAlgoMethod(Stopwatch timer, int a, int b, int c)
        {

            return EuclidAlgoMethod(timer, EuclidAlgoMethod(timer, a, b), c);

        }

        public static int EuclidAlgoMethod(Stopwatch timer, params int[] arr)
        {
            int temp = EuclidAlgo.EuclidAlgoMethod(timer, arr[0], arr[1]);

            for (int i = 2; i < arr.Length; i++)
            {
                temp = EuclidAlgo.EuclidAlgoMethod(timer, temp, arr[i]);
            }


            return temp;

        }
    }
}
