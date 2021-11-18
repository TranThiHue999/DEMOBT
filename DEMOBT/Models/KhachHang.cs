using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DEMOBT.Models
{
    [Table("KhachHangs")] // dùng đặt tên cho table được truyền vào trong nháy kép,
    // nếu không có thì nó dùng luôn tên của Class đặt tên cho table
    public class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        [MaxLength(15)]
        public string SoDienThoai { get; set; }
    }
}