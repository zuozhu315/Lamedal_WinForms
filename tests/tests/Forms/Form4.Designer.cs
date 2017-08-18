namespace Lamedal_UIWinForms.Test.tests.Forms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button_1 = new Lamedal_UIWinForms.UControl.button.Button_();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageSetup1 = new Lamedal_UIWinForms.UControl.images.ImageSetup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_1.ImageKey = "editFind";
            this.button_1.ImageList = this.imageList1;
            this.button_1.Location = new System.Drawing.Point(49, 32);
            this.button_1.Name = "button_1";
            this.button_1.Parent_GroupBox = null;
            this.button_1.Parent_Panel = null;
            this.button_1.Size = new System.Drawing.Size(87, 38);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "button_1";
            this.button_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editClipCut");
            this.imageList1.Images.SetKeyName(1, "editFileScript");
            this.imageList1.Images.SetKeyName(2, "editUpdateMinRed");
            this.imageList1.Images.SetKeyName(3, "editParagraphRightJustify");
            this.imageList1.Images.SetKeyName(4, "editFontChrGrow");
            this.imageList1.Images.SetKeyName(5, "editUpdateAddRed");
            this.imageList1.Images.SetKeyName(6, "editUpdateMinGreen");
            this.imageList1.Images.SetKeyName(7, "editFontNumbering");
            this.imageList1.Images.SetKeyName(8, "editUpdateAdd");
            this.imageList1.Images.SetKeyName(9, "editClipCopy");
            this.imageList1.Images.SetKeyName(10, "editUpdateMinBlue");
            this.imageList1.Images.SetKeyName(11, "editFontBullets");
            this.imageList1.Images.SetKeyName(12, "editFileSave");
            this.imageList1.Images.SetKeyName(13, "editFileOpen");
            this.imageList1.Images.SetKeyName(14, "editFindFile");
            this.imageList1.Images.SetKeyName(15, "editParagraphJustify");
            this.imageList1.Images.SetKeyName(16, "editUpdateAddGreen");
            this.imageList1.Images.SetKeyName(17, "editUpdateAddBlue");
            this.imageList1.Images.SetKeyName(18, "editParagraphleftJustify");
            this.imageList1.Images.SetKeyName(19, "editDocument");
            this.imageList1.Images.SetKeyName(20, "editParagraphIndentationRight");
            this.imageList1.Images.SetKeyName(21, "editReport");
            this.imageList1.Images.SetKeyName(22, "editImage");
            this.imageList1.Images.SetKeyName(23, "editVideo");
            this.imageList1.Images.SetKeyName(24, "editToggle");
            this.imageList1.Images.SetKeyName(25, "editfontFormat");
            this.imageList1.Images.SetKeyName(26, "editClipPaste");
            this.imageList1.Images.SetKeyName(27, "editSettings");
            this.imageList1.Images.SetKeyName(28, "editParagraphIndentationLeft");
            this.imageList1.Images.SetKeyName(29, "editFontChrSmaller");
            this.imageList1.Images.SetKeyName(30, "editProcess");
            this.imageList1.Images.SetKeyName(31, "editFormDialog");
            this.imageList1.Images.SetKeyName(32, "editFontBold");
            this.imageList1.Images.SetKeyName(33, "editSwap");
            this.imageList1.Images.SetKeyName(34, "editHelp");
            this.imageList1.Images.SetKeyName(35, "editHome");
            this.imageList1.Images.SetKeyName(36, "editForm");
            this.imageList1.Images.SetKeyName(37, "editFind");
            this.imageList1.Images.SetKeyName(38, "editFlag");
            this.imageList1.Images.SetKeyName(39, "editHelpSmall");
            this.imageList1.Images.SetKeyName(40, "editParagraphCenter");
            this.imageList1.Images.SetKeyName(41, "editHelpBig");
            this.imageList1.Images.SetKeyName(42, "editDocumentSmall");
            this.imageList1.Images.SetKeyName(43, "editClipCopyBold");
            this.imageList1.Images.SetKeyName(44, "editHistoryRedo");
            this.imageList1.Images.SetKeyName(45, "editHistoryUndo");
            this.imageList1.Images.SetKeyName(46, "editClipCopy3D");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(151, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageSetup1
            // 
            this.imageSetup1.ImageHelp = false;
            this.imageSetup1.ImageSet = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.button.Button_ button_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private UControl.images.ImageSetup imageSetup1;
    }
}