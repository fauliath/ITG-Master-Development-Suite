using System;
using System.Windows.Forms;

namespace Master
{
    public partial class MainWindow : Form
    {

        public void Disable_All_Input()
        {
            Label_Operation_Finished.Text = "Operation finished at: ";

            // metadata
            Panel_Metadata_Checkboxes.Enabled = false;
            Button_Metadata_Begin.Text = "Running...";
            Button_Metadata_Begin.Enabled = false;
            Label_Metadata_View_Output.Visible = true;
            Textbox_Metadata_Folder.Enabled = false;
            Textbox_Metadata_Output_Location.Enabled = false;
            Button_Metadata_Output_Location.Enabled = false;
            Button_Metadata_Folder.Enabled = false;
            Textbox_Output.Text = "";
            Label_Operation.Text = "Extracting metadata from " + metadata_folder;
            Label_Operation_Start_Time.Text = "Operation started at: " + DateTime.Now;

            // delete
            Textbox_Delete_Folder_Path.Enabled = false;
            Button_Delete_Folder_Picker.Enabled = false;
            Button_Delete_Begin.Enabled = false;
            Button_Delete_Begin.Text = "Running...";
            Panel_Delete_Checkboxes.Enabled = false;
            Label_Operation.Text = "Securely deleting files from " + delete_folder;
            Label_Delete_View_Output.Visible = true;
        }

        public void Enable_All_Input()
        {
            // metadata
            Panel_Metadata_Checkboxes.Enabled = true;
            Button_Metadata_Begin.Text = "Begin Operation";
            Button_Metadata_Begin.Enabled = true;
            Label_Metadata_View_Output.Visible = true;
            Textbox_Metadata_Folder.Enabled = true;
            Button_Metadata_Folder.Enabled = true;
            Label_Operation_Finished.Visible = true;
            Textbox_Metadata_Output_Location.Enabled = true;
            Button_Metadata_Output_Location.Enabled = true;
            Label_Operation_Finished.Text = "Operation finished at: " + DateTime.Now;

            // delete
            Textbox_Delete_Folder_Path.Enabled = true;
            Button_Delete_Folder_Picker.Enabled = true;
            Button_Delete_Begin.Enabled = true;
            Button_Delete_Begin.Text = "Begin Operation";
            Panel_Delete_Checkboxes.Enabled = true;
            Label_Delete_View_Output.Visible = false;
            Label_Operation_Finished.Text = "Operation finished at: " + DateTime.Now;
        }

        public void Operation_Running_Prevent_Close()
        {
            if (operation_Is_Running)
            {
                DialogResult dialog = MessageBox.Show("An operation is currently running, exiting at this time could cause " +
                    "corruption in the file and loss of data.\n" +
                    "Do you wish to close the program?", "Before you go...", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

    }
}
