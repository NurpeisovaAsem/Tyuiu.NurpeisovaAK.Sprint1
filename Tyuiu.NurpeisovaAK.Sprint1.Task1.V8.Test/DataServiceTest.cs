using Tyuiu.NurpeisovaAK.Sprint1.Task1.V8.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = double.Pi;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(1, res);
        }
    }
}
