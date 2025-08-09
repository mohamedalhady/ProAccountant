using Models.Models;
using MyFarmWeb.Repository.Base;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IUnitConverter : IRepository<UnitsConverter>
    {
        float CreateFactory(int FromUnitId,int ToUnitId);
    }
}
