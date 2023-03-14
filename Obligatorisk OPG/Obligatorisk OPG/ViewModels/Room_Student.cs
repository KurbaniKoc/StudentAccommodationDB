using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.ViewModels
{
    public class Room_Student
    {

        [Required] public int RoomNo { get; set; }
        
        [Required] public int DormitoryNo { get; set; }
        [Required] public int StudentNo { get; set; }
        

    }
}
