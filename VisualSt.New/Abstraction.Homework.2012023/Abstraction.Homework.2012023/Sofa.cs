using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Homework._2012023
{
    internal class Sofa : Furniture
    {
        public double Height;


        public override double CheckField()
        {
            Field = Lengthh * Height;
            return Field;
        }

    }
}
