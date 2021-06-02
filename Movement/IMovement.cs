using System;
using System.Collections.Generic;
using System.Text;

namespace Delegavimas.Movement
{
    public interface IMovement
    {
        public void Walk();
        public void Stand();
        public void Swing();
    }
}
