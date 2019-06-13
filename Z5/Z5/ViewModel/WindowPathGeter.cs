using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ViewModel
{
    public class WindowPathGeter
    {
        public string GetPath(string extension = ".xml")
        {
            OpenFileDialog window = new OpenFileDialog()
            {
                Filter = string.Format("Dynamic Library File(*{0})| *{0}", extension)
            };
            window.ShowDialog();
            if (window.FileName.Length == 0)
            {
                MessageBox.Show("No files selected");
                return "";
            }

            else
                return window.FileName;
        }
    }
}
