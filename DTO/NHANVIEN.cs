//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnPBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public string maNV { get; set; }
        public string maTK { get; set; }
        public string tenNV { get; set; }
        public bool gioiTinh { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string diaChi { get; set; }
        public double luongTheoGio { get; set; }
        public bool coXoa { get; set; }
    
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
