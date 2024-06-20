using System.ComponentModel.DataAnnotations;

namespace NTTMBT.Models
{
    public class NTTM428Employee
    {
    [Key]
    public string EmployeeID { get; set; }
    public string TenSinhVien { get; set; }
    public string LopHoc { get; set; }

    }
}