using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Start.CustomExceptions;

namespace Start.Models
{
    class Temperature
    {
        int temperature;

        public Temperature(int temp)
        {
            temperature = temp;
        }
        public void ChangeTemp(int temp)
        {
            try
            {
                this.temperature = temp;
                if (temp == 0)
                {
                    throw (new TemperatureIsZeroException("Your Temp Cannot be zero"));
                }
            }
            
            catch (TemperatureIsZeroException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

    }
}
