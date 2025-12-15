using Example;
using Prism.DryIoc;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfAppPrismDemo.Views;
using WpfLibrary1;
using WpfLibrary2;
using WpfLibrary3;


namespace WpfAppPrismDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //创建主窗口
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //依赖注入
            // 注册单例
            //containerRegistry.RegisterSingleton<IMyService, MyService>();

            // 注册普通类型（每次请求创建新实例）
            //containerRegistry.Register<IMyOtherService, MyOtherService>();

            // 注册实例（已有的实例）
            //var myInstance = new MyInstance();
            //containerRegistry.RegisterInstance<IMyInstance>(myInstance);

            // 注册带参数的构造函数类型
            // DryIoc会自动解析构造函数依赖，但如果有多个构造函数，需要指定一个
            // 可以在注册时指定使用哪个构造函数
            // 例如：containerRegistry.Register<MyService>(made: Made.Of(() => new MyService(Arg.Of<IDependency>())));

            // 注册导航视图
            //containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            //containerRegistry.RegisterForNavigation<ViewOpen>();
            //containerRegistry.RegisterForNavigation<ViewSave>();
            //containerRegistry.RegisterForNavigation<ViewDelete>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //在这里配置模块目录，添加模块
            moduleCatalog.AddModule<ModulesOpen>();
            moduleCatalog.AddModule<ModulesSave>();
            moduleCatalog.AddModule<ModulesDelete>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath=@".\Modules"};
        //}
    }

}
