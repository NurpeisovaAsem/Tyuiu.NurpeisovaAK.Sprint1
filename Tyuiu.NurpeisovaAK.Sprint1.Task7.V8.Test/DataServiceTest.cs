using Tyuiu.NurpeisovaAK.Sprint1.Task7.V8.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 40;
            double y = 20;
            double wait = 146.127;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);
        }
    }
}
