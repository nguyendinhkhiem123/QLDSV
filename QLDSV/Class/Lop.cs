using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.Class
{
    class Lop
    {
        private int key;
        private string maLop;
        private string tenLop;
        private string maKhoa;

        public Lop(int key, string maLop, string tenLop, string maKhoa)
        {
            this.key = key;
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = maKhoa;
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
    }
}
