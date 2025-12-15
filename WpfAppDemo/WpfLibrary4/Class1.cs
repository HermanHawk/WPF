
using System.Reflection;
using WpfLibrary4.ViewModels;
using WpfLibrary4.Views;

namespace WpfLibrary4
{
    public class ModulesPopUp1 : IModule
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
