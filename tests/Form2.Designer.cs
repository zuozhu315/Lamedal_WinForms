namespace Lamedal_UIWinForms.Test
{
    partial class Form2
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.panel_1 = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.buttonLoad = new Lamedal_UIWinForms.UControl.button.Button_();
            this.panel_2 = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(396, 319);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.buttonLoad);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1.Location = new System.Drawing.Point(0, 0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Parent_GroupBox = null;
            this.panel_1.Parent_Panel = null;
            this.panel_1.Size = new System.Drawing.Size(396, 38);
            this.panel_1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLoad.Location = new System.Drawing.Point(0, 0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Parent_GroupBox = null;
            this.buttonLoad.Parent_Panel = this.panel_1;
            this.buttonLoad.Size = new System.Drawing.Size(75, 36);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.elementHost1);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2.Location = new System.Drawing.Point(0, 38);
            this.panel_2.Name = "panel_2";
            this.panel_2.Parent_GroupBox = null;
            this.panel_2.Parent_Panel = null;
            this.panel_2.Size = new System.Drawing.Size(396, 319);
            this.panel_2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 357);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_1.ResumeLayout(false);
            this.panel_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private UControl.panel.Panel_ panel_1;
        private UControl.panel.Panel_ panel_2;
        private UControl.button.Button_ buttonLoad;
    }
}