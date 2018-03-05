namespace Master
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Button_Minimise = new Master.FlatButton();
            this.Button_Close = new Master.FlatButton();
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Tab_Panel = new System.Windows.Forms.TabControl();
            this.Page_Configuration = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Log_Locations = new System.Windows.Forms.TextBox();
            this.Button_Log_Locations = new Master.FlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Radio_Stop = new System.Windows.Forms.RadioButton();
            this.Radio_Carry_On = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.Tab_Panel.SuspendLayout();
            this.Page_Configuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.Panel_Title.Controls.Add(this.Button_Minimise);
            this.Panel_Title.Controls.Add(this.Button_Close);
            this.Panel_Title.Location = new System.Drawing.Point(-4, -4);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1005, 30);
            this.Panel_Title.TabIndex = 0;
            this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            // 
            // Button_Minimise
            // 
            this.Button_Minimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Minimise.FlatAppearance.BorderSize = 0;
            this.Button_Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Minimise.ForeColor = System.Drawing.Color.White;
            this.Button_Minimise.Location = new System.Drawing.Point(944, 3);
            this.Button_Minimise.Name = "Button_Minimise";
            this.Button_Minimise.Size = new System.Drawing.Size(26, 27);
            this.Button_Minimise.TabIndex = 1;
            this.Button_Minimise.TabStop = false;
            this.Button_Minimise.Text = "-";
            this.Button_Minimise.UseVisualStyleBackColor = false;
            this.Button_Minimise.Click += new System.EventHandler(this.Button_Minimise_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Close.Location = new System.Drawing.Point(976, 3);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(26, 27);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.TabStop = false;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Picture_Logo
            // 
            this.Picture_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Logo.Image")));
            this.Picture_Logo.Location = new System.Drawing.Point(910, 553);
            this.Picture_Logo.Name = "Picture_Logo";
            this.Picture_Logo.Size = new System.Drawing.Size(85, 50);
            this.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Logo.TabIndex = 0;
            this.Picture_Logo.TabStop = false;
            // 
            // Panel_Body
            // 
            this.Panel_Body.BackColor = System.Drawing.Color.White;
            this.Panel_Body.Location = new System.Drawing.Point(2, 25);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(996, 625);
            this.Panel_Body.TabIndex = 1;
            // 
            // Tab_Panel
            // 
            this.Tab_Panel.Controls.Add(this.Page_Configuration);
            this.Tab_Panel.Controls.Add(this.tabPage2);
            this.Tab_Panel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Panel.Location = new System.Drawing.Point(2, 25);
            this.Tab_Panel.Name = "Tab_Panel";
            this.Tab_Panel.SelectedIndex = 0;
            this.Tab_Panel.Size = new System.Drawing.Size(999, 625);
            this.Tab_Panel.TabIndex = 1;
            // 
            // Page_Configuration
            // 
            this.Page_Configuration.Controls.Add(this.label5);
            this.Page_Configuration.Controls.Add(this.Radio_Carry_On);
            this.Page_Configuration.Controls.Add(this.Radio_Stop);
            this.Page_Configuration.Controls.Add(this.label4);
            this.Page_Configuration.Controls.Add(this.Button_Log_Locations);
            this.Page_Configuration.Controls.Add(this.Textbox_Log_Locations);
            this.Page_Configuration.Controls.Add(this.label3);
            this.Page_Configuration.Controls.Add(this.label2);
            this.Page_Configuration.Controls.Add(this.label1);
            this.Page_Configuration.Controls.Add(this.Picture_Logo);
            this.Page_Configuration.Location = new System.Drawing.Point(4, 26);
            this.Page_Configuration.Name = "Page_Configuration";
            this.Page_Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Configuration.Size = new System.Drawing.Size(991, 595);
            this.Page_Configuration.TabIndex = 0;
            this.Page_Configuration.Text = "Configuration";
            this.Page_Configuration.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.75F);
            this.label1.Location = new System.Drawing.Point(328, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the IT Group Development Suite.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.label2.Location = new System.Drawing.Point(282, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Below are some basic configurations I recommend you change.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.label3.Location = new System.Drawing.Point(99, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Log locations";
            // 
            // Textbox_Log_Locations
            // 
            this.Textbox_Log_Locations.Location = new System.Drawing.Point(206, 212);
            this.Textbox_Log_Locations.Name = "Textbox_Log_Locations";
            this.Textbox_Log_Locations.Size = new System.Drawing.Size(618, 25);
            this.Textbox_Log_Locations.TabIndex = 4;
            // 
            // Button_Log_Locations
            // 
            this.Button_Log_Locations.BackColor = System.Drawing.Color.Silver;
            this.Button_Log_Locations.FlatAppearance.BorderSize = 0;
            this.Button_Log_Locations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Log_Locations.Location = new System.Drawing.Point(830, 212);
            this.Button_Log_Locations.Name = "Button_Log_Locations";
            this.Button_Log_Locations.Size = new System.Drawing.Size(35, 25);
            this.Button_Log_Locations.TabIndex = 5;
            this.Button_Log_Locations.TabStop = false;
            this.Button_Log_Locations.Text = "...";
            this.Button_Log_Locations.UseVisualStyleBackColor = false;
            this.Button_Log_Locations.Click += new System.EventHandler(this.Button_Log_Locations_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.label4.Location = new System.Drawing.Point(250, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Would you like to stop when an error is encountered, or log it and carry on?";
            // 
            // Radio_Stop
            // 
            this.Radio_Stop.AutoSize = true;
            this.Radio_Stop.Location = new System.Drawing.Point(365, 369);
            this.Radio_Stop.Name = "Radio_Stop";
            this.Radio_Stop.Size = new System.Drawing.Size(124, 21);
            this.Radio_Stop.TabIndex = 7;
            this.Radio_Stop.TabStop = true;
            this.Radio_Stop.Text = "Stop the program";
            this.Radio_Stop.UseVisualStyleBackColor = true;
            // 
            // Radio_Carry_On
            // 
            this.Radio_Carry_On.AutoSize = true;
            this.Radio_Carry_On.Checked = true;
            this.Radio_Carry_On.Location = new System.Drawing.Point(522, 369);
            this.Radio_Carry_On.Name = "Radio_Carry_On";
            this.Radio_Carry_On.Size = new System.Drawing.Size(147, 21);
            this.Radio_Carry_On.TabIndex = 8;
            this.Radio_Carry_On.TabStop = true;
            this.Radio_Carry_On.Text = "Carry on the program";
            this.Radio_Carry_On.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.75F);
            this.label5.Location = new System.Drawing.Point(426, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "You\'re all good to go.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Tab_Panel);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.Tab_Panel.ResumeLayout(false);
            this.Page_Configuration.ResumeLayout(false);
            this.Page_Configuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Title;
        private FlatButton Button_Close;
        private FlatButton Button_Minimise;
        private System.Windows.Forms.PictureBox Picture_Logo;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.TabControl Tab_Panel;
        private System.Windows.Forms.TabPage Page_Configuration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_Log_Locations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FlatButton Button_Log_Locations;
        private System.Windows.Forms.RadioButton Radio_Carry_On;
        private System.Windows.Forms.RadioButton Radio_Stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

