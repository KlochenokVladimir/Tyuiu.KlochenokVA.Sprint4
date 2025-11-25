using Tyuiu.KlochenokVA.Sprint4.Task6.V21.Lib;

namespace Tyuiu.KlochenokVA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var socialNetworks = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(socialNetworks);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}