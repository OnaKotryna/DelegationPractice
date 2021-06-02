using Delegavimas.Development;
using Delegavimas.Dietry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Dev_Diet_Plant : Plant, IDevelopment, IDietry
    {
        private DevelopmentImpl dev;
        private DietryImpl diet;
        public Dev_Diet_Plant()
        {
            dev = new DevelopmentImpl();
            diet = new DietryImpl();
        }
        public double CalculateGrowthSpeed(int age, int size)
        {
            return dev.CalculateGrowthSpeed(age, size);
        }

        public double CalculateWaterConsumption(int age, double exp)
        {
            return diet.CalculateWaterConsumption(age, exp);
        }

        public bool IsEdible()
        {
            return diet.IsEdible();
        }

        public double PredictFullGrowthSize(int exp, int size)
        {
            return dev.PredictFullGrowthSize(exp, size);
        }
    }
}
