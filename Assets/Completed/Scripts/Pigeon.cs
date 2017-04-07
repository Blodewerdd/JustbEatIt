using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Completed;

namespace Assets.Completed.Scripts
{
    class Pigeon : MovingObject
    {
        protected override void OnCantMove<T>(T component)
        {
            throw new NotImplementedException();
        }
    }
}
