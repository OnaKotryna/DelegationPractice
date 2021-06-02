using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Movement
{
    public class MovementImpl : IMovement
    {
        public void Stand()
        {
            Console.WriteLine("Standing.");
        }

        public void Swing()
        {
            Console.WriteLine("Swinging.");
        }

        public void Walk()
        {
            Console.WriteLine("Walking.");
        }
    }
}
