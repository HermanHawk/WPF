using System.ComponentModel;
using System.Windows;

namespace WpfAppMNNMDemo
{
    //public class ViewModel:INotifyPropertyChanged
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            MyCommand = new MyCommand(Show);
            Name = "Hello World";
        }
        public MyCommand MyCommand { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                //OnPropertyChanged("Name");
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

        //public event PropertyChangedEventHandler PropertyChanged;

        public void Show()
        {
            Name = "this is viewModel!";
            Title = "I am title";
            MessageBox.Show(Name);
        }
    }
}