using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IPaymentSafe : IRepository<PaymentSafeDetails>, IDataWithMultiInclude<PaymentSafeDetails>
    {
    }
}
