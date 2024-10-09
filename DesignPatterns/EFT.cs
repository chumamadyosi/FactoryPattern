using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class EFT : IPayment
    {
        Task<bool> IPayment.Pay(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
