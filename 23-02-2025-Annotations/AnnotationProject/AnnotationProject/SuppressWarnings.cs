using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    internal class SuppressWarnings
    {
        #pragma warning disable CS8600 // Suppress warnings for nullable conversions

        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        #pragma warning restore CS8600 // Restore warnings
    }
}
