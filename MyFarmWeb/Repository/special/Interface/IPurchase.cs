using Models.Models;
using MyFarmWeb.Components.Pages.Purchase;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IPurchase : IRepository<PurchaseInvoiceDetails> , IGetDataForReport, IDataWithMultiInclude<PurchaseInvoiceDetails> { }
 
}
