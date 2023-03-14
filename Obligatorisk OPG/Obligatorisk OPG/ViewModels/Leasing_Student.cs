using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.ViewModels
{
    public class Leasing_Student
    {
        [Required] public int LeasingNo { get; set; }
        [Required] public DateTime DateFrom { get; set; }
        [Required] public DateTime DateTo { get; set; }
        [Required] public int StudentNo { get; set; }
        [Required] public int RoomNo { get; set; }
        [Required] public int DormitoryNumber { get; set; }

    }
}
