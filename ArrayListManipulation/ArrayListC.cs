using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListManipulation
{
    public partial class ArrayList
    {
         public void Insert(int position, Object value)
        {
            Object [] temp = new Object[_capacity];
            for(int i=0;i<=_count ;i++)
            {
                if(i<position)
                {
                    temp[i]=ArrayValue[i];
                }
                if(i==position)
                {
                    temp[i]=value;
                }
                if(i>position)
                {
                    temp[i]=ArrayValue[i-1];
                }
            }
            ArrayValue=temp;
            
        }

         public void Remove(int position)
        {
            Object [] temp=new Object[_capacity];
            if(position<_count)
            {
                for(int i=0;i<=_count;i++)
                {
                if(i<position)
                {
                    temp[i]=ArrayValue[i];
                }
                if(i>position)
                {
                    temp[i-1]=ArrayValue[i];
                }
            }
            ArrayValue=temp;
            //--_count;
            }

        }
    }
}