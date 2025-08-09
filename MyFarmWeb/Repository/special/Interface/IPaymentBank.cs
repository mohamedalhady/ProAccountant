using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IPaymentBank : IRepository<PaymentBankDetails>, IDataWithMultiInclude<PaymentBankDetails>
    {
    }
}
