using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    class BatteryBoost : BatteryProxy
    {
        bool doIt = true;
        bool isEmpty = false;
        public BatteryBoost(IBattery master) : base(master) { }

        public override bool Charge()
        {
            isEmpty = false;
            return base.Charge();
        }

        public override bool Discharge()
        {
            if (isEmpty)
            {
                return false;
            }

            if (doIt)
            {
                isEmpty = base.Discharge();
            }

            doIt = !doIt;
            return isEmpty;
        }
    }
}
