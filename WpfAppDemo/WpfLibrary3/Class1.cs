
using WpfLibrary3.Views;

namespace WpfLibrary3
{
    public class ModulesDelete : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewDelete>();
        }
    }

}
