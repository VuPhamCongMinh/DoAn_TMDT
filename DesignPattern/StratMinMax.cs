using System;
using System.Collections.Generic;
using System.Text;
using _17DH111117;

namespace ConsoleApp1
{
    class StratMinMax : IChargeStrategy
    {
        public bool Charge(List<IBattery> elems)
        {
            int cellmin = 0;

            int capamin = Int32.MaxValue;

            //lặp tìm battery có công suất nhỏ nhất

            for (int c = 0; c < elems.Count; c++)
            {

                int capaCur = elems[c].GetCurrentCapacity();

                if (capaCur < capamin)
                {

                    cellmin = c;

                    capamin = capaCur;

                }

            }

            //nạp 1u cho battery có công suất nhỏ nhất tìm được 
            return elems[cellmin].Charge();

        }

        public bool Discharge(List<IBattery> elems)
        {
            int cellmax = 0;

            int capamax = Int32.MinValue;

            //lặp tìm battery có công suất lớn nhất

            for (int c = 0; c < elems.Count; c++)
            {

                int capaCur = elems[c].GetCurrentCapacity();


                if (capaCur > capamax)
                {

                    cellmax = c;

                    capamax = capaCur;

                }

            }

            //thải 1u của battery có công suất lớn nhất tìm được
            return elems[cellmax].Discharge();

        }

    }
}

