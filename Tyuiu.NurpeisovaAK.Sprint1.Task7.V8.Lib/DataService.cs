using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            double cosx = Math.Cos(x);
            double logx = Math.Log(x);
            double res = Math.Round(x * logx + (y / (cosx - (x / 3))),3);
            return res;
        }
    }
}
