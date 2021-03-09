using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMS.Items
{    
    public class Batch : IDisposable
    {
        IProduct Product {get;set;}
        string BatchNo {get;set;}
        int BalanceQty {get;set;}
        int IssueQty {get;set;}
        int ReturnQty {get;set;}

        public void Dispose()
        {
            Product = null;
            BatchNo = null;
        }
    }
}
