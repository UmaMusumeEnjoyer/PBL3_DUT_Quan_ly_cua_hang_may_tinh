using System;


namespace Gwenchana.DataAccess.DTO
{
    public class Receipt
    {
        public int Receipt_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime receiptDate { get; set; }

        public Decimal ReceiptTotal { get; set; }
    }
}
