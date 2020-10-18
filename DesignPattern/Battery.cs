using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    class Battery : ABattery
    {

        protected List<IBattery> elements = new List<IBattery>();

        private IChargeStrategy myStrat;

        //Constructor khởi tạo object Battery với nCells là số lượng cell
        //capCells là Current Capacity (sức chứa) của cell đó
        //bycycle cho biết Battery đó có theo chu trình (bycycles) mà từ đó quyết định dùng Strategy nào
        public Battery(int nCells, int capCells, bool bycycles)
        {
            for (int i = 0; i < nCells; i++)
            {
                elements.Add(new Cell(capCells));
            }

            if (bycycles)
            {
                myStrat = new StratRoundRobin();
            }
            else
            {
                myStrat = new StratMinMax();
            }

        }

        public override bool Charge()
        {
            try
            {
                return myStrat.Charge(elements);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public override bool Discharge()
        {
            try
            {
                return myStrat.Discharge(elements);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public override int GetCurrentCapacity()
        {
            int result = 0;
            foreach (IBattery cell in elements)
            {
                result += cell.GetCurrentCapacity();
            }
            return result;
        }

        public override int GetMaxCapacity()
        {
            int result = 0;
            foreach (IBattery cell in elements)
            {
                if (cell is Battery)
                {
                    result += cell.GetMaxCapacity();
                }
                else
                {
                result += cell.GetMaxCapacity();

                }
            }
            return result;
        }
        public override string ToString()
        {
            String buf = "[";
            foreach (IBattery c in elements)
            {
                buf += c + ", ";
            }
            return buf.Substring(0, buf.Length - 2) + "]";
        }
        public override void Add(IBattery element)
        {
            elements.Add(element);
        }
        public override void Remove(IBattery element)
        {
            elements.Remove(element);
        }
    }
}
