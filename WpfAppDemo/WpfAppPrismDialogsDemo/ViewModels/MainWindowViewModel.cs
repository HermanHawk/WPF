using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppPrismDialogsDemo.ViewModels
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
            keys.Add("title", "这是一个弹窗的测试");
            dialogService.ShowDialog(obj, keys, callback =>
            {
                if(callback.Result == ButtonResult.OK)
                {
                    string result = callback.Parameters.GetValue<string>("TestDialogs");
                    MessageBox.Show(result);
                }
            });
        }
    }
}
