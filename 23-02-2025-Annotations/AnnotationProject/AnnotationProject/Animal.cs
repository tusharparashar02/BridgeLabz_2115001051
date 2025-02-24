using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Make Sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dogs Make a Sound");
        }
    }
    class MethodsUse
    {
        public static void Main(string[] args)
        {
            Dog dg = new Dog();
            dg.MakeSound();
        }

    }
}
