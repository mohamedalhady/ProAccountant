using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IReceiptBank : IRepository<ReceiptBankDetails>, IDataWithMultiInclude<ReceiptBankDetails>
    {
    }
}
