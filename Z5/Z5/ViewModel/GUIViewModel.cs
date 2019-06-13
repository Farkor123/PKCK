using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class GUIViewModel: INotifyPropertyChanged
    {
        Lazy<WindowPathGeter> WindowPathGeter = new Lazy<WindowPathGeter>();

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName_)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName_));
        }

        public string pathToXML;

        public ICommand getXML { get; }
        public string PathToXML
        {
            get => pathToXML;
            set
            {
                pathToXML = value;
                RaisePropertyChanged("PathToXML");
                Console.WriteLine("notify");
            }
            
        }

        public GUIViewModel()
        {
            getXML = new RelayCommand(Browse);
        }

        private void Browse()
        {
            PathToXML = WindowPathGeter.Value.GetPath();

            Console.WriteLine(PathToXML);
        }
    }
}
