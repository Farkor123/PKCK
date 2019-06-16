using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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

        private books oldBooks;

        #region DataContex
        private string pathToXML;
        private string pathToSchema;
        private string pathToTransform;
        private string pathToTransformInput;
        private string pathToTransformOutput;
        private ObservableCollection<book> books = new ObservableCollection<book>();
        private ObservableCollection<writer> writers = new ObservableCollection<writer>();
        private ObservableCollection<publisher> publishers = new ObservableCollection<publisher>();

        public ICommand getXML { get; }
        public ICommand getTransform { get; }
        public ICommand getTransformInput { get; }
        public ICommand getTransformOutput { get; }
        public ICommand getSchema { get; }
        public ICommand validate { get; }
        public ICommand show { get; }
        public ICommand transform { get; }
        public ICommand saveXML { get; }

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

        public ObservableCollection<book> Books
        {
            get => books;
            set
            {
                books = value;
                RaisePropertyChanged("Books");
            }
        }
        public ObservableCollection<writer> Writers
        {
            get => writers; set
            {
                writers = value;
                RaisePropertyChanged("Writers");
            }
        }

        public ObservableCollection<publisher> Publishers
        {
            get => publishers; set
            {
                publishers = value;
                RaisePropertyChanged("Publishers");
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
            show = new RelayCommand(Show);
            saveXML = new RelayCommand(SaveXML);

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
            PathToTransformOutput = WindowPathGeter.Value.SaveFile();
        }

        private void Transform()
        {
            RunXSLT.Transform(PathToTransformInput, PathToTransformOutput, PathToTransform);
        }

        private void Show()
        {
            books Books = Serialization.DeserializeFile(PathToXML);
            oldBooks = Books;
            Writers = new ObservableCollection<writer>(Books.writersList);
            this.Books = new ObservableCollection<book>(Books.booksList);
            Publishers = new ObservableCollection<publisher>(Books.publishersList);
        }

        private void SaveXML()
        {
            string path = WindowPathGeter.Value.SaveFile("xml");
            if (path == "")
            {
                return;
            }

            if (oldBooks == null)
            {
                return;
            }

            books Books = oldBooks;
            Books.publishersList = Publishers.ToArray();
            Books.writersList = Writers.ToArray();
            Books.booksList = books.ToArray();

            Serialization.SerializeToFile(path, Books);
        }
    }
}
