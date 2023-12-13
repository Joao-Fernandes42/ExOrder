using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOrderT5T2.Entities.Enums
{
    internal enum OrderStatus: int
    {
        PENDING_PAYMENT=0,
        PROCESSING=1,
        SHIPPING=2,
        DELIVERED=3
    }
}
