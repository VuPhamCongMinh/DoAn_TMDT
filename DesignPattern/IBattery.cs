using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    interface IBattery
    {
        int GetMaxCapacity();
        int GetCurrentCapacity();
        bool Charge();
        bool Discharge();
        void Add(IBattery element);
        void Remove(IBattery element);

    }
}
