using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VuPhamCongMinh
{
    class Sinhvien
    {
        public int SID { get; set; }
        public string HoTen { get; set; }
        public string Khoa { get; set; }
        public Dictionary<string, float> MonHoc { get; set; }
        public int SoMon
        {
            get { return MonHoc.Count; }
        }
        public Sinhvien()
        {

        }

        public Sinhvien(int sID, string hoTen, string khoa)
        {
            SID = sID;
            HoTen = hoTen;
            Khoa = khoa;
            MonHoc = new Dictionary<string, float>();
        }





        public int setMon(string mon)
        {
            try
            {
                if (MonHoc.ContainsKey(mon))
                {
                    Console.WriteLine("Môn này đã có");
                    return 0;
                }
                else
                {
                    MonHoc.Add(mon, 0);
                    Console.WriteLine("Thêm thành công");
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int setDiem(string mon, float diem)
        {
            try
            {
                if (MonHoc.ContainsKey(mon))
                {
                    MonHoc[mon] = diem;
                    Console.WriteLine("Cập nhật điểm thành công");
                    return 1;
                }
                else
                {
                    MonHoc.Add(mon, diem);
                    Console.WriteLine("Thêm thành công");
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public float tinhDTB()
        {
            try
            {
                float ketqua = 0;
                foreach (var MonvaDiem in MonHoc)
                {
                    ketqua += MonvaDiem.Value;
                }
                return ketqua / MonHoc.Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public float tinhDiemMax()
        {
            try
            {
                return MonHoc.Values.Max();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public Dictionary<string, float> tenMonMax()
        {
            try
            {
                var resultDict = new Dictionary<string, float>();
                foreach (var item in MonHoc.Where(x => x.Value == tinhDiemMax()))
                {
                    resultDict.Add(item.Key, item.Value);
                }
                return resultDict;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Dictionary<string, float> teMonThiLai()
        {
            try
            {
                var resultDict = new Dictionary<string, float>();
                foreach (var item in MonHoc.Where(x => x.Value <= 4.5))
                {
                    resultDict.Add(item.Key, item.Value);
                }
                return resultDict;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public bool checkChuyenNganh()
        {
            try
            {
                if (MonHoc.ContainsKey("Toán") && MonHoc.ContainsKey("Lý") && MonHoc.ContainsKey("Hóa"))
                {
                    if (((MonHoc["Toán"] + MonHoc["Lý"] + MonHoc["Hóa"]) / 3) >= 5 && MonHoc.Where(diem => diem.Value >= 5).Count() >= 10)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
