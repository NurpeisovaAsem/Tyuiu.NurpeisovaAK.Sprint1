using Tyuiu.NurpeisovaAK.Sprint1.Task5.V2.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 40;
            DataService ds = new DataService();
            int res = ds.FahrenheitToСelsius(temp);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
