using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Animal
    {
        private string breed = "Dog";
        private double expectancy = 7.0;
        private int birthSize = 10;
        private double age = 2;

        public string GetBreed()
        {
            return breed;
        }

        public double GetLifeExpectancy()
        {
            return expectancy;
        }


    }
}
