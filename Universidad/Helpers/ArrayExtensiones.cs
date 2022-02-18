using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class ArrayExtensiones
    {
        public void ArrayPush<T>(ref T[] table, object value)
        {
            Array.Resize(ref table, table.Length + 1); // Resizing the array for the cloned length (+-) (+1)
            table.SetValue(value, table.Length - 1); // Setting the value for the new element
        }
    }
}
