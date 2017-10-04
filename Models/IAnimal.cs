using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    interface IAnimal
    {
        string Name { get; set; }
        int Length { get; set; }
        string Sound { get; set; }
        void MakeSound();
    }
}
