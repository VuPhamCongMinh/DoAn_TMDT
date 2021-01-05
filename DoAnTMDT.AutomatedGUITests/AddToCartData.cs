using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DoAnTMDT.AutomatedGUITests
{
    class AddToCartData
    {
        public static IEnumerable<object[]> DuLieuMau()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Admin\Desktop\test_data_cartitem.txt");
            List<object[]> obj = new List<object[]>();
            Random quantity = new Random();
            foreach (var chu in lines)
            {
                obj.Add(new object[] { int.Parse(chu), quantity.Next(1, 4) });
            }
            return obj;
        }
    }
}
