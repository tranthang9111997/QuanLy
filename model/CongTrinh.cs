using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.model
{
    public class CongTrinh
    {

        private string idCongTrinh;
        private string tenCongTrinh;
        private string diaDiem;
        private DateTime ngayKhoiCong;
        private DateTime ngayHoanThanh;

        public string IdCongTrinh
        {
            get
            {
                return idCongTrinh;
            }

            set
            {
                idCongTrinh = value;
            }
        }

        public string TenCongTrinh
        {
            get
            {
                return tenCongTrinh;
            }

            set
            {
                tenCongTrinh = value;
            }
        }

        public string DiaDiem
        {
            get
            {
                return diaDiem;
            }

            set
            {
                diaDiem = value;
            }
        }

        public DateTime NgayKhoiCong
        {
            get
            {
                return ngayKhoiCong;
            }

            set
            {
                ngayKhoiCong = value;
            }
        }

        public DateTime NgayHoanThanh
        {
            get
            {
                return ngayHoanThanh;
            }

            set
            {
                ngayHoanThanh = value;
            }
        }
    }
}
