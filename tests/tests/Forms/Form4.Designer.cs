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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageSetup1 = new Lamedal_UIWinForms.UControl.images.ImageSetup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_1.ImageKey = "editFind";
            this.button_1.Location = new System.Drawing.Point(49, 32);
            this.button_1.Name = "button_1";
            this.button_1.Parent_GroupBox = null;
            this.button_1.Parent_Panel = null;
            this.button_1.Size = new System.Drawing.Size(87, 38);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "button_1";
            this.button_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
        private UControl.images.ImageSetup imageSetup1;
    }
}