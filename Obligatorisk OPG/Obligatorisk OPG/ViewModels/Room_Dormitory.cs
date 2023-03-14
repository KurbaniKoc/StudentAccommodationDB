using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.ViewModels
{
    public class Room_Dormitory
    {
        [Required] public int RoomNo { get; set; }
        [Required] public string Types { get; set;  }
        [Required] public string Price { get; set; }
        [Required] public int DormitoryNo { get; set; }


    }
}
