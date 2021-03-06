﻿namespace Master
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
            this.Picture_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Page_Delete = new System.Windows.Forms.TabControl();
            this.Page_Configuration = new System.Windows.Forms.TabPage();
            this.Radio_Carry_On = new System.Windows.Forms.RadioButton();
            this.Radio_Stop = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Textbox_Log_Locations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Page_Metadata = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Textbox_Metadata_Output_Location = new System.Windows.Forms.TextBox();
            this.Label_Metadata_View_Output = new System.Windows.Forms.Label();
            this.Panel_Metadata_Checkboxes = new System.Windows.Forms.Panel();
            this.Checkbox_Metadata_All = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Size = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_ReadOnly = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Author = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Accessed = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Modified = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Created = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Extension = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Path = new System.Windows.Forms.CheckBox();
            this.Checkbox_Metadata_Filename = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Metadata_Folder = new System.Windows.Forms.Label();
            this.Textbox_Metadata_Folder = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Panel_Delete_Checkboxes = new System.Windows.Forms.Panel();
            this.Checkbox_Delete_All = new System.Windows.Forms.CheckBox();
            this.Checkbox_Delete_Metadata = new System.Windows.Forms.CheckBox();
            this.Checkbox_Delete_Encrypt = new System.Windows.Forms.CheckBox();
            this.Checkbox_Delete_Truncate = new System.Windows.Forms.CheckBox();
            this.Checkbox_Delete_Obfuscate = new System.Windows.Forms.CheckBox();
            this.Checkbox_Delete_Overwrite = new System.Windows.Forms.CheckBox();
            this.Label_Delete_View_Output = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Textbox_Delete_Folder_Path = new System.Windows.Forms.TextBox();
            this.Page_Output = new System.Windows.Forms.TabPage();
            this.Label_Operation_Finished = new System.Windows.Forms.Label();
            this.Label_Operation = new System.Windows.Forms.Label();
            this.Label_Operation_Start_Time = new System.Windows.Forms.Label();
            this.Textbox_Output = new System.Windows.Forms.TextBox();
            this.Button_Log_Locations = new Master.FlatButton();
            this.Button_Metadata_Output_Location = new Master.FlatButton();
            this.Button_Metadata_Begin = new Master.FlatButton();
            this.Button_Metadata_Folder = new Master.FlatButton();
            this.Button_Delete_Begin = new Master.FlatButton();
            this.Button_Delete_Folder_Picker = new Master.FlatButton();
            this.Button_Minimise = new Master.FlatButton();
            this.Button_Close = new Master.FlatButton();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).BeginInit();
            this.Page_Delete.SuspendLayout();
            this.Page_Configuration.SuspendLayout();
            this.Page_Metadata.SuspendLayout();
            this.Panel_Metadata_Checkboxes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Panel_Delete_Checkboxes.SuspendLayout();
            this.Page_Output.SuspendLayout();
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
            // Page_Delete
            // 
            this.Page_Delete.Controls.Add(this.Page_Configuration);
            this.Page_Delete.Controls.Add(this.Page_Metadata);
            this.Page_Delete.Controls.Add(this.tabPage1);
            this.Page_Delete.Controls.Add(this.Page_Output);
            this.Page_Delete.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_Delete.Location = new System.Drawing.Point(2, 25);
            this.Page_Delete.Name = "Page_Delete";
            this.Page_Delete.SelectedIndex = 0;
            this.Page_Delete.Size = new System.Drawing.Size(999, 625);
            this.Page_Delete.TabIndex = 1;
            // 
            // Page_Configuration
            // 
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
            // Radio_Carry_On
            // 
            this.Radio_Carry_On.AutoSize = true;
            this.Radio_Carry_On.Checked = true;
            this.Radio_Carry_On.Enabled = false;
            this.Radio_Carry_On.Location = new System.Drawing.Point(522, 369);
            this.Radio_Carry_On.Name = "Radio_Carry_On";
            this.Radio_Carry_On.Size = new System.Drawing.Size(147, 21);
            this.Radio_Carry_On.TabIndex = 8;
            this.Radio_Carry_On.TabStop = true;
            this.Radio_Carry_On.Text = "Carry on the program";
            this.Radio_Carry_On.UseVisualStyleBackColor = true;
            // 
            // Radio_Stop
            // 
            this.Radio_Stop.AutoSize = true;
            this.Radio_Stop.Enabled = false;
            this.Radio_Stop.Location = new System.Drawing.Point(365, 369);
            this.Radio_Stop.Name = "Radio_Stop";
            this.Radio_Stop.Size = new System.Drawing.Size(124, 21);
            this.Radio_Stop.TabIndex = 7;
            this.Radio_Stop.TabStop = true;
            this.Radio_Stop.Text = "Stop the program";
            this.Radio_Stop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.label4.Location = new System.Drawing.Point(250, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Would you like to stop when an error is encountered, or log it and carry on?";
            // 
            // Textbox_Log_Locations
            // 
            this.Textbox_Log_Locations.Enabled = false;
            this.Textbox_Log_Locations.Location = new System.Drawing.Point(206, 212);
            this.Textbox_Log_Locations.Name = "Textbox_Log_Locations";
            this.Textbox_Log_Locations.Size = new System.Drawing.Size(618, 25);
            this.Textbox_Log_Locations.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.75F);
            this.label3.Location = new System.Drawing.Point(99, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Log locations";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.75F);
            this.label1.Location = new System.Drawing.Point(400, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "IT Group C# Tools.";
            // 
            // Page_Metadata
            // 
            this.Page_Metadata.Controls.Add(this.label6);
            this.Page_Metadata.Controls.Add(this.label8);
            this.Page_Metadata.Controls.Add(this.Textbox_Metadata_Output_Location);
            this.Page_Metadata.Controls.Add(this.Label_Metadata_View_Output);
            this.Page_Metadata.Controls.Add(this.Panel_Metadata_Checkboxes);
            this.Page_Metadata.Controls.Add(this.label5);
            this.Page_Metadata.Controls.Add(this.Label_Metadata_Folder);
            this.Page_Metadata.Controls.Add(this.Textbox_Metadata_Folder);
            this.Page_Metadata.Controls.Add(this.Button_Metadata_Output_Location);
            this.Page_Metadata.Controls.Add(this.Button_Metadata_Begin);
            this.Page_Metadata.Controls.Add(this.Button_Metadata_Folder);
            this.Page_Metadata.Location = new System.Drawing.Point(4, 26);
            this.Page_Metadata.Name = "Page_Metadata";
            this.Page_Metadata.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Metadata.Size = new System.Drawing.Size(991, 595);
            this.Page_Metadata.TabIndex = 1;
            this.Page_Metadata.Text = "Metadata";
            this.Page_Metadata.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 7.75F);
            this.label6.Location = new System.Drawing.Point(119, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "You can dynamically create the file path in this output";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label8.Location = new System.Drawing.Point(115, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Select the location for the output file";
            // 
            // Textbox_Metadata_Output_Location
            // 
            this.Textbox_Metadata_Output_Location.Location = new System.Drawing.Point(119, 180);
            this.Textbox_Metadata_Output_Location.Name = "Textbox_Metadata_Output_Location";
            this.Textbox_Metadata_Output_Location.Size = new System.Drawing.Size(723, 25);
            this.Textbox_Metadata_Output_Location.TabIndex = 9;
            // 
            // Label_Metadata_View_Output
            // 
            this.Label_Metadata_View_Output.AutoSize = true;
            this.Label_Metadata_View_Output.Font = new System.Drawing.Font("Segoe UI Semilight", 7.75F);
            this.Label_Metadata_View_Output.Location = new System.Drawing.Point(388, 542);
            this.Label_Metadata_View_Output.Name = "Label_Metadata_View_Output";
            this.Label_Metadata_View_Output.Size = new System.Drawing.Size(195, 13);
            this.Label_Metadata_View_Output.TabIndex = 7;
            this.Label_Metadata_View_Output.Text = "Navigate to the output tab to view status";
            this.Label_Metadata_View_Output.Visible = false;
            // 
            // Panel_Metadata_Checkboxes
            // 
            this.Panel_Metadata_Checkboxes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_All);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Size);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_ReadOnly);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Author);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Accessed);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Modified);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Created);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Extension);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Path);
            this.Panel_Metadata_Checkboxes.Controls.Add(this.Checkbox_Metadata_Filename);
            this.Panel_Metadata_Checkboxes.Location = new System.Drawing.Point(2, 250);
            this.Panel_Metadata_Checkboxes.Name = "Panel_Metadata_Checkboxes";
            this.Panel_Metadata_Checkboxes.Size = new System.Drawing.Size(989, 197);
            this.Panel_Metadata_Checkboxes.TabIndex = 5;
            // 
            // Checkbox_Metadata_All
            // 
            this.Checkbox_Metadata_All.AutoSize = true;
            this.Checkbox_Metadata_All.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_All.Location = new System.Drawing.Point(757, 147);
            this.Checkbox_Metadata_All.Name = "Checkbox_Metadata_All";
            this.Checkbox_Metadata_All.Size = new System.Drawing.Size(120, 21);
            this.Checkbox_Metadata_All.TabIndex = 10;
            this.Checkbox_Metadata_All.Text = "All of the Above";
            this.Checkbox_Metadata_All.UseVisualStyleBackColor = true;
            this.Checkbox_Metadata_All.CheckedChanged += new System.EventHandler(this.Checkbox_Metadata_All_CheckedChanged);
            // 
            // Checkbox_Metadata_Size
            // 
            this.Checkbox_Metadata_Size.AutoSize = true;
            this.Checkbox_Metadata_Size.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Size.Location = new System.Drawing.Point(756, 71);
            this.Checkbox_Metadata_Size.Name = "Checkbox_Metadata_Size";
            this.Checkbox_Metadata_Size.Size = new System.Drawing.Size(121, 21);
            this.Checkbox_Metadata_Size.TabIndex = 9;
            this.Checkbox_Metadata_Size.Text = "File Size in Bytes";
            this.Checkbox_Metadata_Size.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_ReadOnly
            // 
            this.Checkbox_Metadata_ReadOnly.AutoSize = true;
            this.Checkbox_Metadata_ReadOnly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_ReadOnly.Location = new System.Drawing.Point(756, 31);
            this.Checkbox_Metadata_ReadOnly.Name = "Checkbox_Metadata_ReadOnly";
            this.Checkbox_Metadata_ReadOnly.Size = new System.Drawing.Size(87, 21);
            this.Checkbox_Metadata_ReadOnly.TabIndex = 8;
            this.Checkbox_Metadata_ReadOnly.Text = "Read Only";
            this.Checkbox_Metadata_ReadOnly.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Author
            // 
            this.Checkbox_Metadata_Author.AutoSize = true;
            this.Checkbox_Metadata_Author.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Author.Location = new System.Drawing.Point(756, 108);
            this.Checkbox_Metadata_Author.Name = "Checkbox_Metadata_Author";
            this.Checkbox_Metadata_Author.Size = new System.Drawing.Size(66, 21);
            this.Checkbox_Metadata_Author.TabIndex = 6;
            this.Checkbox_Metadata_Author.Text = "Author";
            this.Checkbox_Metadata_Author.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Accessed
            // 
            this.Checkbox_Metadata_Accessed.AutoSize = true;
            this.Checkbox_Metadata_Accessed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Accessed.Location = new System.Drawing.Point(426, 71);
            this.Checkbox_Metadata_Accessed.Name = "Checkbox_Metadata_Accessed";
            this.Checkbox_Metadata_Accessed.Size = new System.Drawing.Size(102, 21);
            this.Checkbox_Metadata_Accessed.TabIndex = 5;
            this.Checkbox_Metadata_Accessed.Text = "Accessed On";
            this.Checkbox_Metadata_Accessed.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Modified
            // 
            this.Checkbox_Metadata_Modified.AutoSize = true;
            this.Checkbox_Metadata_Modified.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Modified.Location = new System.Drawing.Point(426, 31);
            this.Checkbox_Metadata_Modified.Name = "Checkbox_Metadata_Modified";
            this.Checkbox_Metadata_Modified.Size = new System.Drawing.Size(101, 21);
            this.Checkbox_Metadata_Modified.TabIndex = 4;
            this.Checkbox_Metadata_Modified.Text = "Modified On";
            this.Checkbox_Metadata_Modified.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Created
            // 
            this.Checkbox_Metadata_Created.AutoSize = true;
            this.Checkbox_Metadata_Created.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Created.Location = new System.Drawing.Point(426, 108);
            this.Checkbox_Metadata_Created.Name = "Checkbox_Metadata_Created";
            this.Checkbox_Metadata_Created.Size = new System.Drawing.Size(94, 21);
            this.Checkbox_Metadata_Created.TabIndex = 3;
            this.Checkbox_Metadata_Created.Text = "Created On";
            this.Checkbox_Metadata_Created.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Extension
            // 
            this.Checkbox_Metadata_Extension.AutoSize = true;
            this.Checkbox_Metadata_Extension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Extension.Location = new System.Drawing.Point(120, 108);
            this.Checkbox_Metadata_Extension.Name = "Checkbox_Metadata_Extension";
            this.Checkbox_Metadata_Extension.Size = new System.Drawing.Size(82, 21);
            this.Checkbox_Metadata_Extension.TabIndex = 2;
            this.Checkbox_Metadata_Extension.Text = "Extension";
            this.Checkbox_Metadata_Extension.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Path
            // 
            this.Checkbox_Metadata_Path.AutoSize = true;
            this.Checkbox_Metadata_Path.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Path.Location = new System.Drawing.Point(120, 71);
            this.Checkbox_Metadata_Path.Name = "Checkbox_Metadata_Path";
            this.Checkbox_Metadata_Path.Size = new System.Drawing.Size(75, 21);
            this.Checkbox_Metadata_Path.TabIndex = 1;
            this.Checkbox_Metadata_Path.Text = "Full Path";
            this.Checkbox_Metadata_Path.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Metadata_Filename
            // 
            this.Checkbox_Metadata_Filename.AutoSize = true;
            this.Checkbox_Metadata_Filename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Metadata_Filename.Location = new System.Drawing.Point(120, 31);
            this.Checkbox_Metadata_Filename.Name = "Checkbox_Metadata_Filename";
            this.Checkbox_Metadata_Filename.Size = new System.Drawing.Size(85, 21);
            this.Checkbox_Metadata_Filename.TabIndex = 0;
            this.Checkbox_Metadata_Filename.Text = "File Name";
            this.Checkbox_Metadata_Filename.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.75F);
            this.label5.Location = new System.Drawing.Point(400, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Metadata Extractor";
            // 
            // Label_Metadata_Folder
            // 
            this.Label_Metadata_Folder.AutoSize = true;
            this.Label_Metadata_Folder.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.Label_Metadata_Folder.Location = new System.Drawing.Point(115, 53);
            this.Label_Metadata_Folder.Name = "Label_Metadata_Folder";
            this.Label_Metadata_Folder.Size = new System.Drawing.Size(115, 20);
            this.Label_Metadata_Folder.TabIndex = 1;
            this.Label_Metadata_Folder.Text = "Select the folder";
            // 
            // Textbox_Metadata_Folder
            // 
            this.Textbox_Metadata_Folder.Location = new System.Drawing.Point(119, 76);
            this.Textbox_Metadata_Folder.Name = "Textbox_Metadata_Folder";
            this.Textbox_Metadata_Folder.Size = new System.Drawing.Size(723, 25);
            this.Textbox_Metadata_Folder.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Panel_Delete_Checkboxes);
            this.tabPage1.Controls.Add(this.Label_Delete_View_Output);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Textbox_Delete_Folder_Path);
            this.tabPage1.Controls.Add(this.Button_Delete_Begin);
            this.tabPage1.Controls.Add(this.Button_Delete_Folder_Picker);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 595);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Secure Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Panel_Delete_Checkboxes
            // 
            this.Panel_Delete_Checkboxes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_All);
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_Metadata);
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_Encrypt);
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_Truncate);
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_Obfuscate);
            this.Panel_Delete_Checkboxes.Controls.Add(this.Checkbox_Delete_Overwrite);
            this.Panel_Delete_Checkboxes.Location = new System.Drawing.Point(1, 199);
            this.Panel_Delete_Checkboxes.Name = "Panel_Delete_Checkboxes";
            this.Panel_Delete_Checkboxes.Size = new System.Drawing.Size(989, 197);
            this.Panel_Delete_Checkboxes.TabIndex = 8;
            // 
            // Checkbox_Delete_All
            // 
            this.Checkbox_Delete_All.AutoSize = true;
            this.Checkbox_Delete_All.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_All.Location = new System.Drawing.Point(756, 71);
            this.Checkbox_Delete_All.Name = "Checkbox_Delete_All";
            this.Checkbox_Delete_All.Size = new System.Drawing.Size(119, 21);
            this.Checkbox_Delete_All.TabIndex = 9;
            this.Checkbox_Delete_All.Text = "All of the above";
            this.Checkbox_Delete_All.UseVisualStyleBackColor = true;
            this.Checkbox_Delete_All.CheckedChanged += new System.EventHandler(this.Delete_Select_All_Checkboxes);
            // 
            // Checkbox_Delete_Metadata
            // 
            this.Checkbox_Delete_Metadata.AutoSize = true;
            this.Checkbox_Delete_Metadata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_Metadata.Location = new System.Drawing.Point(756, 31);
            this.Checkbox_Delete_Metadata.Name = "Checkbox_Delete_Metadata";
            this.Checkbox_Delete_Metadata.Size = new System.Drawing.Size(130, 21);
            this.Checkbox_Delete_Metadata.TabIndex = 8;
            this.Checkbox_Delete_Metadata.Text = "Change metadata";
            this.Checkbox_Delete_Metadata.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Delete_Encrypt
            // 
            this.Checkbox_Delete_Encrypt.AutoSize = true;
            this.Checkbox_Delete_Encrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_Encrypt.Location = new System.Drawing.Point(426, 71);
            this.Checkbox_Delete_Encrypt.Name = "Checkbox_Delete_Encrypt";
            this.Checkbox_Delete_Encrypt.Size = new System.Drawing.Size(164, 21);
            this.Checkbox_Delete_Encrypt.TabIndex = 5;
            this.Checkbox_Delete_Encrypt.Text = "Encrypt before deletion";
            this.Checkbox_Delete_Encrypt.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Delete_Truncate
            // 
            this.Checkbox_Delete_Truncate.AutoSize = true;
            this.Checkbox_Delete_Truncate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_Truncate.Location = new System.Drawing.Point(426, 31);
            this.Checkbox_Delete_Truncate.Name = "Checkbox_Delete_Truncate";
            this.Checkbox_Delete_Truncate.Size = new System.Drawing.Size(123, 21);
            this.Checkbox_Delete_Truncate.TabIndex = 4;
            this.Checkbox_Delete_Truncate.Text = "Truncate content";
            this.Checkbox_Delete_Truncate.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Delete_Obfuscate
            // 
            this.Checkbox_Delete_Obfuscate.AutoSize = true;
            this.Checkbox_Delete_Obfuscate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_Obfuscate.Location = new System.Drawing.Point(120, 71);
            this.Checkbox_Delete_Obfuscate.Name = "Checkbox_Delete_Obfuscate";
            this.Checkbox_Delete_Obfuscate.Size = new System.Drawing.Size(187, 21);
            this.Checkbox_Delete_Obfuscate.TabIndex = 1;
            this.Checkbox_Delete_Obfuscate.Text = "Obfuscate before overwrite";
            this.Checkbox_Delete_Obfuscate.UseVisualStyleBackColor = true;
            // 
            // Checkbox_Delete_Overwrite
            // 
            this.Checkbox_Delete_Overwrite.AutoSize = true;
            this.Checkbox_Delete_Overwrite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox_Delete_Overwrite.Location = new System.Drawing.Point(120, 31);
            this.Checkbox_Delete_Overwrite.Name = "Checkbox_Delete_Overwrite";
            this.Checkbox_Delete_Overwrite.Size = new System.Drawing.Size(130, 21);
            this.Checkbox_Delete_Overwrite.TabIndex = 0;
            this.Checkbox_Delete_Overwrite.Text = "Overwrite content";
            this.Checkbox_Delete_Overwrite.UseVisualStyleBackColor = true;
            // 
            // Label_Delete_View_Output
            // 
            this.Label_Delete_View_Output.AutoSize = true;
            this.Label_Delete_View_Output.Font = new System.Drawing.Font("Segoe UI Semilight", 7.75F);
            this.Label_Delete_View_Output.Location = new System.Drawing.Point(388, 542);
            this.Label_Delete_View_Output.Name = "Label_Delete_View_Output";
            this.Label_Delete_View_Output.Size = new System.Drawing.Size(195, 13);
            this.Label_Delete_View_Output.TabIndex = 7;
            this.Label_Delete_View_Output.Text = "Navigate to the output tab to view status";
            this.Label_Delete_View_Output.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 14.75F);
            this.label13.Location = new System.Drawing.Point(400, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "Secure Delete";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label14.Location = new System.Drawing.Point(115, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(312, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Select the folder that contains all files to delete";
            // 
            // Textbox_Delete_Folder_Path
            // 
            this.Textbox_Delete_Folder_Path.Location = new System.Drawing.Point(119, 76);
            this.Textbox_Delete_Folder_Path.Name = "Textbox_Delete_Folder_Path";
            this.Textbox_Delete_Folder_Path.Size = new System.Drawing.Size(723, 25);
            this.Textbox_Delete_Folder_Path.TabIndex = 0;
            // 
            // Page_Output
            // 
            this.Page_Output.Controls.Add(this.Label_Operation_Finished);
            this.Page_Output.Controls.Add(this.Label_Operation);
            this.Page_Output.Controls.Add(this.Label_Operation_Start_Time);
            this.Page_Output.Controls.Add(this.Textbox_Output);
            this.Page_Output.Location = new System.Drawing.Point(4, 26);
            this.Page_Output.Name = "Page_Output";
            this.Page_Output.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Output.Size = new System.Drawing.Size(991, 595);
            this.Page_Output.TabIndex = 2;
            this.Page_Output.Text = "Output";
            this.Page_Output.UseVisualStyleBackColor = true;
            // 
            // Label_Operation_Finished
            // 
            this.Label_Operation_Finished.AutoSize = true;
            this.Label_Operation_Finished.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.Label_Operation_Finished.Location = new System.Drawing.Point(550, 62);
            this.Label_Operation_Finished.Name = "Label_Operation_Finished";
            this.Label_Operation_Finished.Size = new System.Drawing.Size(148, 20);
            this.Label_Operation_Finished.TabIndex = 3;
            this.Label_Operation_Finished.Text = "Operation finished at:";
            this.Label_Operation_Finished.Visible = false;
            // 
            // Label_Operation
            // 
            this.Label_Operation.AutoSize = true;
            this.Label_Operation.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.Label_Operation.Location = new System.Drawing.Point(30, 19);
            this.Label_Operation.Name = "Label_Operation";
            this.Label_Operation.Size = new System.Drawing.Size(78, 20);
            this.Label_Operation.TabIndex = 2;
            this.Label_Operation.Text = "Operation:";
            // 
            // Label_Operation_Start_Time
            // 
            this.Label_Operation_Start_Time.AutoSize = true;
            this.Label_Operation_Start_Time.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.Label_Operation_Start_Time.Location = new System.Drawing.Point(30, 62);
            this.Label_Operation_Start_Time.Name = "Label_Operation_Start_Time";
            this.Label_Operation_Start_Time.Size = new System.Drawing.Size(145, 20);
            this.Label_Operation_Start_Time.TabIndex = 1;
            this.Label_Operation_Start_Time.Text = "Operation started at:";
            // 
            // Textbox_Output
            // 
            this.Textbox_Output.Location = new System.Drawing.Point(34, 98);
            this.Textbox_Output.Multiline = true;
            this.Textbox_Output.Name = "Textbox_Output";
            this.Textbox_Output.ReadOnly = true;
            this.Textbox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Textbox_Output.Size = new System.Drawing.Size(926, 466);
            this.Textbox_Output.TabIndex = 0;
            // 
            // Button_Log_Locations
            // 
            this.Button_Log_Locations.BackColor = System.Drawing.Color.Silver;
            this.Button_Log_Locations.Enabled = false;
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
            // Button_Metadata_Output_Location
            // 
            this.Button_Metadata_Output_Location.BackColor = System.Drawing.Color.Silver;
            this.Button_Metadata_Output_Location.FlatAppearance.BorderSize = 0;
            this.Button_Metadata_Output_Location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Metadata_Output_Location.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.Button_Metadata_Output_Location.ForeColor = System.Drawing.Color.Black;
            this.Button_Metadata_Output_Location.Location = new System.Drawing.Point(848, 180);
            this.Button_Metadata_Output_Location.Name = "Button_Metadata_Output_Location";
            this.Button_Metadata_Output_Location.Size = new System.Drawing.Size(37, 25);
            this.Button_Metadata_Output_Location.TabIndex = 11;
            this.Button_Metadata_Output_Location.TabStop = false;
            this.Button_Metadata_Output_Location.Text = "...";
            this.Button_Metadata_Output_Location.UseVisualStyleBackColor = false;
            this.Button_Metadata_Output_Location.Click += new System.EventHandler(this.Button_Metadata_Output_Location_Click);
            // 
            // Button_Metadata_Begin
            // 
            this.Button_Metadata_Begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Metadata_Begin.FlatAppearance.BorderSize = 0;
            this.Button_Metadata_Begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Metadata_Begin.Font = new System.Drawing.Font("Segoe UI Semilight", 13.75F);
            this.Button_Metadata_Begin.ForeColor = System.Drawing.Color.White;
            this.Button_Metadata_Begin.Location = new System.Drawing.Point(405, 496);
            this.Button_Metadata_Begin.Name = "Button_Metadata_Begin";
            this.Button_Metadata_Begin.Size = new System.Drawing.Size(167, 43);
            this.Button_Metadata_Begin.TabIndex = 6;
            this.Button_Metadata_Begin.TabStop = false;
            this.Button_Metadata_Begin.Text = "Begin Operation";
            this.Button_Metadata_Begin.UseVisualStyleBackColor = false;
            this.Button_Metadata_Begin.Click += new System.EventHandler(this.Button_Metadata_Begin_Click);
            // 
            // Button_Metadata_Folder
            // 
            this.Button_Metadata_Folder.BackColor = System.Drawing.Color.Silver;
            this.Button_Metadata_Folder.FlatAppearance.BorderSize = 0;
            this.Button_Metadata_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Metadata_Folder.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.Button_Metadata_Folder.ForeColor = System.Drawing.Color.Black;
            this.Button_Metadata_Folder.Location = new System.Drawing.Point(848, 76);
            this.Button_Metadata_Folder.Name = "Button_Metadata_Folder";
            this.Button_Metadata_Folder.Size = new System.Drawing.Size(37, 25);
            this.Button_Metadata_Folder.TabIndex = 2;
            this.Button_Metadata_Folder.TabStop = false;
            this.Button_Metadata_Folder.Text = "...";
            this.Button_Metadata_Folder.UseVisualStyleBackColor = false;
            this.Button_Metadata_Folder.Click += new System.EventHandler(this.Button_Metadata_Folder_Click);
            // 
            // Button_Delete_Begin
            // 
            this.Button_Delete_Begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Delete_Begin.FlatAppearance.BorderSize = 0;
            this.Button_Delete_Begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete_Begin.Font = new System.Drawing.Font("Segoe UI Semilight", 13.75F);
            this.Button_Delete_Begin.ForeColor = System.Drawing.Color.White;
            this.Button_Delete_Begin.Location = new System.Drawing.Point(405, 496);
            this.Button_Delete_Begin.Name = "Button_Delete_Begin";
            this.Button_Delete_Begin.Size = new System.Drawing.Size(167, 43);
            this.Button_Delete_Begin.TabIndex = 6;
            this.Button_Delete_Begin.TabStop = false;
            this.Button_Delete_Begin.Text = "Begin Operation";
            this.Button_Delete_Begin.UseVisualStyleBackColor = false;
            this.Button_Delete_Begin.Click += new System.EventHandler(this.Button_Delete_Begin_Click);
            // 
            // Button_Delete_Folder_Picker
            // 
            this.Button_Delete_Folder_Picker.BackColor = System.Drawing.Color.Silver;
            this.Button_Delete_Folder_Picker.FlatAppearance.BorderSize = 0;
            this.Button_Delete_Folder_Picker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete_Folder_Picker.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.Button_Delete_Folder_Picker.ForeColor = System.Drawing.Color.Black;
            this.Button_Delete_Folder_Picker.Location = new System.Drawing.Point(848, 76);
            this.Button_Delete_Folder_Picker.Name = "Button_Delete_Folder_Picker";
            this.Button_Delete_Folder_Picker.Size = new System.Drawing.Size(37, 25);
            this.Button_Delete_Folder_Picker.TabIndex = 2;
            this.Button_Delete_Folder_Picker.TabStop = false;
            this.Button_Delete_Folder_Picker.Text = "...";
            this.Button_Delete_Folder_Picker.UseVisualStyleBackColor = false;
            this.Button_Delete_Folder_Picker.Click += new System.EventHandler(this.Button_Delete_Folder_Picker_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Page_Delete);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.Panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Logo)).EndInit();
            this.Page_Delete.ResumeLayout(false);
            this.Page_Configuration.ResumeLayout(false);
            this.Page_Configuration.PerformLayout();
            this.Page_Metadata.ResumeLayout(false);
            this.Page_Metadata.PerformLayout();
            this.Panel_Metadata_Checkboxes.ResumeLayout(false);
            this.Panel_Metadata_Checkboxes.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Panel_Delete_Checkboxes.ResumeLayout(false);
            this.Panel_Delete_Checkboxes.PerformLayout();
            this.Page_Output.ResumeLayout(false);
            this.Page_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Title;
        private FlatButton Button_Close;
        private FlatButton Button_Minimise;
        private System.Windows.Forms.PictureBox Picture_Logo;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.TabControl Page_Delete;
        private System.Windows.Forms.TabPage Page_Configuration;
        private System.Windows.Forms.TabPage Page_Metadata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_Log_Locations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FlatButton Button_Log_Locations;
        private System.Windows.Forms.RadioButton Radio_Carry_On;
        private System.Windows.Forms.RadioButton Radio_Stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Page_Output;
        private System.Windows.Forms.Label Label_Operation_Start_Time;
        private System.Windows.Forms.TextBox Textbox_Output;
        private System.Windows.Forms.Label Label_Operation;
        private FlatButton Button_Metadata_Folder;
        private System.Windows.Forms.Label Label_Metadata_Folder;
        private System.Windows.Forms.TextBox Textbox_Metadata_Folder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Panel_Metadata_Checkboxes;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Size;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_ReadOnly;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Author;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Accessed;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Modified;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Created;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Extension;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Path;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_Filename;
        private FlatButton Button_Metadata_Begin;
        private System.Windows.Forms.CheckBox Checkbox_Metadata_All;
        private System.Windows.Forms.Label Label_Metadata_View_Output;
        private System.Windows.Forms.Label Label_Operation_Finished;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Textbox_Metadata_Output_Location;
        private FlatButton Button_Metadata_Output_Location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Label_Delete_View_Output;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Textbox_Delete_Folder_Path;
        private FlatButton Button_Delete_Begin;
        private FlatButton Button_Delete_Folder_Picker;
        private System.Windows.Forms.Panel Panel_Delete_Checkboxes;
        private System.Windows.Forms.CheckBox Checkbox_Delete_All;
        private System.Windows.Forms.CheckBox Checkbox_Delete_Metadata;
        private System.Windows.Forms.CheckBox Checkbox_Delete_Encrypt;
        private System.Windows.Forms.CheckBox Checkbox_Delete_Truncate;
        private System.Windows.Forms.CheckBox Checkbox_Delete_Obfuscate;
        private System.Windows.Forms.CheckBox Checkbox_Delete_Overwrite;
    }
}

