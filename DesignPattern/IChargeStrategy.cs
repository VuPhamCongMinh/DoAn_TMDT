using _17DH111117;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //đặc tả interface của mọi đối tượng miêu tả giải thuật nạp/xả năng lượng //cho pin tích hợp

    interface IChargeStrategy
    {

        //tác vụ nạp điện cho phần tử tích hợp theo 1 chiến lược xác định 
        bool Charge(List<IBattery> elems);

        //tác vụ thải điện khỏi phần tử tích hợp theo 1 chiến lược xác định 
        bool Discharge(List<IBattery> elems);

    }

}
