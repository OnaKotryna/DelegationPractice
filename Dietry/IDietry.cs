using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Dietry
{
    public interface IDietry
    {
        public bool IsEdible();
        public double CalculateWaterConsumption(int age, double exp);
    }
}
