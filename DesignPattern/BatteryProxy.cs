using _17DH111117;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    class BatteryProxy : ABattery
    {
        private IBattery _master;
        public BatteryProxy(IBattery master)
        {
            _master = master;
        }
        public override bool Charge()
        {
            return _master.Charge();
        }

        public override bool Discharge()
        {
            return _master.Discharge();
        }

        public override int GetCurrentCapacity()
        {
            return _master.GetCurrentCapacity();
        }

        public override int GetMaxCapacity()
        {
            return _master.GetMaxCapacity();
        }
        //tác vụ giải mã trạng thái battery thành chuỗi 
        public override string ToString()
        {
            return _master.ToString();
        }
    }
}
