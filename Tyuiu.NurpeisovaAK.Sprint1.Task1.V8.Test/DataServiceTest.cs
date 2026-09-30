using Tyuiu.NurpeisovaAK.Sprint1.Task1.V8.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 1.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(Math.PI, res);
        }
    }
}
