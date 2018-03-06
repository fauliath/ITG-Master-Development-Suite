using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace Master
{
    class PathHandling
    {
        public string OpenFolderLocation()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                return dialog.FileName;
            else
                return null;
        }

        public bool PathIsNotValid(string path)
        {
            if (!Directory.Exists(path))
                return true;
            else
                return false;
        }
    }
}
