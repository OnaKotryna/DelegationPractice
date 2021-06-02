using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Development
{
    public class DevelopmentImpl : IDevelopment
    {
        public double CalculateGrowthSpeed(int age, int size)
        {
            double speed = size * 1.0 / age;
            return speed;
        }

        public double PredictFullGrowthSize(int exp, int size)
        {
            double growthSize = size + exp * 1.9;
            return growthSize;
        }
    }
}
