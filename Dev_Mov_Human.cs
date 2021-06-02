using Delegavimas.Development;
using Delegavimas.Movement;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas
{
    class Dev_Mov_Human : Human, IDevelopment, IMovement
    {
        private DevelopmentImpl dev;
        private MovementImpl mov;
        public Dev_Mov_Human()
        {
            dev = new DevelopmentImpl();
            mov = new MovementImpl();
        }

        public double CalculateGrowthSpeed(int age, int size)
        {
            return dev.CalculateGrowthSpeed(age, size);
        }

        public double PredictFullGrowthSize(int exp, int size)
        {
            return dev.PredictFullGrowthSize(exp, size);
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
