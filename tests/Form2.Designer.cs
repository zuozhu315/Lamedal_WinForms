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
            this.input_Control1 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(396, 223);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.input_Control1);
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
            this.panel_2.Size = new System.Drawing.Size(396, 223);
            this.panel_2.TabIndex = 2;
            // 
            // input_Control1
            // 
            this.input_Control1._Control_Action = false;
            this.input_Control1._Control_Centre = 80;
            this.input_Control1._Control_Rows = 1;
            this.input_Control1._Control_Sync = false;
            this.input_Control1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.input_Control1.Action_AutoSave = false;
            this.input_Control1.Action_Button = false;
            this.input_Control1.Action_Custom = Lamedal_UIWinForms.domain.Enumerals.enControl_InputCustomAction.None;
            this.input_Control1.Action_EnterButton = null;
            this.input_Control1.Action_Text = "..";
            this.input_Control1.Action_Width = 30;
            this.input_Control1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.input_Control1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.input_Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_Control1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_Control1.Border = false;
            this.input_Control1.Border_Color = System.Drawing.Color.Red;
            this.input_Control1.Border_Width = 2;
            this.input_Control1.CausesValidation = false;
            this.input_Control1.Combo_DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.input_Control1.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.Edit_Masked;
            this.input_Control1.Edit_Mask = null;
            this.input_Control1.Edit_PasswordChar = '\0';
            this.input_Control1.EnableSet_Control = null;
            this.input_Control1.EnableSet_Index = 1;
            this.input_Control1.Field_Caption = "FieldName";
            this.input_Control1.Field_Caption2 = "FieldName2";
            this.input_Control1.Field_Caption3 = "FieldName3";
            this.input_Control1.Field_Caption4 = "FieldName4";
            this.input_Control1.Field_Description = null;
            this.input_Control1.Field_Name = null;
            this.input_Control1.Field_Value = "";
            this.input_Control1.Field_Value1 = false;
            this.input_Control1.Field_Value2 = false;
            this.input_Control1.Field_Value3 = false;
            this.input_Control1.Filter_Control = null;
            this.input_Control1.Filter_FieldName = null;
            this.input_Control1.Filter_FieldName2 = null;
            this.input_Control1.Filter_TableName = null;
            this.input_Control1.Filter_Value = null;
            this.input_Control1.Filter_Value2 = null;
            this.input_Control1.Location = new System.Drawing.Point(97, 0);
            this.input_Control1.Lookup_IDName = null;
            this.input_Control1.Lookup_ValueName = null;
            this.input_Control1.Name = "input_Control1";
            this.input_Control1.Parent_GroupBox = null;
            this.input_Control1.Parent_Panel = this.panel_1;
            this.input_Control1.Path_Filter = "*.*";
            this.input_Control1.Path_FilterName = "All Files";
            this.input_Control1.Size = new System.Drawing.Size(218, 35);
            this.input_Control1.TabIndex = 1;
            this.input_Control1.ValueSet_Control = null;
            this.input_Control1.VisibleSet_Control = null;
            this.input_Control1.VisibleSet_Index = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private UControl.Input.Input_Control input_Control1;
    }
}