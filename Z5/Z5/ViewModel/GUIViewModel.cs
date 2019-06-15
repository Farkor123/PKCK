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

        #region DataContex
        private string pathToXML;
        private string pathToSchema;
        private string pathToTransform;

        public ICommand getXML { get; }
        public ICommand getTransform { get; }
        public ICommand getSchema { get; }
        public ICommand validate { get; }
        public ICommand show { get}
        public ICommand transform { get; }

        public string PathToXML
        {
            get => pathToXML;
            set
            {
                pathToXML = value;
                RaisePropertyChanged("PathToXML");
            }

        }

        public string PathToSchema
        {
            get => pathToSchema;
            set
            {
                pathToSchema = value;
                RaisePropertyChanged("PathToSchema");
            }
        }
        public string PathToTransform
        {
            get => pathToTransform;
            set
            {
                pathToTransform = value;
                RaisePropertyChanged("PathToTransform");
            }
        }
        #endregion
        public GUIViewModel()
        {
            getXML = new RelayCommand(GetXML);
            getTransform = new RelayCommand(GetTransform);
            getSchema = new RelayCommand(GetSchema);
        }

        private void GetXML()
        {
            PathToXML = WindowPathGeter.Value.GetPath("xml");
        }
        private void GetSchema()
        {
            PathToSchema = WindowPathGeter.Value.GetPath("xsd");
        }
        private void GetTransform()
        {
            PathToTransform = WindowPathGeter.Value.GetPath("xsl");
        }
    }
}
