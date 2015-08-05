using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbericSequenceCalculator.Models;
using System.Collections.Generic;

namespace NumbericSequenceCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSequence()
        {
            NumbericSequence ns = new NumbericSequence(5);
            List<string> actual = ns.GetSequence();
            List<string> expected = new List<string>();
            expected.Add("1");
            expected.Add("2");
            expected.Add("3");
            expected.Add("4");
            expected.Add("5");
            CollectionAssert.AreEqual(actual,expected);
        }
        [TestMethod]
        public void TestOddSequence()
        {
            NumbericSequence ns = new NumbericSequence(6);
            List<string> actual = ns.GetOddSequence();
            List<string> expected = new List<string>();
            expected.Add("1");
            expected.Add("3");
            expected.Add("5");
            expected.Add("6");
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestEvenSequence()
        {
            NumbericSequence ns = new NumbericSequence(6);
            List<string> actual = ns.GetEvenSequence();
            List<string> expected = new List<string>();
            expected.Add("2");
            expected.Add("4");
            expected.Add("6");
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestCEZSequence()
        {
            NumbericSequence ns = new NumbericSequence(16);
            List<string> actual = ns.GetCEZSequence();
            List<string> expected = new List<string>();
            expected.Add("1");
            expected.Add("2");
            expected.Add("C");
            expected.Add("4");
            expected.Add("E");
            expected.Add("C");
            expected.Add("7");
            expected.Add("8");
            expected.Add("C");
            expected.Add("E");
            expected.Add("11");
            expected.Add("C");
            expected.Add("13");
            expected.Add("14");
            expected.Add("Z");
            expected.Add("16");
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestFibonacciSequence()
        {
            NumbericSequence ns = new NumbericSequence(16);
            List<string> actual = ns.GetFibonacciSequence();
            List<string> expected = new List<string>();
            expected.Add("0");
            expected.Add("1");
            expected.Add("1");
            expected.Add("2");
            expected.Add("3");
            expected.Add("5");
            expected.Add("8");
            expected.Add("13");
            expected.Add("16");
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
