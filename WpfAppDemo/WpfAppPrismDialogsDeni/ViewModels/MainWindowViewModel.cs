namespace WpfAppPrismDialogsDeni.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand<string> PopUpCommand { get; private set; }
        public MainWindowViewModel(IDialogService dialogService)
        {
            PopUpCommand = new DelegateCommand<string>(ManageView);
            this.dialogService = dialogService;
        }
        private readonly IDialogService dialogService;
        private void ManageView(string obj)
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("Title", "这是一个弹窗的测试");
            dialogService.ShowDialog(obj, keys, callback =>
            {

            });
        }
    }
}
