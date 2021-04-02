using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace lab_basics
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1_1()
        {
            var input = new List<object> {1, 2 ,'a', "iasa", 0, 15};
            var output = Functions.GetIntegersFromList(input);
            var expected = new List<int> {1, 2, 0, 15};
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test1_2()
        {
            var input = new List<object> {'1', "1a"};
            var output = Functions.GetIntegersFromList(input);
            var expected = new List<int> { };
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test2_1()
        {
            string output = Functions.first_non_repeating_letter("sTreSs");
            string expected = "T";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test2_2()
        {
            string output = Functions.first_non_repeating_letter("aaBBcC");
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test3_1()
        {
            int output = Functions.DigitalRoot(123);
            int expected = 6;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test3_2()
        {
            int output = Functions.DigitalRoot(834952);
            int expected = 4;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test4_1()
        {
            int output = Functions.CountPairs(new int[]{1, 3, 6, 2, 2, 0, 4, 5}, 5);
            int expected = 4;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test4_2()
        {
            int output = Functions.CountPairs(new int[]{1, 3, 3, 3}, 4);
            int expected = 3;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test5_1()
        {
            string output = Functions.SortFriends("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test5_2()
        {
            string output = Functions.SortFriends("Maryna:Gnomenko;Maryna:Gnomenko;Ganna:Masher;Alex:Alexandrov");
            string expected = "(ALEXANDROV, ALEX)(GNOMENKO, MARYNA)(GNOMENKO, MARYNA)(MASHER, GANNA)";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test6_1()
        {
            int output = Functions.NextBiggerNumber(2021);
            int expected = 2102;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test6_2()
        {
            int output = Functions.NextBiggerNumber(111);
            int expected = -1;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test7_1()
        {
            string output = Functions.NumToIpv4(2149583361);
            string expected = "128.32.10.1";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test7_2()
        {
            string output = Functions.NumToIpv4(11);
            string expected = "0.0.0.11";
            Assert.AreEqual(expected, output);
        }
    }
}