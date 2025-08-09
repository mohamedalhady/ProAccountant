using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IPurchaseReverse : IRepository<PurchaseReverseDetails>,IDataWithMultiInclude<PurchaseReverseDetails>
    {
      
    }
}
