using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMS
{
    public interface  IProduct
    {
        string ID { get;}
        string ItemId { get; set; }
        string Name { get; set; }
        string GroupId { get; set; }
        string UnitId { get; set; }
        string DrawingNo { get; set; }
        string ModelNo { get; set; }
        int MinQty { get; set; }
        string Notes { get; set; }
    }
}
