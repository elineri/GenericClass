using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class Check<Unknown>
    {
        public void ToCheck(Unknown var1, Unknown var2)
        {
            var1.Equals(var2);
        }
    }
}
