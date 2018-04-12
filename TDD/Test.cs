﻿using System;
using Lab3TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class Test
    {
        private double[,] a = { { 1, 2, 3 }, { 2, 5, 6 }, { 4, 2, 7 } };
        private double[,] b = { { 5, 3, 1 }, { 2, 8, 0 }, { 3, 5, 4 } };

        [TestMethod]
        public void Test1_IsNotNullMathCalc()
        {
            MathCalc calc = new MathCalc();
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void Test2_CompareMatrix()
        {
            MathCalc calc = new MathCalc();
            bool rezult = calc.CompareMatrix(a, a);
            Assert.AreEqual(true, rezult);
        }

        [TestMethod]
        public void Test3_CompareMatrix()
        {
            MathCalc calc = new MathCalc();
            bool rezult = calc.CompareMatrix(a, b);
            Assert.AreEqual(false, rezult);
        }
    }
}
