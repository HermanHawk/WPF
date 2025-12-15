using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLibrary1.ViewModels
{
    public class ViewOpenViewModel : BindableBase, IConfirmNavigationRequest
    {
        public ViewOpenViewModel()
        {

        }
        private string bodyTest;
        public string BodyTest
        {
            get
            {
                return bodyTest;
            }
            set
            {
                bodyTest = value;
                RaisePropertyChanged();
            }
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("BodyTest"))
            {
                BodyTest = navigationContext.Parameters.GetValue<string>("BodyTest");
            }
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool isNavigation = true;
            if (MessageBox.Show("确认切换当前页面", "警告！", MessageBoxButton.YesNo) == MessageBoxResult.No)
                isNavigation = false;
            continuationCallback(isNavigation);
        }
    }
}
