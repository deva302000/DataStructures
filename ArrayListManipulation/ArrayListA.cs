using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListManipulation
{
    public partial class ArrayList: IEnumerable, IEnumerator
    {
        private int Position=-1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }   

        public bool MoveNext()
        {
            if(Position< _count-1)
            {
                ++Position;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            Position = -1;
        }

        public object Current
        {
            get {   return ArrayValue[Position]; }
        }
        
    }
}