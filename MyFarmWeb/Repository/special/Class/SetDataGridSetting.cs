using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using Models.Models;
using MyFarmWeb.Data;
using Radzen;
using System.Text.Json;

namespace MyFarmWeb.Repository.special.Class
{
   
    public class SetDataGridSetting
    {

        public MyFarmContext contextdb { get; set; }
        public SetDataGridSetting(MyFarmContext _contextdb)
        {
                contextdb = _contextdb;
        }

        public async Task SaveStateAsync(DataGridSetting dataGridSetting)
        {

            await Task.CompletedTask;
            
            if (dataGridSetting.IsDefault == true)
            {
                var layouts = contextdb.DataGridSettingModel.Where(y => y.GridId == dataGridSetting.GridId && y.UserId == dataGridSetting.UserId).ToList(); ;

                foreach (var layout in layouts) 
                {
                    layout.IsDefault = false;
                }
                dataGridSetting.IsDefault = true;
            }
          
           
           contextdb.DataGridSettingModel.Add(dataGridSetting);
           await contextdb.SaveChangesAsync();

           
        }
        public async Task SaveStateAsync(DataGridSetting dataGridSetting,string columnfrozensetting)
        {

            await Task.CompletedTask;

            if (dataGridSetting.IsDefault == true)
            {
                var layouts = contextdb.DataGridSettingModel.Where(y => y.GridId == dataGridSetting.GridId && y.UserId == dataGridSetting.UserId).ToList(); ;

                foreach (var layout in layouts)
                {
                    layout.IsDefault = false;
                }
                dataGridSetting.IsDefault = true;
            }

            using (contextdb.Database.BeginTransaction())
            {
                contextdb.DataGridSettingModel.Add(dataGridSetting);
                await contextdb.SaveChangesAsync();
                contextdb.DataGridColumnsFrozen.Add(new DataGridColumnsFrozen() { GridId = dataGridSetting.Id,ColumnsFrozenSetting = columnfrozensetting});
                await contextdb.SaveChangesAsync();
                contextdb.Database.CommitTransaction();

            }


        }
        public async Task UpdateStateAsync(DataGridSetting dataGridSetting)
        {
            await Task.CompletedTask;
            var settingisfound = contextdb.DataGridSettingModel.FirstOrDefault(s => s.UserId == dataGridSetting.UserId && s.Id == dataGridSetting.Id);
            
            if (settingisfound != null)
            {
                if (dataGridSetting.IsDefault == true)
                {
                    var layouts = contextdb.DataGridSettingModel.Where(y => y.GridId == dataGridSetting.GridId && y.UserId == dataGridSetting.UserId).ToList(); ;
                    foreach (var layout in layouts)
                    {
                        layout.IsDefault = false;
                    }

                    settingisfound.IsDefault = true;
                }
                else
                {
                    settingisfound.IsDefault = dataGridSetting.IsDefault;
                }
                settingisfound.Setting = dataGridSetting.Setting;
                settingisfound.Name = dataGridSetting.Name;
                settingisfound.IsExpand = dataGridSetting.IsExpand;
                settingisfound.ColumnsFrozen = dataGridSetting.ColumnsFrozen;
                await contextdb.SaveChangesAsync();
            }
        
            


        }
        public async Task<DataGridSetting> LoadStateAsync( int Id, string UserId,string GridId)
        {
          //  var isfrozen = contextdb.DataGridColumnsFrozen.Any(c => c.GridId == Id);
           
         
               var  result = await contextdb.DataGridSettingModel.FirstOrDefaultAsync(s => s.UserId == UserId && s.Id == Id && s.GridId == GridId);
              
            
            //else
            //{
            //    var frozen = from setting in contextdb.DataGridSettingModel
            //                 join f in contextdb.DataGridColumnsFrozen on setting.Id equals f.GridId
            //                 where setting.GridId == GridId && setting.UserId == UserId && setting.Id == Id
            //                 select new DataGridSetting()
            //                 {
            //                     ColumnsFrozen = setting.ColumnsFrozen,
            //                     Id = setting.Id,
            //                     UserId = setting.UserId,
            //                     GridId = setting.GridId,
            //                     IsDefault = setting.IsDefault,
            //                     IsExpand = setting.IsExpand,
            //                     Name = setting.Name,
            //                     Setting = setting.Setting
            //                 };
            //    if (frozen != null)
            //    {
            //        result = frozen.ToList()[0];
            //    }
            //}
        
            return result;
        }
    
        public  IEnumerable<DataGridSetting> GetAllLayout(string UserId,string GridId)
        {
            var Layout =  contextdb.DataGridSettingModel.Where(s => s.UserId == UserId && s.GridId == GridId);
            return Layout;
        }
        public DataGridSetting GetLayoutDefault(string UserId, string GridId)
        {
            var Layout = contextdb.DataGridSettingModel.FirstOrDefault(s => s.UserId == UserId && s.GridId == GridId && s.IsDefault == true);
            return Layout;
        }

        public DataGridSetting GetLayoutById(string UserId, string GridId,int Id)
        {
            var Layout = contextdb.DataGridSettingModel.FirstOrDefault(s => s.UserId == UserId && s.GridId == GridId && s.Id == Id);
            return Layout;
        }
        public void DeleteLayout(string UserId, string GridId, int Id)
        {
            var Layout = contextdb.DataGridSettingModel.FirstOrDefault(s => s.UserId == UserId && s.GridId == GridId && s.Id == Id);
            if (Layout != null)
            {
                contextdb.DataGridSettingModel.Remove(Layout);
                contextdb.SaveChanges();
            }
            
        }

        public async Task SaveStateColumnsFrozen(DataGridColumnsFrozen dataGridSetting)
        {
            await Task.CompletedTask;
            if (dataGridSetting != null)
            {
                contextdb.DataGridColumnsFrozen.Add(dataGridSetting);
                contextdb.SaveChanges();
            }
           

        }
    }
}
