using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Battery : ABattery
    {
        public Battery(int current, int max) : base(current, max) { }
        protected List<IBattery> Cells = new List<IBattery>();

        public override void Charge()
        {
            foreach (var cell in Cells)
            {
                cell.Charge();
            }
        }

        public override void Discharge()
        {
            foreach (var cell in Cells)
            {
                cell.Discharge();
            }
        }

        public override int GetCurrentCapacity()
        {
            int result = 0;
            foreach (var cell in Cells)
            {
                result += cell.GetCurrentCapacity();
            }
            return result;
        }

        public override int GetMaxCapacity()
        {
            int result = 0;
            foreach (var cell in Cells)
            {
                result += cell.GetMaxCapacity();
            }
            return result;
        }

        public new void Add(IBattery element)
        {
            Cells.Add(element);
        }
        public new void Remove(IBattery element)
        {
            Cells.Remove(element);
        }
    }
}
