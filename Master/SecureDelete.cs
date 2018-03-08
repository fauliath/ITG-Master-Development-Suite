using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Master
{
    public partial class MainWindow : Form
    {
        string delete_folder;

        public void Delete_SetFolder()
        {
            delete_folder = path_handling.OpenFolderLocation();

            Textbox_Delete_Folder_Path.Text = delete_folder;
            Textbox_Metadata_Folder.SelectionStart = Textbox_Metadata_Folder.Text.Length;
        }

        private void Delete_Select_All_Checkboxes()
        {
            if (Checkbox_Delete_All.Checked)
            {
                Checkbox_Delete_Encrypt.Checked = true;
                Checkbox_Delete_Metadata.Checked = true;
                Checkbox_Delete_Obfuscate.Checked = true;
                Checkbox_Delete_Overwrite.Checked = true;
                Checkbox_Delete_Truncate.Checked = true;
            }
            else
            {
                Checkbox_Delete_Encrypt.Checked = false;
                Checkbox_Delete_Metadata.Checked = false;
                Checkbox_Delete_Obfuscate.Checked = false;
                Checkbox_Delete_Overwrite.Checked = false;
                Checkbox_Delete_Truncate.Checked = false;
            }
        }

        private void Delete_StartBackgroundWorker()
        {
            delete_folder = Textbox_Delete_Folder_Path.Text;

            if (string.IsNullOrWhiteSpace(delete_folder))
            {
                MessageBox.Show("You must enter a root folder, of which all files inside will be deleted.");
                return;
            }

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += Delete_DoWork;
            worker.RunWorkerCompleted += Delete_RunWorkerCompleted;
            worker.RunWorkerAsync();

            Disable_All_Input();
            operation_Is_Running = true;
        }

        private void Delete_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = Delimon.Win32.IO.Directory.GetFiles(delete_folder, "*", Delimon.Win32.IO.SearchOption.AllDirectories);

            foreach(string file in files)
            {
                if (Checkbox_Delete_Truncate.Checked)
                    Delete_Truncate_File(file);

                if (Checkbox_Delete_Overwrite.Checked)
                    Delete_Overwrite_File(file);

                
            }
           
        }

        private void Delete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            operation_Is_Running = false;
            Enable_All_Input();
        }

        private void Delete_Overwrite_File(string file)
        {
            try
            {
                File.WriteAllText(file, String.Empty);
                PrintToOutput(Path.GetFileName("purged the contents of " + file));

                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.Write(Delete_Generate_Random(500000));
                    stream.Flush();
                    stream.Close();
                }

                PrintToOutput(Path.GetFileName(file) + " contents overwritten with 489KB of garbage characters");
            } catch (Exception ex)
            {
                PrintToOutput(ex.Message);
            }          
        }
        
        private void Delete_Truncate_File(string file)
        {
            try
            {
                FileInfo fi = new FileInfo(file);
                FileStream fs = fi.Open(FileMode.Truncate);
                PrintToOutput("truncating file " + Path.GetFileName(file) + " ...");
                
                PrintToOutput(Path.GetFileName(file) + " truncated to 0 bytes");
            }
            catch (Exception ex)
            {
                PrintToOutput(ex.Message);
            }
        }

        private string Delete_Generate_Random(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString.ToString();
        }
    }
}
