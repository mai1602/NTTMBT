using System.ComponentModel.DataAnnotations;

namespace NTTMBT.Models
{
    public class NTTM428Person
    {
    [Key]
    public string MaSinhVien { get; set; }
    public string TenSinhVien { get; set; }
    public string LopHoc { get; set; }

    }
}