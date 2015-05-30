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

            if (input.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {

                    {
                        result.Add(input[i]);
                    }
                }
            }
            else
                for (int i = 0; i < input.Count; i++)
                {

                    {
                        result.Add(input[i]);
                    }
                }
                        
            result = result.Where(x => x >= 4 && x < 10).Distinct().ToList();
           

            //for (int i = 0; i < 5; i++)
            //{
            //    if ((input[i] >= 4) && (input[i] <10))
            //    {
                  
            //        result.Add(input[i]);
            //    }
                               
            //}

           //List<int> Copy = result.GroupBy(x => x).ToList();
           // for (int i = 1; i < result.Count; i++)
           // {
           //  if (result[i] == result[i-1])
           //  {
           //      result.Remove(result[i]);
           //  }

           // }
            

            return result;
        }

        
    }
}
