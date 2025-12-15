

using WpfLibrary1.ViewModels;
using WpfLibrary1.Views;

namespace WpfLibrary1
{
    public class ModulesOpen : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewOpen, ViewOpenViewModel>();
        }
    }

}
