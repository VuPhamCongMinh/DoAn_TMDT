using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract class ABattery : IBattery
    {
        public int CurrentCapacity { get; set; }
        public int MaxCapacity { get; set; }

        protected ABattery(int current, int max)
        {
            CurrentCapacity = current;
            MaxCapacity = max;
        }

        public abstract void Charge();
        public abstract void Discharge();
        public abstract int GetCurrentCapacity();
        public abstract int GetMaxCapacity();
        public virtual void Add(IBattery element) { throw new NotImplementedException(); }
        public void Remove(IBattery element) { throw new NotImplementedException(); }
    }
}
