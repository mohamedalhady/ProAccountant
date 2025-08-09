using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IStore: IRepository<StoreMovementDetails>, IDataWithMultiInclude<StoreMovementDetails>
    {
        IEnumerable<ItemBalanceModel> GetItemBalance(Dictionary<string, int[]> keyValues);

    }
}
