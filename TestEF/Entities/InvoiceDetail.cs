using System;
using System.Collections.Generic;

namespace TestEF.Entities;

public partial class InvoiceDetail
{
    public int SalesOrderID { get; set; }

    public int SalesOrderDetailID { get; set; }

    public string? CarrierTrackingNumber { get; set; }

    public short OrderQty { get; set; }

    public int ProductID { get; set; }

    public int SpecialOfferID { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitPriceDiscount { get; set; }

    public decimal LineTotal { get; set; }

    public Guid rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
