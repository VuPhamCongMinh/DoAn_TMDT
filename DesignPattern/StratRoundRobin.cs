using _17DH111117;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StratRoundRobin : IChargeStrategy
    {

        int aCharger = -1; //thiết lập chỉ số battery đã nạp lần cuối int 
        int aDecharger = -1; //thiết lập chỉ số battery đã thải lần cuối


        public bool Charge(List<IBattery> elems)
        {

            //hiệu chỉnh chỉ số battery cần nạp

            aCharger = (aCharger + 1) % elems.Count;

            return elems[aCharger].Charge();

        }

        public bool Discharge(List<IBattery> elems)
        {

            //hiệu chỉnh chỉ số battery cần thải

            aDecharger = (aDecharger + 1) % elems.Count;

            return elems[aDecharger].Discharge();

        }

    }

}
