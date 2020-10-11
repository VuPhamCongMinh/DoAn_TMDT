using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    interface IBattery
    {
        int GetMaxCapacity();
        int GetCurrentCapacity();
        void Charge();
        void Discharge();
        void Add(IBattery element);
        void Remove(IBattery element);

    }
}
