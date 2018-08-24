using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public abstract class CBase
        {
            public abstract void Show();
        }

        public class C<T> : CBase
        {
            public override void Show()
            {
                                
            }
        }        
    }
}
