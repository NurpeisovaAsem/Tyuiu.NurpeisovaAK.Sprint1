using Tyuiu.NurpeisovaAK.Sprint1.Task3.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double wait = 12*Math.PI;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
