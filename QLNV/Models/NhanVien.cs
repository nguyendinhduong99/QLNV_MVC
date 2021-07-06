namespace QLNV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Mã Nhân Viên")]
        public short Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Họ Và Tên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Giới Tính")]
        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "Tel")]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        [Display(Name = "Số Căn Cước")]
        public string SoCanCuoc { get; set; }

        [StringLength(50)]
        [Display(Name = "Tài Khoản")]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Tên Chức Vụ")]
        public short? IdChucVu { get; set; }

        [Display(Name = "Quản Trị Viên Ko ?")]
        public bool LaQuanTri { get; set; }

        [Display(Name = "Chuyên Viên Ko ?")]
        public bool LaChuyenVien { get; set; }

        [Display(Name = "Nhân Viên Ko ?")]
        public bool LaNhanVien { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}