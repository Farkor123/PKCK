using Logic;
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
        private string pathToTransformInput;
        private string pathToTransformOutput;

        public ICommand getXML { get; }
        public ICommand getTransform { get; }
        public ICommand getTransformInput { get; }
        public ICommand getTransformOutput { get; }
        public ICommand getSchema { get; }
        public ICommand validate { get; }
        public ICommand show { get; }
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

        public string PathToTransformInput
        {
            get => pathToTransformInput;
            set
            {
                pathToTransformInput = value;
                RaisePropertyChanged("PathToTransformInput");
            }
        }
        public string PathToTransformOutput
        {
            get => pathToTransformOutput; set
            {
                pathToTransformOutput = value;
                RaisePropertyChanged("PathToTransformOutput");
            }
        }
        #endregion

        public GUIViewModel()
        {
            getXML = new RelayCommand(GetXML);
            getTransform = new RelayCommand(GetTransform);
            getTransformOutput = new RelayCommand(GetTransformOutput);
            getTransformInput = new RelayCommand(GetTransformInput);
            getSchema = new RelayCommand(GetSchema);
            transform = new RelayCommand(Transform);

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
        private void GetTransformInput()
        {
            PathToTransformInput = WindowPathGeter.Value.GetPath("xml");
        }
        private void GetTransformOutput()
        {
            PathToTransformOutput = WindowPathGeter.Value.GetPath();
        }

        private void Transform()
        {
            RunXSLT.Transform(PathToTransformInput, PathToTransformOutput, PathToTransform);
        }
    }
}
