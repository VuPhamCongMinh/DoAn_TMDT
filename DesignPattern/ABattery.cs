using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    abstract class ABattery : IBattery
    {
        public int CurrentCapacity { get; set; }
        public int MaxCapacity { get; set; }

        public abstract bool Charge();
        public abstract bool Discharge();
        public abstract int GetCurrentCapacity();
        public abstract int GetMaxCapacity();
        public virtual void Add(IBattery element) { throw new NotImplementedException(); }
        public virtual void Remove(IBattery element) { throw new NotImplementedException(); }
    }
}
