using _17DH111117;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class AntiChargeDisChargeBattery : BatteryProxy
    {
        public AntiChargeDisChargeBattery(IBattery master) : base(master)
        {
        }

        public override bool Charge()
        {
            if (GetCurrentCapacity() < GetMaxCapacity())
            {
                return base.Charge();
            }
            else
            {
                return false;
            }
        }
        public override bool Discharge()
        {
            if (GetMaxCapacity() > 0)
            {
                return base.Discharge();
            }
            else
            {
                return false;
            }
        }

    }
}
