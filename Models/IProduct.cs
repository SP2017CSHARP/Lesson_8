using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    interface IProduct
    {
        int GetPrice();

        void SetPrice(int value);

        int ChangePrice(int newPrice);

        void ShowInformation();
    }
}
