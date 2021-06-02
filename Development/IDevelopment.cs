using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Development
{
    public interface IDevelopment
    {
        public double PredictFullGrowthSize(int exp, int size);
        public double CalculateGrowthSpeed(int age, int size);
    }
}
