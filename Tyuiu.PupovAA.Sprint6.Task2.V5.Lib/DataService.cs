using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PupovAA.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = stopValue - startValue + 1;
            result = new double[len];

            for (int j = 0; j < len; j++)
            {

                int i = startValue + j;

                if ((Math.Sin(i) + 2 == 0))
                {
                    result[j] = 0;
                }
                else
                {
                    double z = ((2 * i -3 ) / (Math.Cos(i) - 2*i)) + 5 * i - 6;
                    result[j] = Math.Round(z, 2);
                }



            }
            return result;
        }
    }
}
