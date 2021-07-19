using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BTv2._0.EssentialFunction
{
    sealed class PrintText
    {
        internal void SaveFile(string swrite)
        {
            while (swrite != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                {
                    
                    sfd.FileName = "*";
                    sfd.Filter = "Text file (*.txt)|*.txt";
                    sfd.DefaultExt = "txt";
                    sfd.FilterIndex = 0;
                    sfd.RestoreDirectory = true;
                    sfd.Title = "Save File";
                    sfd.CheckFileExists = false;
                    sfd.CheckPathExists = false;
                    sfd.OverwritePrompt = true;
                    sfd.ValidateNames = true;
                };

                while (sfd.ShowDialog() == true)
                {
                    File.WriteAllText(sfd.FileName, swrite);
                    break;
                }
                break;
            }
        }

        internal void SaveRecit(string name, string swrite)
        {
            while (swrite != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                {

                    sfd.FileName = name;
                    sfd.Filter = "Text file (*.txt)|*.txt";
                    sfd.DefaultExt = "txt";
                    sfd.FilterIndex = 0;
                    sfd.RestoreDirectory = true;
                    sfd.Title = "Save File";
                    sfd.CheckFileExists = false;
                    sfd.CheckPathExists = false;
                    sfd.OverwritePrompt = true;
                    sfd.ValidateNames = true;
                };

                while (sfd.ShowDialog() == true)
                {
                    File.WriteAllText(sfd.FileName, swrite);
                    break;
                }
                break;
            }
        }
    }
}
