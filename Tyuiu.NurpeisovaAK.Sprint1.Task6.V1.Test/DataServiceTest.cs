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
            string kod = "1";
            DataService ds = new DataService();
            string res = ds.SymbolCode(kod);
            
        }
    }
}
