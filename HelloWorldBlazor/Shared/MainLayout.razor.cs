using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        bool _drawerOpen = false;

        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
