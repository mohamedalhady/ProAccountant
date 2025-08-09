using ElectronNET.API.Entities;

namespace MyFarmWeb.Repository
{
    public  class LayoutState
    {
        public  event Action? OnChange;
        public  List<Models.Models.MenuItem> _MenuItems { get;private set; }

        public void SetMenuItems(List<Models.Models.MenuItem> menuItems)
        {
                    _MenuItems = menuItems;
                 NotifyStateChanged();
            
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

