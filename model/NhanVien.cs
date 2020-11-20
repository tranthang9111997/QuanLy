using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.model
{
    public class NhanVien
    {
        //1 là admin,2 là user
        string id_Nhanvien;
        string tenNhanVien;
        string ngaySinh;
        bool gioiTinh;
        string diaChi;
        decimal luongNV;
        string phongBan;
        List<CongTrinh> listcongtrinh;
        string chucVu;

        public string Id_Nhanvien
        {
            get
            {
                return id_Nhanvien;
            }

            set
            {
                id_Nhanvien = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public decimal LuongNV
        {
            get
            {
                return luongNV;
            }

            set
            {
                luongNV = value;
            }
        }

        public string PhongBan
        {
            get
            {
                return phongBan;
            }

            set
            {
                phongBan = value;
            }
        }

        public List<CongTrinh> Listcongtrinh
        {
            get
            {
                return listcongtrinh;
            }

            set
            {
                listcongtrinh = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }
    }
}
