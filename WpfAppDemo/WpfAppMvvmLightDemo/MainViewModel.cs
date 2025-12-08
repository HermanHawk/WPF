using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using System.Windows;

namespace WpfAppMvvmLightDemo
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Name = "Hello World";
            ShowCommand = new RelayCommand<string>(Show);
        }
        public RelayCommand<string> ShowCommand { get;}
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }

        public void Show(string text)
        {
            Name = "this is viewModel!";
            Title = "I am title";
            //MessageBox.Show(text);
            Messenger.Default.Send(text, "ReciveMessageAddress");
        }
    }
}