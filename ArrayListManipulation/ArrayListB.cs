
using System.Collections;

using System.Threading.Tasks;

namespace ArrayListManipulation
{
   
        public  partial class ArrayList
    {
        public void Bubble()
        {
            object temp;
            for(int j=0;j<=_count-2;j++)
            {
                for(int i=0;i<=_count-2;i++)
                {
                    if(CompareGreater(ArrayValue[i],ArrayValue[i+1]))
                    {
                        temp=ArrayValue[i+1];
                        ArrayValue[i+1] = ArrayValue[i];
                        ArrayValue[i]=temp;
                    }
                }
            }
             bool CompareGreater(object value1,object value2)

             {

            var result=Comparer.Default.Compare(value1,value2);

            // value1 is less, then return -1,value1 is greater, then return 1,equal then return 0

            if(result>=0)

            {

                return true;

            }

            else

            {

                return false;

            }

        }
        }

    }
}