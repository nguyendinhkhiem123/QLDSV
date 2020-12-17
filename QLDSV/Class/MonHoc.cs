using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV.Class
{
    class MonHoc
    {
        private int key;
        private string maMon;
        private string tenMon;

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public MonHoc(string maMon, string tenMon,int key)
        {
            this.key = key;
            this.maMon = maMon;
            this.tenMon = tenMon;
        }
    }
}
