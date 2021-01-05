using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DoAnTMDT.AutomatedGUITests
{
    class AccountData
    {
        public static IEnumerable<object[]> DuLieuMau()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Admin\Desktop\test_data.txt");
            List<object[]> obj = new List<object[]>();
            foreach (var chu in lines)
            {
                string[] col = chu.Split('|');
                obj.Add(new object[] { col[0], col[1] });
            }
            return obj;
        }
    }
}
