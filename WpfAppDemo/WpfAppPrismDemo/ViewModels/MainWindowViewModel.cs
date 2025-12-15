namespace WpfAppPrismDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand<string> DelegateCommand { get; private set; }
        public DelegateCommand BackCommand { get; private set; }
        public MainWindowViewModel(IRegionManager regionManager)
        {
            DelegateCommand = new DelegateCommand<string>(ManageView);
            BackCommand = new DelegateCommand(GoBackDemo);
            this.regionManager = regionManager;
        }

        private void GoBackDemo()
        {
            if (journal.CanGoBack)
                journal.GoBack();
        }

        private readonly IRegionManager regionManager;
        private IRegionNavigationJournal journal;
       
        private void ManageView(string obj)
        {
            NavigationParameters keyValuePairs = new NavigationParameters();
            keyValuePairs.Add("BodyTest", "this is test bodyTest");
            regionManager.Regions["ContentRegionNameMainWindow"].RequestNavigate(obj,
                navigationCallback =>
                {
                    if (navigationCallback.Success)
                    {
                        journal = navigationCallback.Context.NavigationService.Journal;
                    }
                },
                keyValuePairs);
            //switch (obj)
            //{
            //    case "ViewOpen":
            //        BodyTest = new ViewOpen();
            //        break;
            //    case "ViewSave":
            //        BodyTest = new ViewSave();
            //        break;
            //    case "ViewDelete":
            //        BodyTest = new ViewDelete();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
