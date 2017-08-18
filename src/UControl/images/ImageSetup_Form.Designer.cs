using System.Windows.Forms;

namespace Lamedal_UIWinForms.UControl.images
{
    partial class ImageSetup_Form
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox_1 = new System.Windows.Forms.GroupBox();
            this.listBox_Components = new System.Windows.Forms.ListBox();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Apps = new System.Windows.Forms.Button();
            this.button_Pictures = new System.Windows.Forms.Button();
            this.groupBox_Path = new System.Windows.Forms.GroupBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.textBox_Path2Image = new System.Windows.Forms.TextBox();
            this.button_Copy = new System.Windows.Forms.Button();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.comboBox_Resources = new System.Windows.Forms.ComboBox();
            this.button_LoadImages = new System.Windows.Forms.Button();
            this.comboBox_Icons = new System.Windows.Forms.ComboBox();
            this.groupBox_2 = new System.Windows.Forms.GroupBox();
            this.button_Image = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.comboBox_Resize = new System.Windows.Forms.ComboBox();
            this.input_Height = new System.Windows.Forms.TextBox();
            this.input_Width = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Help = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_Variable = new System.Windows.Forms.CheckBox();
            this.groupBox_1.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            this.groupBox_Path.SuspendLayout();
            this.panel_3.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 226);
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listView1, "Available images. Click to select an image");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox_1
            // 
            this.groupBox_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_1.CausesValidation = false;
            this.groupBox_1.Controls.Add(this.listBox_Components);
            this.groupBox_1.Controls.Add(this.panel1);
            this.groupBox_1.Controls.Add(this.groupBox_Search);
            this.groupBox_1.Controls.Add(this.groupBox_Path);
            this.groupBox_1.Controls.Add(this.panel_3);
            this.groupBox_1.Controls.Add(this.groupBox_2);
            this.groupBox_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_1.Location = new System.Drawing.Point(0, 226);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new System.Drawing.Size(651, 264);
            this.groupBox_1.TabIndex = 8;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "Image sets";
            // 
            // listBox_Components
            // 
            this.listBox_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Components.Location = new System.Drawing.Point(3, 85);
            this.listBox_Components.Name = "listBox_Components";
            this.listBox_Components.Size = new System.Drawing.Size(333, 116);
            this.listBox_Components.TabIndex = 13;
            this.toolTip1.SetToolTip(this.listBox_Components, "Click to select a different control on the Form");
            this.listBox_Components.SelectedIndexChanged += new System.EventHandler(this.listBox_Components_SelectedIndexChanged);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_Search.CausesValidation = false;
            this.groupBox_Search.Controls.Add(this.textBox_Search);
            this.groupBox_Search.Controls.Add(this.button_Apps);
            this.groupBox_Search.Controls.Add(this.button_Pictures);
            this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Search.Location = new System.Drawing.Point(3, 43);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(385, 42);
            this.groupBox_Search.TabIndex = 12;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.Location = new System.Drawing.Point(3, 16);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(287, 20);
            this.textBox_Search.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_Search, "Type in a term to search for and press ENTER");
            this.textBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyDown);
            // 
            // button_Apps
            // 
            this.button_Apps.AutoSize = true;
            this.button_Apps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Apps.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Apps.Location = new System.Drawing.Point(290, 16);
            this.button_Apps.Name = "button_Apps";
            this.button_Apps.Size = new System.Drawing.Size(37, 23);
            this.button_Apps.TabIndex = 9;
            this.button_Apps.Text = "Find";
            this.toolTip1.SetToolTip(this.button_Apps, "Search for the entered term");
            this.button_Apps.Click += new System.EventHandler(this.button_Apps_Click);
            // 
            // button_Pictures
            // 
            this.button_Pictures.AutoSize = true;
            this.button_Pictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Pictures.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Pictures.Location = new System.Drawing.Point(327, 16);
            this.button_Pictures.Name = "button_Pictures";
            this.button_Pictures.Size = new System.Drawing.Size(55, 23);
            this.button_Pictures.TabIndex = 0;
            this.button_Pictures.Text = "Pictures";
            this.button_Pictures.Visible = false;
            this.button_Pictures.Click += new System.EventHandler(this.button_Pictures_Click);
            // 
            // groupBox_Path
            // 
            this.groupBox_Path.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_Path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_Path.CausesValidation = false;
            this.groupBox_Path.Controls.Add(this.textBox_Path2Image);
            this.groupBox_Path.Controls.Add(this.panel2);
            this.groupBox_Path.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Path.Location = new System.Drawing.Point(3, 201);
            this.groupBox_Path.Name = "groupBox_Path";
            this.groupBox_Path.Size = new System.Drawing.Size(385, 60);
            this.groupBox_Path.TabIndex = 11;
            this.groupBox_Path.TabStop = false;
            this.groupBox_Path.Text = "Code to link to the image";
            // 
            // button_Set
            // 
            this.button_Set.AutoSize = true;
            this.button_Set.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Set.Location = new System.Drawing.Point(0, 0);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(52, 93);
            this.button_Set.TabIndex = 2;
            this.button_Set.Text = "SET";
            this.toolTip1.SetToolTip(this.button_Set, "Copy the selected image to the selected control");
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // textBox_Path2Image
            // 
            this.textBox_Path2Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Path2Image.Location = new System.Drawing.Point(3, 16);
            this.textBox_Path2Image.Multiline = true;
            this.textBox_Path2Image.Name = "textBox_Path2Image";
            this.textBox_Path2Image.Size = new System.Drawing.Size(287, 41);
            this.textBox_Path2Image.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_Path2Image, "Direct link to the selected image resource. Click on \'Copy\' to copy to clipboard." +
        "");
            // 
            // button_Copy
            // 
            this.button_Copy.AutoSize = true;
            this.button_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Copy.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Copy.Location = new System.Drawing.Point(0, 0);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(90, 23);
            this.button_Copy.TabIndex = 1;
            this.button_Copy.Text = "Copy";
            this.toolTip1.SetToolTip(this.button_Copy, "Copy the resource path (for direct usage in code) to the clipboard.");
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // panel_3
            // 
            this.panel_3.Controls.Add(this.comboBox_Resources);
            this.panel_3.Controls.Add(this.button_LoadImages);
            this.panel_3.Controls.Add(this.comboBox_Icons);
            this.panel_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_3.Location = new System.Drawing.Point(3, 16);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(385, 27);
            this.panel_3.TabIndex = 9;
            // 
            // comboBox_Resources
            // 
            this.comboBox_Resources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Resources.Location = new System.Drawing.Point(0, 0);
            this.comboBox_Resources.Name = "comboBox_Resources";
            this.comboBox_Resources.Size = new System.Drawing.Size(230, 21);
            this.comboBox_Resources.TabIndex = 6;
            this.comboBox_Resources.Text = "All";
            this.toolTip1.SetToolTip(this.comboBox_Resources, "Select a group of related images");
            this.comboBox_Resources.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resources_SelectedIndexChanged);
            // 
            // button_LoadImages
            // 
            this.button_LoadImages.AutoSize = true;
            this.button_LoadImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_LoadImages.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_LoadImages.Location = new System.Drawing.Point(230, 0);
            this.button_LoadImages.Name = "button_LoadImages";
            this.button_LoadImages.Size = new System.Drawing.Size(78, 27);
            this.button_LoadImages.TabIndex = 0;
            this.button_LoadImages.Text = "Load Images";
            this.button_LoadImages.Visible = false;
            this.button_LoadImages.Click += new System.EventHandler(this.button_LoadImages_Click);
            // 
            // comboBox_Icons
            // 
            this.comboBox_Icons.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_Icons.Location = new System.Drawing.Point(308, 0);
            this.comboBox_Icons.Name = "comboBox_Icons";
            this.comboBox_Icons.Size = new System.Drawing.Size(77, 21);
            this.comboBox_Icons.TabIndex = 7;
            this.comboBox_Icons.Text = "LargeIcon";
            this.toolTip1.SetToolTip(this.comboBox_Icons, "Select how images are displayed in this tool");
            this.comboBox_Icons.SelectedIndexChanged += new System.EventHandler(this.comboBox_Icons_SelectedIndexChanged);
            // 
            // groupBox_2
            // 
            this.groupBox_2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_2.CausesValidation = false;
            this.groupBox_2.Controls.Add(this.button_Image);
            this.groupBox_2.Controls.Add(this.panel_1);
            this.groupBox_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_2.Location = new System.Drawing.Point(388, 16);
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new System.Drawing.Size(260, 245);
            this.groupBox_2.TabIndex = 10;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Properties";
            // 
            // button_Image
            // 
            this.button_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Image.Location = new System.Drawing.Point(3, 46);
            this.button_Image.Name = "button_Image";
            this.button_Image.Size = new System.Drawing.Size(254, 196);
            this.button_Image.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_Image, "Sample of how the image will look on the control once \'Set\' is clicked");
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.comboBox_Resize);
            this.panel_1.Controls.Add(this.input_Height);
            this.panel_1.Controls.Add(this.input_Width);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1.Location = new System.Drawing.Point(3, 16);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(254, 30);
            this.panel_1.TabIndex = 1;
            // 
            // comboBox_Resize
            // 
            this.comboBox_Resize.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_Resize.Items.AddRange(new object[] {
            "(Default)",
            "16x16",
            "32x32",
            "48x48",
            "64x64",
            "128x128",
            "256x256"});
            this.comboBox_Resize.Location = new System.Drawing.Point(180, 0);
            this.comboBox_Resize.Name = "comboBox_Resize";
            this.comboBox_Resize.Size = new System.Drawing.Size(69, 21);
            this.comboBox_Resize.TabIndex = 1;
            this.comboBox_Resize.Text = "(Default)";
            this.toolTip1.SetToolTip(this.comboBox_Resize, "Select the dimentions of the image");
            this.comboBox_Resize.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resize_SelectedIndexChanged);
            // 
            // input_Height
            // 
            this.input_Height.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_Height.Location = new System.Drawing.Point(90, 0);
            this.input_Height.Name = "input_Height";
            this.input_Height.Size = new System.Drawing.Size(90, 20);
            this.input_Height.TabIndex = 0;
            // 
            // input_Width
            // 
            this.input_Width.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_Width.Location = new System.Drawing.Point(0, 0);
            this.input_Width.Name = "input_Width";
            this.input_Width.Size = new System.Drawing.Size(90, 20);
            this.input_Width.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Set);
            this.panel1.Controls.Add(this.button_Help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(336, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 116);
            this.panel1.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel1.Text = "Showing available images ";
            // 
            // button_Help
            // 
            this.button_Help.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Help.Location = new System.Drawing.Point(0, 93);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(52, 23);
            this.button_Help.TabIndex = 3;
            this.button_Help.Text = "?";
            this.toolTip1.SetToolTip(this.button_Help, "Show help screen");
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox_Variable);
            this.panel2.Controls.Add(this.button_Copy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(290, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 41);
            this.panel2.TabIndex = 2;
            // 
            // checkBox_Variable
            // 
            this.checkBox_Variable.AutoSize = true;
            this.checkBox_Variable.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Variable.Location = new System.Drawing.Point(0, 23);
            this.checkBox_Variable.Name = "checkBox_Variable";
            this.checkBox_Variable.Size = new System.Drawing.Size(90, 17);
            this.checkBox_Variable.TabIndex = 2;
            this.checkBox_Variable.Text = "Add variable";
            this.toolTip1.SetToolTip(this.checkBox_Variable, "Add \'pic\' variable to the code.");
            this.checkBox_Variable.UseVisualStyleBackColor = true;
            this.checkBox_Variable.CheckedChanged += new System.EventHandler(this.checkBox_Variable_CheckedChanged);
            // 
            // ImageSetup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox_1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ImageSetup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Resources";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ImageResources_FormClosed);
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.groupBox_Path.ResumeLayout(false);
            this.groupBox_Path.PerformLayout();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_LoadImages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private ComboBox comboBox_Resources;
        private GroupBox groupBox_1;
        private TextBox textBox_Path2Image;
        private ComboBox comboBox_Icons;
        private Button button_Copy;
        private Panel panel_3;
        private GroupBox groupBox_2;
        private Button button_Image;
        private GroupBox groupBox_Search;
        private TextBox textBox_Search;
        private Button button_Pictures;
        private GroupBox groupBox_Path;
        private Button button_Set;
        private ListBox listBox_Components;
        private Panel panel_1;
        private TextBox input_Height;
        private TextBox input_Width;
        private ComboBox comboBox_Resize;
        private Button button_Apps;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button_Help;
        private ToolTip toolTip1;
        private Panel panel2;
        private CheckBox checkBox_Variable;
    }
}

