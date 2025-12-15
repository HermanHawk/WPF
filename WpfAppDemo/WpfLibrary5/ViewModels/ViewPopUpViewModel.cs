
using Prism.Commands;
using Prism.Dialogs;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using WpfLibrary5.Event;

namespace WpfLibrary5.ViewModels
{
    public class ViewPopUpViewModel : IDialogAware, INotifyPropertyChanged
    {
        public DelegateCommand CancelCommand { get;  set; }
        public DelegateCommand OKCommand { get; set; }
        public ViewPopUpViewModel(IEventAggregator eventAggregator)
        {
            CancelCommand = new DelegateCommand(CancelDemo);
            OKCommand = new DelegateCommand(OKDemo);
            this.eventAggregator = eventAggregator;
        }

        private void OKDemo()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("TestDialogs", "This is TestDialogs Test");
            var dialogResult = new DialogResult
            {
                Result = ButtonResult.OK,
                Parameters = keys
            };

            // Prism 9: 调用 RequestClose 方法
            RequestClose.Invoke(dialogResult);
        }

        private void CancelDemo()
        {
            RequestClose.Invoke(new DialogResult(ButtonResult.No));
            eventAggregator.GetEvent<MessageEvent>().Publish("Hello World!");
            MessageBox.Show("Cancel");
        }

        private string _title = "默认对话框标题";
        private readonly IEventAggregator eventAggregator;

        public string Title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

        public DialogCloseListener RequestClose { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            if (parameters != null && parameters.ContainsKey("title")) 
            {
                Title = parameters.GetValue<string>("title");
            }
        }
    }
}
