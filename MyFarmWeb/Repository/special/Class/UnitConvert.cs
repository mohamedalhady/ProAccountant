using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.special.Class
{
    public class UnitConvert : MainRepository<UnitsConverter>, IUnitConverter
    {
        private readonly MyFarmContext context;
        public UnitConvert(MyFarmContext myFarmContext) : base(myFarmContext)
        {
            context = myFarmContext;
        }

        public float CreateFactory(int FromUnitId, int ToUnitId)
        {
            if (FromUnitId == ToUnitId)
            {
                return 1;
            }
            var unit1 = context.Units.Find(FromUnitId);
            var unit2 = context.Units.Find(ToUnitId);
            if (unit1 != null && unit2 != null)
            {
                if (unit1.UnitTypeId == 1 && unit2.UnitTypeId == 1)
                {
                    return 0;
                }
                if (unit1.UnitTypeId == 1 && unit2.UnitTypeId == 2)
                {
                    return ConvertMainToSub(FromUnitId, ToUnitId);
                }
                if (unit1.UnitTypeId == 2 && unit2.UnitTypeId == 1)
                {
                    return ConvertSubToMain(FromUnitId, ToUnitId);
                }
                if (unit1.UnitTypeId == 2 && unit2.UnitTypeId == 2)
                {
                    return ConvertSubToSub(FromUnitId, ToUnitId);
                }
               

            }
           return 0f;
        }

        private float ConvertMainToSub(int FromUnitId, int ToUnitId)
        {
          
            var converterfactory = context.UnitsConverters.FirstOrDefault(s => s.UnitMainId == FromUnitId && s.UnitSubId == ToUnitId);
            if (converterfactory != null)
            {
                return converterfactory.ConversionFactor;
            }
            return 0f;
        }
        private float ConvertSubToSub(int FromUnitId, int ToUnitId)
        {

            float factory = 0f;
            var UnitMainToFromUnit = context.UnitsConverters.Where(s => s.UnitSubId == FromUnitId);
            var UnitMainToToUnit   = context.UnitsConverters.Where(s => s.UnitSubId == ToUnitId);
            var JoinCoverter = from unit1 in UnitMainToFromUnit
                               join unit2 in UnitMainToToUnit on unit1.UnitMainId equals unit2.UnitMainId
                               select
                               new
                               {
                                  FromUnitMain = unit1.UnitMainId,
                                  ToUnitMain =   unit2.UnitMainId,
                               };
            if (JoinCoverter.ToArray().Count() != 0)
            {
                if (JoinCoverter.ToArray()[0].FromUnitMain == JoinCoverter.ToArray()[0].ToUnitMain)
                {
                    var Unit1Factory = context.UnitsConverters.FirstOrDefault(f => f.UnitSubId == FromUnitId && f.UnitMainId == JoinCoverter.ToArray()[0].FromUnitMain);
                    var Unit2Factory = context.UnitsConverters.FirstOrDefault(f => f.UnitSubId == ToUnitId && f.UnitMainId == JoinCoverter.ToArray()[0].ToUnitMain);
                    if (Unit1Factory != null && Unit2Factory != null)
                    {
                        factory = Unit2Factory.ConversionFactor / Unit1Factory.ConversionFactor;
                        return factory;
                    }
                }
               
            }
            return 0f;
        }

        private float ConvertSubToMain(int FromUnitId, int ToUnitId)
        {
         
            var converterfactory = context.UnitsConverters.FirstOrDefault(s => s.UnitMainId == ToUnitId && s.UnitSubId == FromUnitId);
            if (converterfactory != null)
            {
                return 1 / converterfactory.ConversionFactor;
            }
            return 0f;
        }
    }
}
