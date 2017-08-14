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
            this.imageSetup1 = new Lamedal_UIWinForms.UControl.images.ImageSetup(this.components);
            this.imageList_1 = new Lamedal_UIWinForms.UControl.images.ImageList_(this.components);
            this.SuspendLayout();
            // 
            // imageSetup1
            // 
            this.imageSetup1.ImageSet = true;
            // 
            // imageList_1
            // 
            this.imageList_1.Image_List1 = null;
            this.imageList_1.Image_List2 = null;
            this.imageList_1.Image_Refresh = false;
            this.imageList_1.Image_Source = Lamedal_UIWinForms.domain.Enumerals.enBlueprintUIAssets.ActorBody;
            this.imageList_1.Image_Status = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 459);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.images.ImageSetup imageSetup1;
        private UControl.images.ImageList_ imageList_1;
    }
}