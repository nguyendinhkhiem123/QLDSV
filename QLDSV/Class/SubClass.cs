using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.Class
{
    class SubClass
    {
        private int key;
        private string maSv;
        private string ho;
        private string ten;
        private string malop;
        private bool phai;
        private DateTime ngaysinh;
        private string noisinh;
        private string diachi;
        private string ghichu;
        private bool nghihoc;
        private string maLop;
        private string tenLop;
        private string maKhoa;
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private bool v6;
        private DateTime dateTime;
        private string v7;
        private string v8;
        private bool v9;
        private string text1;
        private string text2;
        private string text3;

        public SubClass(int v1, string v2, string v3, string v4, string v5, bool v6, DateTime dateTime, string v7, string v8, bool v9, string text1, string text2, string text3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.dateTime = dateTime;
            this.v7 = v7;
            this.v8 = v8;
            this.v9 = v9;
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        public SubClass(int key, string maSv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh, string diachi, string ghichu, bool nghihoc, string maLop, string tenLop, string maKhoa)
        {
            this.key = key;
            this.maSv = maSv;
            this.ho = ho;
            this.ten = ten;
            this.malop = malop;
            this.phai = phai;
            this.ngaysinh = ngaysinh;
            this.noisinh = noisinh;
            this.diachi = diachi;
            this.ghichu = ghichu;
            this.nghihoc = nghihoc;
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = maKhoa;
        }

        public int Key { get => key; set => key = value; }
        public string MaSv { get => maSv; set => maSv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Malop { get => malop; set => malop = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public bool Phai { get => phai; set => phai = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Noisinh { get => noisinh; set => noisinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public bool Nghihoc { get => nghihoc; set => nghihoc = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
