using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IMS.Items
{
    public interface  IProductOperation
    {
        void Add(IProduct Product);
        void Update(IProduct Product);
        void Delete(IProduct Product);
        void AddOpeningStock(IProduct Product, int openingStock);
        void IsssueProduct (Batch productBatch);
        void ReturnProduct(Batch productBatch);
        int GetBalanceQtyByProductBasedOnBatchNo(Batch productBatch);
        IList<Batch> GetProductBatch(IProduct product);
    }    
}
