namespace Obligatorisk_OPG.Model
{
    public class Leasing
    {
        public Leasing()
        {
        }

        public Leasing(int leasingNo, DateOnly dateFrom, DateOnly dateTo)
        {
            LeasingNo = leasingNo;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public int LeasingNo { get; set; }
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(LeasingNo)}={LeasingNo.ToString()}, {nameof(DateFrom)}={DateFrom.ToString()}, {nameof(DateTo)}={DateTo.ToString()}}}";
        }
    }
}
