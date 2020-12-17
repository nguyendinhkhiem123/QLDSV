using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.Class
{
    class SinhVien
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

        public SinhVien(int key, string maSv, string ho, string ten, string malop, bool phai, DateTime ngaysinh, string noisinh, string diachi, string ghichu, bool nghihoc)
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
        }

        public int Key { get => key; set => key = value; }
        public string MaSv { get => maSv; set => maSv = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Malop { get => malop; set => malop = value; }
        public bool Phai { get => phai; set => phai = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Noisinh { get => noisinh; set => noisinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public bool Nghihoc { get => nghihoc; set => nghihoc = value; }
    }
}
