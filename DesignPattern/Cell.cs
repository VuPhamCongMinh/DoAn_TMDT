using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Cell : ABattery
    {
        public Cell(int current, int max) : base(current, max) { }

        public override void Charge()
        {
            CurrentCapacity = CurrentCapacity++ <= MaxCapacity ? CurrentCapacity = CurrentCapacity++ : CurrentCapacity;
        }

        public override void Discharge()
        {
            CurrentCapacity = CurrentCapacity-- >= 0 ? CurrentCapacity = CurrentCapacity-- : CurrentCapacity;
        }

        public override int GetCurrentCapacity()
        {
            return CurrentCapacity;
        }

        public override int GetMaxCapacity()
        {
            return MaxCapacity;
        }
    }
}
