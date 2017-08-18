using System.Windows.Forms;
using Lamedal_UIWinForms.UControl.button;
using Lamedal_UIWinForms.UControl.images;
using Lamedal_UIWinForms.UControl.panel;

namespace Lamedal_UIWinForms.Test.tests.Forms
{
    partial class Form_cSharpCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cSharpCode));
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.groupDetail = new System.Windows.Forms.GroupBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.buttonPaste2 = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonUnHide = new Lamedal_UIWinForms.UControl.button.Button_();
            this.groupHeader = new System.Windows.Forms.GroupBox();
            this.panel_Dock = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.buttonRight = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonTopBottom = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonLeft = new Lamedal_UIWinForms.UControl.button.Button_();
            this.panel_Size = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.buttonLarge = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonMedium = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonSmall = new Lamedal_UIWinForms.UControl.button.Button_();
            this.panel_1 = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.buttonClear = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonPaste = new Lamedal_UIWinForms.UControl.button.Button_();
            this.buttonHide = new Lamedal_UIWinForms.UControl.button.Button_();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageSetup1 = new Lamedal_UIWinForms.UControl.images.ImageSetup(this.components);
            this.groupMain.SuspendLayout();
            this.groupDetail.SuspendLayout();
            this.groupHeader.SuspendLayout();
            this.panel_Dock.SuspendLayout();
            this.panel_Size.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.groupDetail);
            this.groupMain.Controls.Add(this.groupHeader);
            this.groupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMain.Location = new System.Drawing.Point(0, 0);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(344, 323);
            this.groupMain.TabIndex = 0;
            this.groupMain.TabStop = false;
            // 
            // groupDetail
            // 
            this.groupDetail.Controls.Add(this.buttonPaste2);
            this.groupDetail.Controls.Add(this.buttonUnHide);
            this.groupDetail.Controls.Add(this.elementHost1);
            this.groupDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetail.Location = new System.Drawing.Point(3, 62);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(338, 258);
            this.groupDetail.TabIndex = 3;
            this.groupDetail.TabStop = false;
            this.groupDetail.Text = "Detail";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 16);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(332, 239);
            this.elementHost1.TabIndex = 11;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // buttonPaste2
            // 
            this.buttonPaste2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaste2.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste2.Image")));
            this.buttonPaste2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonPaste2.Location = new System.Drawing.Point(295, 32);
            this.buttonPaste2.Name = "buttonPaste2";
            this.buttonPaste2.Parent_GroupBox = this.groupDetail;
            this.buttonPaste2.Parent_Panel = null;
            this.buttonPaste2.Size = new System.Drawing.Size(21, 24);
            this.buttonPaste2.TabIndex = 10;
            this.buttonPaste2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonPaste2, "Paste code into the editor");
            this.buttonPaste2.UseVisualStyleBackColor = true;
            this.buttonPaste2.Visible = false;
            this.buttonPaste2.Click += new System.EventHandler(this.buttonPaste2_Click);
            // 
            // buttonUnHide
            // 
            this.buttonUnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnHide.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnHide.Image")));
            this.buttonUnHide.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUnHide.Location = new System.Drawing.Point(295, 11);
            this.buttonUnHide.Name = "buttonUnHide";
            this.buttonUnHide.Parent_GroupBox = this.groupDetail;
            this.buttonUnHide.Parent_Panel = null;
            this.buttonUnHide.Size = new System.Drawing.Size(21, 20);
            this.buttonUnHide.TabIndex = 1;
            this.buttonUnHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonUnHide, "UnHide the buttons");
            this.buttonUnHide.UseVisualStyleBackColor = true;
            this.buttonUnHide.Visible = false;
            this.buttonUnHide.Click += new System.EventHandler(this.buttonUnHide_Click);
            // 
            // groupHeader
            // 
            this.groupHeader.Controls.Add(this.panel_Dock);
            this.groupHeader.Controls.Add(this.panel_Size);
            this.groupHeader.Controls.Add(this.panel_1);
            this.groupHeader.Controls.Add(this.buttonHide);
            this.groupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupHeader.Location = new System.Drawing.Point(3, 16);
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.Size = new System.Drawing.Size(338, 46);
            this.groupHeader.TabIndex = 0;
            this.groupHeader.TabStop = false;
            this.groupHeader.Text = "Tag_Header";
            // 
            // panel_Dock
            // 
            this.panel_Dock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Dock.Controls.Add(this.buttonRight);
            this.panel_Dock.Controls.Add(this.buttonTopBottom);
            this.panel_Dock.Controls.Add(this.buttonLeft);
            this.panel_Dock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Dock.Location = new System.Drawing.Point(149, 16);
            this.panel_Dock.Name = "panel_Dock";
            this.panel_Dock.Parent_GroupBox = this.groupHeader;
            this.panel_Dock.Parent_Panel = null;
            this.panel_Dock.Size = new System.Drawing.Size(95, 27);
            this.panel_Dock.TabIndex = 12;
            // 
            // buttonRight
            // 
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRight.Image")));
            this.buttonRight.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRight.Location = new System.Drawing.Point(58, 0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Parent_GroupBox = null;
            this.buttonRight.Parent_Panel = this.panel_Dock;
            this.buttonRight.Size = new System.Drawing.Size(33, 25);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonRight, "Move to Right Edge of screen");
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonTopBottom
            // 
            this.buttonTopBottom.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTopBottom.Image = ((System.Drawing.Image)(resources.GetObject("buttonTopBottom.Image")));
            this.buttonTopBottom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTopBottom.Location = new System.Drawing.Point(31, 0);
            this.buttonTopBottom.Name = "buttonTopBottom";
            this.buttonTopBottom.Parent_GroupBox = null;
            this.buttonTopBottom.Parent_Panel = this.panel_Dock;
            this.buttonTopBottom.Size = new System.Drawing.Size(27, 25);
            this.buttonTopBottom.TabIndex = 7;
            this.buttonTopBottom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonTopBottom, "Move to Top or Bottom of screen");
            this.buttonTopBottom.UseVisualStyleBackColor = true;
            this.buttonTopBottom.Click += new System.EventHandler(this.buttonTopBottom_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Parent_GroupBox = null;
            this.buttonLeft.Parent_Panel = this.panel_Dock;
            this.buttonLeft.Size = new System.Drawing.Size(31, 25);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonLeft, "Move to Left Edge of screen");
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // panel_Size
            // 
            this.panel_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Size.Controls.Add(this.buttonLarge);
            this.panel_Size.Controls.Add(this.buttonMedium);
            this.panel_Size.Controls.Add(this.buttonSmall);
            this.panel_Size.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Size.Location = new System.Drawing.Point(64, 16);
            this.panel_Size.Name = "panel_Size";
            this.panel_Size.Parent_GroupBox = this.groupHeader;
            this.panel_Size.Parent_Panel = null;
            this.panel_Size.Size = new System.Drawing.Size(85, 27);
            this.panel_Size.TabIndex = 11;
            // 
            // buttonLarge
            // 
            this.buttonLarge.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLarge.Image = ((System.Drawing.Image)(resources.GetObject("buttonLarge.Image")));
            this.buttonLarge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonLarge.Location = new System.Drawing.Point(53, 0);
            this.buttonLarge.Name = "buttonLarge";
            this.buttonLarge.Parent_GroupBox = null;
            this.buttonLarge.Parent_Panel = this.panel_Size;
            this.buttonLarge.Size = new System.Drawing.Size(24, 25);
            this.buttonLarge.TabIndex = 4;
            this.buttonLarge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonLarge, "Large Window");
            this.buttonLarge.UseVisualStyleBackColor = true;
            this.buttonLarge.Click += new System.EventHandler(this.buttonLarge_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMedium.Location = new System.Drawing.Point(24, 0);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Parent_GroupBox = null;
            this.buttonMedium.Parent_Panel = this.panel_Size;
            this.buttonMedium.Size = new System.Drawing.Size(29, 25);
            this.buttonMedium.TabIndex = 3;
            this.buttonMedium.Text = "&M";
            this.toolTip1.SetToolTip(this.buttonMedium, "Medium Window");
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonSmall
            // 
            this.buttonSmall.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSmall.Image = ((System.Drawing.Image)(resources.GetObject("buttonSmall.Image")));
            this.buttonSmall.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSmall.Location = new System.Drawing.Point(0, 0);
            this.buttonSmall.Name = "buttonSmall";
            this.buttonSmall.Parent_GroupBox = null;
            this.buttonSmall.Parent_Panel = this.panel_Size;
            this.buttonSmall.Size = new System.Drawing.Size(24, 25);
            this.buttonSmall.TabIndex = 2;
            this.buttonSmall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonSmall, "Small Window");
            this.buttonSmall.UseVisualStyleBackColor = true;
            this.buttonSmall.Click += new System.EventHandler(this.buttonSmall_Click);
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.buttonClear);
            this.panel_1.Controls.Add(this.buttonPaste);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_1.Location = new System.Drawing.Point(3, 16);
            this.panel_1.Name = "panel_1";
            this.panel_1.Parent_GroupBox = this.groupHeader;
            this.panel_1.Parent_Panel = null;
            this.panel_1.Size = new System.Drawing.Size(61, 27);
            this.panel_1.TabIndex = 10;
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonClear.Location = new System.Drawing.Point(26, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Parent_GroupBox = null;
            this.buttonClear.Parent_Panel = this.panel_1;
            this.buttonClear.Size = new System.Drawing.Size(25, 25);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonClear, "Clear the editor");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonPaste.Location = new System.Drawing.Point(0, 0);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Parent_GroupBox = null;
            this.buttonPaste.Parent_Panel = this.panel_1;
            this.buttonPaste.Size = new System.Drawing.Size(26, 25);
            this.buttonPaste.TabIndex = 0;
            this.buttonPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonPaste, "Paste code into the editor");
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.Image = ((System.Drawing.Image)(resources.GetObject("buttonHide.Image")));
            this.buttonHide.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHide.Location = new System.Drawing.Point(311, 19);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Parent_GroupBox = this.groupHeader;
            this.buttonHide.Parent_Panel = null;
            this.buttonHide.Size = new System.Drawing.Size(24, 23);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.buttonHide, "Hide the buttons to show more editor");
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // imageSetup1
            // 
            this.imageSetup1.ImageSet = false;
            // 
            // Form_cSharpCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 323);
            this.Controls.Add(this.groupMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_cSharpCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Convertor version 0.1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form_cSharpCode_Load);
            this.groupMain.ResumeLayout(false);
            this.groupDetail.ResumeLayout(false);
            this.groupHeader.ResumeLayout(false);
            this.panel_Dock.ResumeLayout(false);
            this.panel_Size.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMain;
        internal System.Windows.Forms.GroupBox groupDetail;
        internal System.Windows.Forms.GroupBox groupHeader;
        private Button_ buttonHide;
        private Button_ buttonPaste;
        internal Button_ buttonUnHide;
        private Button_ buttonSmall;
        private Button_ buttonRight;
        private Button_ buttonLarge;
        private Button_ buttonMedium;
        private Button_ buttonTopBottom;
        private Button_ buttonLeft;
        private Button_ buttonClear;
        internal Button_ buttonPaste2;
        private Panel_ panel_Dock;
        private Panel_ panel_Size;
        private Panel_ panel_1;
        private ToolTip toolTip1;
        private ImageSetup imageSetup1;
        internal System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}