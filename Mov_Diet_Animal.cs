using Delegavimas.Dietry;
using Delegavimas.Movement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Mov_Diet_Animal : Animal, IMovement, IDietry
    {
        private MovementImpl mov;
        private DietryImpl diet;

        public Mov_Diet_Animal()
        {
            mov = new MovementImpl();
            diet = new DietryImpl();
        }

        public double CalculateWaterConsumption(int age, double exp)
        {
            return diet.CalculateWaterConsumption(age, exp);
        }

        public bool IsEdible()
        {
            return diet.IsEdible();
        }

        public void Stand()
        {
            mov.Stand();
        }

        public void Swing()
        {
            mov.Swing();
        }

        public void Walk()
        {
            mov.Walk();
        }
    }
}
