using Tyuiu.KlochenokVA.Sprint4.Task1.V28.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 75;

            Assert.AreEqual(wait, res);
        }
    }
}
