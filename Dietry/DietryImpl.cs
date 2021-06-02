using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Dietry
{
    public class DietryImpl : IDietry
    {
        public double CalculateWaterConsumption(int age, double exp)
        {
            double water = (age + exp) * 0.5;
            return water;
        }

        public bool IsEdible()
        {
            return false;
        }
    }
}
