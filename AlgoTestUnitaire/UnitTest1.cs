using AlgoLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlgoLibrary.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void TriParFusion()
        {
            //List<int> val = new List<int>() { 5, 6, 9, 8, 7, 2, 3, 20, 4, 12, 1, 16 };

            List<int> val = new List<int>() { 5, 1, 9, 8, 7, 2, 3, 20, 4, 12, 18, 16 };
            AlgoExample.TriParInsertion(val);

            foreach (var item in val)
            {
                Console.WriteLine(item);
            }
        }
    }
}