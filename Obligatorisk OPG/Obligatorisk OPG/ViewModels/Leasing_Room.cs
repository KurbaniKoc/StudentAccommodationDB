using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.ViewModels
{
    public class Leasing_Room
    {
        [Required] public int LeasingNo { get; set; }
        [Required] public int StudentNo { get; set; }
        [Required] public int RoomNo { get; set; }
        
        
        
    }
}
