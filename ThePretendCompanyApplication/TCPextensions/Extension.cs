using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPextensions
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> filetedList = new List<T>();

            foreach (T record in records)
            {
                if (func(record))
                    filetedList.Add(record);
            }
            return filetedList;
        }
    }
}
