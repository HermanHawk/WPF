using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.ComponentModel;
using System.Windows;

namespace WpfAppMvvmToolkitMvVVM
{
    public class MainViewModel : ObservableObject
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
                OnPropertyChanged();
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public void Show(string text)
        {
            Name = "this is viewModel!";
            Title = "I am title";
            WeakReferenceMessenger.Default.Send(text, "ReciveMessageAddress");
        }
    }
}