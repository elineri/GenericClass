using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Class2<Unknown> : Check<Unknown>
    {
        public override bool ToCheck(Unknown var1, Unknown var2)
        {
            if (var1.Equals(var2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
