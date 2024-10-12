using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GCDAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wpf_App_For_ConsoleApp1
{
    /// <summary>
    /// Class for testing
    /// </summary>
    [TestClass]
    public class GCDAlgorithmsTest
    {
        /// <summary>
        /// Testing
        /// </summary>
        [TestMethod]
        public void FindGCDEuclidTest()
        {
            var dict = new Dictionary<(int, int), int>()
            {
                {(12,4), 4},
                {(9,7), 1},
                {(12,8), 4},
                {(12,9), 3},
            };
            foreach (var key in dict.Keys)
            {
                Assert.AreEqual(FindGCDEuclid(key.Item1, key.Item2), dict[key]);
            }
        }
    }
}
