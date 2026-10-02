using Newtonsoft.Json.Linq;
using Tyuiu.NurpeisovaAK.Sprint1.Task6.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();
            
            string result = ds.SymbolCode("1");


            Assert.AreEqual("49", result);
            

        }
    }
}
