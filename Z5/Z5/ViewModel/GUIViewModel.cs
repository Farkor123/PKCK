using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ViewModel
{
    public class GUIViewModel : INotifyPropertyChanged
    {
        Lazy<WindowPathGeter> WindowPathGeter = new Lazy<WindowPathGeter>();

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName_)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName_));
        }

        public string pathToXML = "aaa";

        public ICommand getXML { get; }
        public string PathToXML
        {
            get => pathToXML;
            set => pathToXML = value;

        }

        public GUIViewModel()
        {
            getXML = new RelayCommand(Browse);
        }

        private void Browse()
        {
            PathToXML = WindowPathGeter.Value.GetPath();
            RaisePropertyChanged("PathToXML");
            Console.WriteLine("notify " + PathToXML);
        }
    }
}
