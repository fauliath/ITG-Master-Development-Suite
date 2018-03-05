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

        private void Button_Close_Click(object sender, EventArgs e) { Close(); }

        private void Button_Minimise_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void Move_Form(object sender, MouseEventArgs e) { FormMovement.ReleaseCapture(); FormMovement.SendMessage(this.Handle, 0xA1, 0x2, 0); }



        #endregion

        private void Button_Log_Locations_Click(object sender, EventArgs e)
        {

        }
    }
}
