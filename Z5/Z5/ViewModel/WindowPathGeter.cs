using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ViewModel
{
    public class WindowPathGeter
    {
        public string GetPath(string extension = "")
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

        public string[] GetMultiplePath(string extension = "")
        {
            OpenFileDialog window = new OpenFileDialog()
            {
                Filter = string.Format("Dynamic Library File(*{0})| *{0}", extension),
                Multiselect = true
            };
            window.ShowDialog();
            if (window.FileName.Length == 0)
            {
                MessageBox.Show("No files selected");
                return Array.Empty<string>();
            }

            else
                return window.FileNames;
        }

        public string SaveFile(string extension = "")
        {
            SaveFileDialog window = new SaveFileDialog()
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

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
    }
}
