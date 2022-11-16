using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WendingMachine.v2 {
    interface IOrder {
        bool IsAvailable { get; } 
        int GetTotalPrice();
        void Ship(); 
    }
}
