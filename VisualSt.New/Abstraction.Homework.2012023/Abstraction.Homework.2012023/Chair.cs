using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Homework._2012023
{
    internal class Chair : Furniture
    {
        public override double CheckField()
        {
            Field = Width * Lengthh;
            return Field;



        }



    }
}
