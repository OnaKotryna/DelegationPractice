using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Plant
    {
        private string species = "Cactus";
        private double waterNeed = 0.2;

        public string GetSpecies() {
            return species;
        }
        public double GetWaterNeed() {
            return waterNeed;
        }
    }
}
