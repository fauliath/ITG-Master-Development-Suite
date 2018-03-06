using Delimon.Win32.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Master
{
    public partial class MainWindow : Form
    {
        string metadata_folder;
        string metadata_csv_filename = "Metadata Extractor Results.csv";

        public void Metadata_SetFolder()
        {
            metadata_folder = path_handling.OpenFolderLocation();

            Textbox_Metadata_Folder.Text = metadata_folder;
            Textbox_Metadata_Folder.SelectionStart = Textbox_Metadata_Folder.Text.Length;
        }

        public void Metadata_SelectAllCheckboxes()
        {
            if (Checkbox_Metadata_All.Checked)
            {
                Checkbox_Metadata_Filename.Checked = true;
                Checkbox_Metadata_Path.Checked = true;
                Checkbox_Metadata_Extension.Checked = true;
                Checkbox_Metadata_Modified.Checked = true;
                Checkbox_Metadata_Accessed.Checked = true;
                Checkbox_Metadata_Created.Checked = true;
                Checkbox_Metadata_ReadOnly.Checked = true;
                Checkbox_Metadata_Size.Checked = true;
                Checkbox_Metadata_Author.Checked = true;
            }
            else
            {
                Checkbox_Metadata_Filename.Checked = false;
                Checkbox_Metadata_Path.Checked = false;
                Checkbox_Metadata_Extension.Checked = false;
                Checkbox_Metadata_Modified.Checked = false;
                Checkbox_Metadata_Accessed.Checked = false;
                Checkbox_Metadata_Created.Checked = false;
                Checkbox_Metadata_ReadOnly.Checked = false;
                Checkbox_Metadata_Size.Checked = false;
                Checkbox_Metadata_Author.Checked = false;
            }
        }

        public void Metadata_StartBackgroundWorker()
        {
            metadata_folder = Textbox_Metadata_Folder.Text;

            if (string.IsNullOrWhiteSpace(metadata_folder) || path_handling.PathIsNotValid(metadata_folder))
            {
                MessageBox.Show("You must select a folder in order to run this process.");
                return;
            }

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += Metadata_DoWork;
            worker.RunWorkerCompleted += Metadata_RunWorkerCompleted;
            worker.RunWorkerAsync();

            Panel_Metadata_Checkboxes.Enabled = false;
            Button_Metadata_Begin.Text = "Running...";
            Button_Metadata_Begin.Enabled = false;
            Label_Metadata_View_Output.Visible = true;
            Textbox_Metadata_Folder.Enabled = false;
            Button_Metadata_Folder.Enabled = false;
            Textbox_Output.Text = "";
            Label_Operation.Text = "Extracting metadata from " + metadata_folder;
            Label_Operation_Start_Time.Text = "Operation started at: " + DateTime.Now;
        }

        private void Metadata_DoWork(object sender, DoWorkEventArgs e)
        {
            metadata_csv_filename = metadata_folder + "\\" + "Metadata Extractor Results.csv";

            // must be specifically told to use Delimon since this allows long filenames, and System.IO doesn't.
            string[] files = (Delimon.Win32.IO.Directory.GetFiles(metadata_folder, "*", Delimon.Win32.IO.SearchOption.AllDirectories));

            Metadata_WriteHeadersToFile();

            foreach (string file in files)
            {
                List<string> properties = Get_Metadata(file);

                using (StreamWriter stream = new StreamWriter(metadata_csv_filename, true))
                {
                    foreach (string property in properties)
                    {

                        stream.Write(property + ",");
                        PrintToOutput("extracted information from the file '" + Delimon.Win32.IO.Path.GetFileName(file) + "' data: '"+ property + "'");
                    }

                    stream.Write(Environment.NewLine);
                }
            }
        }

        private List<string> Get_Metadata(string file)
        {
            List<string> properties = new List<string>();

            try
            {
                Delimon.Win32.IO.FileInfo fileInfo = new Delimon.Win32.IO.FileInfo(file);


                if (Checkbox_Metadata_Filename.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }
                
                if (Checkbox_Metadata_Path.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }
                
                if (Checkbox_Metadata_Extension.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }
                
                if (Checkbox_Metadata_Modified.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }
                
                if (Checkbox_Metadata_Accessed.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }

                if (Checkbox_Metadata_Created.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }

                if (Checkbox_Metadata_ReadOnly.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }

                if (Checkbox_Metadata_Size.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }

                if (Checkbox_Metadata_Author.Checked)
                    try
                    {
                        properties.Add(Delimon.Win32.IO.Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        PrintToOutput(e.Message);
                    }

            }
            catch (Exception e)
            {
                PrintToOutput(e.Message);
            }

            return properties;
        }

        private void Metadata_WriteHeadersToFile()
        {
            using (StreamWriter stream = new StreamWriter(metadata_csv_filename, false))
            {
                if (Checkbox_Metadata_Filename.Checked)
                    stream.Write("filename,");

                if (Checkbox_Metadata_Path.Checked)
                    stream.Write("full path,");

                if (Checkbox_Metadata_Extension.Checked)
                    stream.Write("extension,");

                if (Checkbox_Metadata_Modified.Checked)
                    stream.Write("modified date,");

                if (Checkbox_Metadata_Accessed.Checked)
                    stream.Write("accessed date,");

                if (Checkbox_Metadata_Created.Checked)
                    stream.Write("created date,");

                if (Checkbox_Metadata_ReadOnly.Checked)
                    stream.Write("read only,");

                if (Checkbox_Metadata_Size.Checked)
                    stream.Write("file size (bytes),");

                if (Checkbox_Metadata_Author.Checked)
                    stream.Write("author,");

                stream.Write(Environment.NewLine);
            }
        }

        private void Metadata_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Panel_Metadata_Checkboxes.Enabled = true;
            Button_Metadata_Begin.Text = "Begin Operation";
            Button_Metadata_Begin.Enabled = true;
            Label_Metadata_View_Output.Visible = true;
            Textbox_Metadata_Folder.Enabled = true;
            Button_Metadata_Folder.Enabled = true;
            Label_Operation_Finished.Text = "Operation finished at: " + DateTime.Now;
        }
    }
}
