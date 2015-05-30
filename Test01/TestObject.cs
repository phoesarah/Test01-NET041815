using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class TestObject
    {
        internal List<int> Reduce(List<int> input)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                if ((input[i] >= 4) && (input[i] <10))
                {
                  
                    result.Add(input[i]);
                }
                               
            }

            //for (int i = 0; i < result.Count; i++)
            //{
            //    if ((input[i] >= 4) && (input[i] < 10))
            //    {

            //        result.Add(input[i]);
            //    }

            //}
            return result;
        }

        
    }
}
