using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class DemoExtensionClass
    {
        public static void PrintListElement(this List<int> ints)
        { 
           if(ints != null)
            {
                foreach(int i in ints)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
