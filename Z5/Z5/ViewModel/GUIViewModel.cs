using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class GUIViewModel
    {
        Lazy<WindowPathGeter> WindowPathGeter = new Lazy<WindowPathGeter>();

        public string pathToXMl { get; set; }

        public ICommand getXML { get; }

        public GUIViewModel()
        {
            getXML = new RelayCommand(Browse);
            Console.WriteLine("dup123");
        }

        private void Browse()
        {
            pathToXMl = "aaaa";
            Console.WriteLine("clic");
            pathToXMl = WindowPathGeter.Value.GetPath();
        }
    }
}
