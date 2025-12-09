using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PupovAA.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = stopValue - startValue + 1;
            result = new double[len];

            for (int j = 0; j < len; j++)
            {

                int i =startValue + j;
                    
                    if ((Math.Sin(i) + 2 == 0))
                    {
                        result[j] = 0;
                    }
                    else
                    {
                         double z = ((5 * i + 2.5) / (Math.Sin(i) + 2)) + 2 * i + 2;
                        result[j] = Math.Round(z, 2);
                    }
                        
                
                
            }
            return result;
            

        }
    }
}
