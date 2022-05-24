using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes
{
    internal class Ball
    {
      
        private int size;
        private int color;
        private int throwCount;

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if(size == 0 )
                throwCount++;
        }

        public int ThrowCount()
        {
            return throwCount;

        }
    }
}
