using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Check<Unknown>
    {
        public virtual bool ToCheck(Unknown var1, Unknown var2)
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
