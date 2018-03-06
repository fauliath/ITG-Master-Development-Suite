using System;
using System.IO;
using System.Windows.Forms;

namespace Master
{
    public partial class MainWindow : Form
    {
        string error_path;

        public void Error_SetErrorPath()
        {
            // open a folder browser
            error_path = path_handling.OpenFolderLocation();

            // then set the error path on screen so it can be changed
            Textbox_Log_Locations.Text = error_path;
            Textbox_Log_Locations.SelectionStart = Textbox_Log_Locations.Text.Length;
        }

        public void PrintToOutput(string output)
        {
            Textbox_Output.Invoke(new Action(() =>
                Textbox_Output.AppendText("[" + DateTime.Now + "] " + output + Environment.NewLine)
            ));
        }
    }
}
