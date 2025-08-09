using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IBankTransactions :  IRepository<BankTransaction>, IDataWithMultiInclude<BankTransaction>
    {
    }
}
