using Tyuiu.NurpeisovaAK.Sprint1.Task2.V6.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2300;
            var res = Math.Round(ds.ConvertMToKm(x), 3);
            Assert.AreEqual(2.300, res);
        }
    }
}
