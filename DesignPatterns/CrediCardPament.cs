using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CrediCardPament : IPayment
    {
        Task<bool> IPayment.Pay(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
