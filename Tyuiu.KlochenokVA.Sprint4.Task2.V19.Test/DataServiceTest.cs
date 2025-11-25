using Tyuiu.KlochenokVA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 6, 7, 8, 9, 5, 7, 4, 6, 8, 9, 5, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 45;

            Assert.AreEqual(wait, res);
        }
    }
}