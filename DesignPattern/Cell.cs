using System;
using System.Collections.Generic;
using System.Text;

namespace _17DH111117
{
    class Cell : ABattery
    {
        public Cell(int capCells)
        {
            CurrentCapacity = capCells;
        }

        public override bool Charge()
        {
            try
            {
                CurrentCapacity++;
                return true;
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
                CurrentCapacity--;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int GetCurrentCapacity()
        {
            return CurrentCapacity;
        }

        public override int GetMaxCapacity()
        {
            return MaxCapacity;
        }
        public override string ToString()
        {
            string buf = "[";
            buf += GetCurrentCapacity() + ", ";
            return buf.Substring(0, buf.Length - 2) + "]";
        }
    }
}
