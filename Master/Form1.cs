using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master
{
    public partial class MainWindow : Form
    {
        #region Form Behaviour

        public MainWindow() { InitializeComponent(); }

        private void Button_Close_Click(object sender, EventArgs e) { Operation_Running_Prevent_Close(); }

        private void Button_Minimise_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void Move_Form(object sender, MouseEventArgs e) { FormMovement.ReleaseCapture(); FormMovement.SendMessage(this.Handle, 0xA1, 0x2, 0); }

        #endregion

        #region Variables

        // Objects
        PathHandling path_handling = new PathHandling();

        public bool operation_Is_Running = false;
        
        #endregion

        #region Errors

        private void Button_Log_Locations_Click(object sender, EventArgs e) { Error_SetErrorPath(); }

        #endregion

        #region Metadata Extractor

        private void Button_Metadata_Folder_Click(object sender, EventArgs e) { Metadata_SetFolder(); }

        private void Checkbox_Metadata_All_CheckedChanged(object sender, EventArgs e) { Metadata_SelectAllCheckboxes(); }

        private void Button_Metadata_Begin_Click(object sender, EventArgs e) { Metadata_StartBackgroundWorker(); }

        private void Button_Metadata_Output_Location_Click(object sender, EventArgs e) { Metadata_Set_Output_File(); }

        #endregion


    }
}
