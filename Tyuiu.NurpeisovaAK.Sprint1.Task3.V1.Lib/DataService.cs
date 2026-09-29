using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            return r * r * h * 3.14; 
        }
    }
}
