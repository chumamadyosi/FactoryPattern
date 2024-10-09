using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PamentFactory
    {
        public static IPayment create(string type)
        {
            switch (type) {
                case "eft":
                        return new EFT();
                case "credid":
                    return new CrediCardPament();
                default: throw new NotImplementedException();
            }
        }
    }
}
