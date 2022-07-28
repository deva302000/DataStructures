using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListManipulation
{
    public partial class ArrayList
    {
        

        
        public object [] ArrayValue {get; set;}
        private int _count;
        private int _capacity;
        public int Count { get{return _count;} }
        public int  Capacity { get{return _capacity;}  }

        public object this[int i]
        {
            get{return ArrayValue[i];}
            set{ArrayValue[i]=value;}
        }


        public ArrayList()
        {
            _count=0;
            _capacity=8;
            ArrayValue = new object[_capacity];
        }

        public ArrayList (int size)
        {
            _count=0;
            _capacity=8;
            ArrayValue = new object[_capacity];
        }

        public void Add(Object value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            ArrayValue[_count] = value   ;
            _count++;

        }

        public void GrowSize()
        {
            Object [] temp = new Object[_capacity*2];
                for(int i=0;i<_count;i++)
                {
                    temp[i]=ArrayValue[i];
                }
            ArrayValue=temp;
            _capacity=_capacity*2;
        }
    }
    }
