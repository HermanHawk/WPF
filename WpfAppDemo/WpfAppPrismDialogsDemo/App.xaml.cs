using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfAppPrismDialogsDemo.Views;
using WpfLibrary5;

namespace WpfAppPrismDialogsDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //在这里配置模块目录，添加模块
            
            moduleCatalog.AddModule<ModulesPopUp>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }

}
