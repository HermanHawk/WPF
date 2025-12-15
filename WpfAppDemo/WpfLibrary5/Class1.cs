
using Prism.Ioc;
using Prism.Modularity;
using WpfLibrary5.ViewModels;
using WpfLibrary5.Views;

namespace WpfLibrary5
{
    public class ModulesPopUp : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //×¢Èë
            containerRegistry.RegisterDialog<ViewPopUp, ViewPopUpViewModel>();
        }
    }

}
