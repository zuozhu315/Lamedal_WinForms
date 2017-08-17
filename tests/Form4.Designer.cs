namespace Lamedal_UIWinForms.Test
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
            this.imageList_1 = new Lamedal_UIWinForms.UControl.images.ImageList_(this.components);
            this.imageSetup1 = new Lamedal_UIWinForms.UControl.images.ImageSetup(this.components);
            this.button_1 = new Lamedal_UIWinForms.UControl.button.Button_();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_1
            // 
            this.imageList_1.Image_List1 = this.imageList1;
            this.imageList_1.Image_List2 = null;
            this.imageList_1.Image_Refresh = false;
            this.imageList_1.Image_Source = Lamedal_UIWinForms.domain.Enumerals.enBlueprintUIAssets.ActorBody;
            this.imageList_1.Image_Status = false;
            // 
            // imageSetup1
            // 
            this.imageSetup1.ImageSet = false;
            // 
            // button_1
            // 
            this.button_1.Image = ((System.Drawing.Image)(resources.GetObject("button_1.Image")));
            this.button_1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_1.Location = new System.Drawing.Point(20, 27);
            this.button_1.Name = "button_1";
            this.button_1.Parent_GroupBox = null;
            this.button_1.Parent_Panel = null;
            this.button_1.Size = new System.Drawing.Size(75, 61);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "button_1";
            this.button_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "actorTeam");
            this.imageList1.Images.SetKeyName(1, "actor");
            this.imageList1.Images.SetKeyName(2, "actorAdd");
            this.imageList1.Images.SetKeyName(3, "actorSmall");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(117, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.images.ImageList_ imageList_1;
        private UControl.images.ImageSetup imageSetup1;
        private System.Windows.Forms.ImageList imageList1;
        private UControl.button.Button_ button_1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}