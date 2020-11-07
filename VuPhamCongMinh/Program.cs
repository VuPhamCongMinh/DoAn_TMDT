using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuPhamCongMinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            var sv1 = new Sinhvien(1, "Minh", "CNTT");
            sv1.setMon("TMDT");
            sv1.setDiem("TMDT",5);
            sv1.setDiem("KTPM", 8);
            sv1.setDiem("CTDL", 5);
            sv1.setDiem("CSDL", 5);
            sv1.setDiem("Mac", 5);
            sv1.setDiem("OOP", 5);
            sv1.setDiem("C#", 5);
            sv1.setDiem("Toán", 8);
            sv1.setDiem("Lý", 6);
            sv1.setDiem("Hóa", 7);


            foreach (var item in sv1.MonHoc)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine($"Điểm trung bình là : {sv1.tinhDTB()}");
            Console.WriteLine($"Điểm cao nhất là : {sv1.tinhDiemMax()}");

            foreach (var item in sv1.tenMonMax())
            {
                Console.WriteLine($"Môn {item.Key} có điểm cao nhất là {item.Value}");
            }

            foreach (var item in sv1.teMonThiLai())
            {
                Console.WriteLine($"Môn {item.Key} có điểm là {item.Value} nên phải thi lại");
            }

            if (sv1.checkChuyenNganh())
            {
                Console.WriteLine($"Đạt yêu cầu");
            }
        }
    }
}
