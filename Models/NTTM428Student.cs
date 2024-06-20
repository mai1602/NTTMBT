using System.ComponentModel.DataAnnotations;

namespace NTTMBT.Models
{
    public class NTTM428Student
    {
    [Key]
    public string CCCN { get; set; }
    public string TenSinhVien { get; set; }
    public string LopHoc { get; set; }

    }
}