using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GCDAlgorithms;

namespace Tests
{
    [TestClass()]
    public class GCDAlgorithmsTests
    {
        [TestMethod()]
        public void FindGCDEuclidTest1()
        {
            // тестовый словарь
            var dict = new Dictionary<(int, int), int>()
            {
                {(0,0), 0},
                {(0,10), 10},
                {(25,10), 5},
                {(25,100), 25},
                {(26,100), 2},
                {(27,100), 1},
            };
            // делаем проверку
            foreach (var key in dict.Keys)
            {
                Assert.AreEqual(FindGCDEuclid(key.Item1, key.Item2), dict[key]);
            }
        }
        [TestMethod()]
        public void FindGCDEuclidTest2()
        {
            // тестовый словарь
            var dict = new Dictionary<List<int>, int>()
            {
                {new List<int> {2806, 345, 0, 0, 0}, 23},
                {new List<int> {0, 0, 0, 0, 0}, 0},
                {new List<int> {0, 0, 0, 0, 1}, 1},
                {new List<int> {12, 24, 36, 48, 60}, 12},
                {new List<int> {13, 24, 36, 48, 60}, 1},
                {new List<int> {14, 24, 36, 48, 60}, 2},
                {new List<int> {15, 24, 36, 48, 60}, 3},
                {new List<int> {16, 24, 36, 48, 60}, 4},
                {new List<int> {0, 24, 36, 48, 60}, 12}
            };
            // делаем проверку
            foreach (var key in dict.Keys)
            {
                Assert.AreEqual(FindGCDEuclid(key.ToArray()), dict[key]);
            }
        }
        [TestMethod()]
        public void FindGCDSteinTest()
        {
            // тестовый словарь
            var dict = new Dictionary<List<int>, int>()
            {
                {new List<int> {2806, 345, 0, 0, 0}, 23},
                {new List<int> {0, 0, 0, 0, 0}, 0},
                {new List<int> {0, 0, 0, 0, 1}, 1},
                {new List<int> {12, 24, 36, 48, 60}, 12},
                {new List<int> {13, 24, 36, 48, 60}, 1},
                {new List<int> {14, 24, 36, 48, 60}, 2},
                {new List<int> {15, 24, 36, 48, 60}, 3},
                {new List<int> {16, 24, 36, 48, 60}, 4},
                {new List<int> {0, 24, 36, 48, 60}, 12}
            };
            // делаем проверку
            foreach (var key in dict.Keys)
            {
                Assert.AreEqual(FindGCDStein(key.ToArray()), dict[key]);
            }
        }
    }
}