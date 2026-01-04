using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal static class DgvExtentions
    {
        public static void BuildColumns<T>(this DataGridView dgv)
        {
            var properties=typeof(T).GetProperties();
            foreach (var p in properties) 
            {

            }
        }
    }
}
