using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProject
{
    internal class LegacyAPI
    {
        [Obsolete("Use NewFeature instead.")]
        public void OldFeature()
        {
            Console.WriteLine("This is an old feature.");
        }

        public void NewFeature()
        {
            Console.WriteLine("This is a new feature.");
        }
    }
    class Legal
    {
        public static void Main(string[] args)
        {
            LegacyAPI api = new LegacyAPI();
            api.OldFeature();
            api.NewFeature();
        }

    }
}
