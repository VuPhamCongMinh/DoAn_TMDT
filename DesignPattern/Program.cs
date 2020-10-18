using System;

namespace _17DH111117
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cell cell = new Cell(5);
            //Console.WriteLine(cell.CurrentCapacity);
            //Battery batt = new Battery(2, 50, true);
            //batt.Add(cell);
            //Console.WriteLine(batt.GetCurrentCapacity());
            //Console.WriteLine(batt.Discharge());
            //Console.WriteLine(batt.Discharge());
            ////Sau khi discharge 2 lần : 2*50+5-2(lần discharge) = 103
            //Console.WriteLine(batt.GetCurrentCapacity());




            IBattery b1 = new Cell(2);
            Console.WriteLine("DL max cua b1 = " + b1.GetMaxCapacity() + ", DL hien hanh =" + b1.ToString());
            b1.Charge();
            Console.WriteLine("DL b1 sau khi nap them 1u = " + b1.ToString());
            b1.Discharge();
            b1.Discharge();
            b1.Discharge();
            b1.Discharge();
            Console.WriteLine("DL b1 sau khi xa 4u = " + b1.ToString());
            b1 = new Cell(10);
            IBattery b2 = new Battery(1, 5, false);
            IBattery b21 = new Battery(10, 5, false);
            b2.Add(b1);
            b2.Add(b21);
            Console.WriteLine("Trang thai cua b2 = " + b2.ToString());
            b2.Discharge();
            b2.Discharge();
            Console.WriteLine("b2 sau khi xa 2u = " + b2.ToString());
            b2.Charge();
            b2.Charge();
            Console.WriteLine("b2 sau khi nap 2u = " + b2.ToString());
            IBattery b3 = new Battery(2, 10, true);
            b3.Add(b1);
            b3.Add(b2);
            Console.WriteLine("Trang thai cua b3 = " + b3.ToString());
            b3.Discharge();
            b3.Discharge();
            Console.WriteLine("b3 sau khi xa 2u = " + b2.ToString());
            b3.Charge();
            b3.Charge();
            Console.WriteLine("b3 sau khi nap 2u = " + b2.ToString());

        }
    }
}
