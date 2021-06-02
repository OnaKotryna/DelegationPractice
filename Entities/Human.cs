using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Human
    {
        private int age = 2;
        private int birthSize = 40;
        private string country = "Lithuania";
        private string citizenship = "lithuanian";

        public int GetAge() {
            return age;
        }
        public int GetBirthSize()
        {
            return birthSize;
        }
        public string GetCountry()
        {
            return country;
        }

        public string GetCitizenship()
        {
            return citizenship;
        }
    }
}
