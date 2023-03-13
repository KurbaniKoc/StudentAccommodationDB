using System.ComponentModel.DataAnnotations;

namespace Obligatorisk_OPG.Model
{
    public class Leasing
    {
        public Leasing()
        {
        }

        public Leasing(int leasingNo, DateTime dateFrom, DateTime dateTo)
        {
            LeasingNo = leasingNo;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        [Required] public int LeasingNo { get; set; }
        [Required] public DateTime DateFrom { get; set; }
        [Required] public DateTime DateTo { get; set; }
        [Required] public int StudentNo { get; set; }
        [Required] public int RoomNo { get; set; }
        [Required] public int DormitoryNumber { get; set; }


        //public override string ToString()
        //{
        //    return $"{{{nameof(LeasingNo)}={LeasingNo.ToString()}, {nameof(DateFrom)}={DateFrom.ToString()}, {nameof(DateTo)}={DateTo.ToString()}}}";
        //}
    }
}
