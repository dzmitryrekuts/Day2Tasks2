﻿using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidAlgoLogik.Tests
{
    [TestFixture]

    public class EuclidLogikTests
    {

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { -25, -1075, 3, 58, 25 }).Returns(1);
                yield return new TestCaseData(new int[] { -25, -1075, -3, -58, -25 }).Returns(1);
                yield return new TestCaseData(new int[] { 25, 1075, 3, 58, 25 }).Returns(1);
                yield return new TestCaseData(new int[] { 0, 0, 0, 0, 0 }).Returns(0);
                yield return new TestCaseData(new int[] { 0, 0, 33, 0, 0 }).Returns(33);
                yield return new TestCaseData(new int[] { 3, 333, 33, 27, 9 }).Returns(3);
                yield return new TestCaseData(new int[] { -3, -333, -33, -27, -9 }).Returns(3);
                yield return new TestCaseData(new int[] { 3, -333, 33, -27, -9 }).Returns(3);
            }
        }
        [Test, TestCaseSource(nameof(TestCases))]
        public double NewtonMetode_PositiveTests_Params(int [] arr)
        {
            var timer = new Stopwatch();
            return EuclidAlgo.EuclidAlgoMethod(timer,arr);
        }




        [TestCase(24, 12, Result = 12)]
        [TestCase(24, -12, Result = 12)]
        public int  Euclid_PositiveTests(int a, int b)
        {
            var timer = new Stopwatch();
            return EuclidAlgo.EuclidAlgoMethod(timer, a, b);
        }

        [TestCase(24, 12, 36, Result = 12)]
        [TestCase(24, -12, -36, Result = 12)]
        public int Euclid_PositiveTests_For3Args(int a, int b, int c)
        {
            var timer = new Stopwatch();
            return EuclidAlgo.EuclidAlgoMethod(timer, a, b, c);
        }


        [TestCase(12,12,12,12,12,12 , Result = 12)]
        public int Euclid_PositiveTests_Params(int a, int b, int c, int d, int e, int f)
        {
            var timer = new Stopwatch();
            return EuclidAlgo.EuclidAlgoMethod(timer, a, b, c, d, e, f);
        }




    }
}
