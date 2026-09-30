using Tyuiu.NurpeisovaAK.Sprint1.Task4.V17.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 50;
            double y = 3;
            double wait = 0.169;
            var res = Math.Round(ds.Calculate(x, y),3);
            Assert.AreEqual(wait, res);
        }
    }
}
