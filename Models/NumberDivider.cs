using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class NumberDivider
    {
        int result;

        public NumberDivider()
        {
            result = 0;
        }

        public void Divide(int n1, int n2)
        {
            try
            {
                result = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }
            finally
            {
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
