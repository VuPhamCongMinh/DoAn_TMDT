using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell cell = new Cell(75, 100);
            cell.Discharge();
            Console.WriteLine(cell.CurrentCapacity);
            Battery batt = new Battery(80, 100);
            batt.Add(cell);
            batt.Add(cell);
            Console.WriteLine(batt.GetCurrentCapacity());
        }
    }
}
