
using WpfLibrary2.Views;

namespace WpfLibrary2
{
    public class ModulesSave : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewSave>();
        }
    }

}
