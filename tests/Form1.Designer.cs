namespace Lamedal_UIWinForms.Test
{
    partial class Form1
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
            this.panel_1 = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.label_1 = new Lamedal_UIWinForms.UControl._Designer.Label_();
            this.comboBox_1 = new Lamedal_UIWinForms.UControl._Designer.ComboBox_();
            this.groupBox_1 = new Lamedal_UIWinForms.UControl._Designer.GroupBox_();
            this.input_Control1 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.input_Control2 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.input_Control3 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.input_Control4 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.input_Control5 = new Lamedal_UIWinForms.UControl.Input.Input_Control();
            this.panel_2 = new Lamedal_UIWinForms.UControl.panel.Panel_();
            this.button_Standard1 = new Lamedal_UIWinForms.UControl.button.Button_Standard();
            this.panel_1.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.comboBox_1);
            this.panel_1.Controls.Add(this.label_1);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_1.Location = new System.Drawing.Point(0, 0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Parent_GroupBox = null;
            this.panel_1.Parent_Panel = null;
            this.panel_1.Size = new System.Drawing.Size(530, 43);
            this.panel_1.TabIndex = 0;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(120, 17);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(41, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "label_1";
            // 
            // comboBox_1
            // 
            this.comboBox_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_1.Location = new System.Drawing.Point(444, 0);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.Size = new System.Drawing.Size(84, 21);
            this.comboBox_1.TabIndex = 2;
            this.comboBox_1.Text = "comboBox_1";
            // 
            // groupBox_1
            // 
            this.groupBox_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.groupBox_1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.groupBox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_1.CausesValidation = false;
            this.groupBox_1.Controls.Add(this.input_Control5);
            this.groupBox_1.Controls.Add(this.input_Control4);
            this.groupBox_1.Controls.Add(this.input_Control3);
            this.groupBox_1.Controls.Add(this.input_Control2);
            this.groupBox_1.Controls.Add(this.input_Control1);
            this.groupBox_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_1.Location = new System.Drawing.Point(0, 43);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Parent_GroupBox = null;
            this.groupBox_1.Parent_Panel = null;
            this.groupBox_1.Size = new System.Drawing.Size(208, 212);
            this.groupBox_1.TabIndex = 1;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "groupBox_1";
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
            this.input_Control1.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.Edit;
            this.input_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_Control1.Edit_Mask = null;
            this.input_Control1.Edit_PasswordChar = '\0';
            this.input_Control1.EnableSet_Control = null;
            this.input_Control1.EnableSet_Index = 1;
            this.input_Control1.Field_Caption = "Naam";
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
            this.input_Control1.Location = new System.Drawing.Point(3, 16);
            this.input_Control1.Lookup_IDName = null;
            this.input_Control1.Lookup_ValueName = null;
            this.input_Control1.Name = "input_Control1";
            this.input_Control1.Parent_GroupBox = this.groupBox_1;
            this.input_Control1.Parent_Panel = null;
            this.input_Control1.Path_Filter = "*.*";
            this.input_Control1.Path_FilterName = "All Files";
            this.input_Control1.Size = new System.Drawing.Size(202, 33);
            this.input_Control1.TabIndex = 0;
            this.input_Control1.ValueSet_Control = null;
            this.input_Control1.VisibleSet_Control = null;
            this.input_Control1.VisibleSet_Index = 1;
            // 
            // input_Control2
            // 
            this.input_Control2._Control_Action = false;
            this.input_Control2._Control_Centre = 80;
            this.input_Control2._Control_Rows = 1;
            this.input_Control2._Control_Sync = false;
            this.input_Control2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.input_Control2.Action_AutoSave = false;
            this.input_Control2.Action_Button = false;
            this.input_Control2.Action_Custom = Lamedal_UIWinForms.domain.Enumerals.enControl_InputCustomAction.None;
            this.input_Control2.Action_EnterButton = null;
            this.input_Control2.Action_Text = "..";
            this.input_Control2.Action_Width = 30;
            this.input_Control2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.input_Control2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.input_Control2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_Control2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_Control2.Border = false;
            this.input_Control2.Border_Color = System.Drawing.Color.Red;
            this.input_Control2.Border_Width = 2;
            this.input_Control2.CausesValidation = false;
            this.input_Control2.Combo_DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.input_Control2.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.Edit;
            this.input_Control2.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_Control2.Edit_Mask = null;
            this.input_Control2.Edit_PasswordChar = '\0';
            this.input_Control2.EnableSet_Control = null;
            this.input_Control2.EnableSet_Index = 1;
            this.input_Control2.Field_Caption = "Van";
            this.input_Control2.Field_Caption2 = "FieldName2";
            this.input_Control2.Field_Caption3 = "FieldName3";
            this.input_Control2.Field_Caption4 = "FieldName4";
            this.input_Control2.Field_Description = null;
            this.input_Control2.Field_Name = null;
            this.input_Control2.Field_Value = "";
            this.input_Control2.Field_Value1 = false;
            this.input_Control2.Field_Value2 = false;
            this.input_Control2.Field_Value3 = false;
            this.input_Control2.Filter_Control = null;
            this.input_Control2.Filter_FieldName = null;
            this.input_Control2.Filter_FieldName2 = null;
            this.input_Control2.Filter_TableName = null;
            this.input_Control2.Filter_Value = null;
            this.input_Control2.Filter_Value2 = null;
            this.input_Control2.Location = new System.Drawing.Point(3, 49);
            this.input_Control2.Lookup_IDName = null;
            this.input_Control2.Lookup_ValueName = null;
            this.input_Control2.Name = "input_Control2";
            this.input_Control2.Parent_GroupBox = this.groupBox_1;
            this.input_Control2.Parent_Panel = null;
            this.input_Control2.Path_Filter = "*.*";
            this.input_Control2.Path_FilterName = "All Files";
            this.input_Control2.Size = new System.Drawing.Size(202, 33);
            this.input_Control2.TabIndex = 0;
            this.input_Control2.ValueSet_Control = null;
            this.input_Control2.VisibleSet_Control = null;
            this.input_Control2.VisibleSet_Index = 1;
            // 
            // input_Control3
            // 
            this.input_Control3._Control_Action = false;
            this.input_Control3._Control_Centre = 80;
            this.input_Control3._Control_Rows = 1;
            this.input_Control3._Control_Sync = false;
            this.input_Control3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.input_Control3.Action_AutoSave = false;
            this.input_Control3.Action_Button = false;
            this.input_Control3.Action_Custom = Lamedal_UIWinForms.domain.Enumerals.enControl_InputCustomAction.None;
            this.input_Control3.Action_EnterButton = null;
            this.input_Control3.Action_Text = "..";
            this.input_Control3.Action_Width = 30;
            this.input_Control3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.input_Control3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.input_Control3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_Control3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_Control3.Border = false;
            this.input_Control3.Border_Color = System.Drawing.Color.Red;
            this.input_Control3.Border_Width = 2;
            this.input_Control3.CausesValidation = false;
            this.input_Control3.Combo_DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.input_Control3.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.Checkbox1;
            this.input_Control3.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_Control3.Edit_Mask = null;
            this.input_Control3.Edit_PasswordChar = '\0';
            this.input_Control3.EnableSet_Control = null;
            this.input_Control3.EnableSet_Index = 1;
            this.input_Control3.Field_Caption = "Married";
            this.input_Control3.Field_Caption2 = "FieldName2";
            this.input_Control3.Field_Caption3 = "FieldName3";
            this.input_Control3.Field_Caption4 = "FieldName4";
            this.input_Control3.Field_Description = null;
            this.input_Control3.Field_Name = null;
            this.input_Control3.Field_Value = "false";
            this.input_Control3.Field_Value1 = false;
            this.input_Control3.Field_Value2 = false;
            this.input_Control3.Field_Value3 = false;
            this.input_Control3.Filter_Control = null;
            this.input_Control3.Filter_FieldName = null;
            this.input_Control3.Filter_FieldName2 = null;
            this.input_Control3.Filter_TableName = null;
            this.input_Control3.Filter_Value = null;
            this.input_Control3.Filter_Value2 = null;
            this.input_Control3.Location = new System.Drawing.Point(3, 82);
            this.input_Control3.Lookup_IDName = null;
            this.input_Control3.Lookup_ValueName = null;
            this.input_Control3.Name = "input_Control3";
            this.input_Control3.Parent_GroupBox = this.groupBox_1;
            this.input_Control3.Parent_Panel = null;
            this.input_Control3.Path_Filter = "*.*";
            this.input_Control3.Path_FilterName = "All Files";
            this.input_Control3.Size = new System.Drawing.Size(202, 35);
            this.input_Control3.TabIndex = 0;
            this.input_Control3.ValueSet_Control = null;
            this.input_Control3.VisibleSet_Control = null;
            this.input_Control3.VisibleSet_Index = 1;
            // 
            // input_Control4
            // 
            this.input_Control4._Control_Action = false;
            this.input_Control4._Control_Centre = 80;
            this.input_Control4._Control_Rows = 1;
            this.input_Control4._Control_Sync = false;
            this.input_Control4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.input_Control4.Action_AutoSave = false;
            this.input_Control4.Action_Button = false;
            this.input_Control4.Action_Custom = Lamedal_UIWinForms.domain.Enumerals.enControl_InputCustomAction.None;
            this.input_Control4.Action_EnterButton = null;
            this.input_Control4.Action_Text = "..";
            this.input_Control4.Action_Width = 30;
            this.input_Control4.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.input_Control4.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.input_Control4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_Control4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_Control4.Border = true;
            this.input_Control4.Border_Color = System.Drawing.Color.Red;
            this.input_Control4.Border_Width = 2;
            this.input_Control4.CausesValidation = false;
            this.input_Control4.Combo_DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.input_Control4.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.DateTime;
            this.input_Control4.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_Control4.Edit_Mask = null;
            this.input_Control4.Edit_PasswordChar = '\0';
            this.input_Control4.EnableSet_Control = null;
            this.input_Control4.EnableSet_Index = 1;
            this.input_Control4.Field_Caption = "Birthdate";
            this.input_Control4.Field_Caption2 = "FieldName2";
            this.input_Control4.Field_Caption3 = "FieldName3";
            this.input_Control4.Field_Caption4 = "FieldName4";
            this.input_Control4.Field_Description = null;
            this.input_Control4.Field_Name = null;
            this.input_Control4.Field_Value = "2017-08-14 23:39:59 PM";
            this.input_Control4.Field_Value1 = false;
            this.input_Control4.Field_Value2 = false;
            this.input_Control4.Field_Value3 = false;
            this.input_Control4.Filter_Control = null;
            this.input_Control4.Filter_FieldName = null;
            this.input_Control4.Filter_FieldName2 = null;
            this.input_Control4.Filter_TableName = null;
            this.input_Control4.Filter_Value = null;
            this.input_Control4.Filter_Value2 = null;
            this.input_Control4.Location = new System.Drawing.Point(3, 117);
            this.input_Control4.Lookup_IDName = null;
            this.input_Control4.Lookup_ValueName = null;
            this.input_Control4.Name = "input_Control4";
            this.input_Control4.Parent_GroupBox = this.groupBox_1;
            this.input_Control4.Parent_Panel = null;
            this.input_Control4.Path_Filter = "*.*";
            this.input_Control4.Path_FilterName = "All Files";
            this.input_Control4.Size = new System.Drawing.Size(202, 35);
            this.input_Control4.TabIndex = 0;
            this.input_Control4.ValueSet_Control = null;
            this.input_Control4.VisibleSet_Control = null;
            this.input_Control4.VisibleSet_Index = 1;
            // 
            // input_Control5
            // 
            this.input_Control5._Control_Action = true;
            this.input_Control5._Control_Centre = 80;
            this.input_Control5._Control_Rows = 1;
            this.input_Control5._Control_Sync = false;
            this.input_Control5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.input_Control5.Action_AutoSave = true;
            this.input_Control5.Action_Button = true;
            this.input_Control5.Action_Custom = Lamedal_UIWinForms.domain.Enumerals.enControl_InputCustomAction.File_Open_Edit;
            this.input_Control5.Action_EnterButton = null;
            this.input_Control5.Action_Text = "..";
            this.input_Control5.Action_Width = 30;
            this.input_Control5.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.input_Control5.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.input_Control5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input_Control5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_Control5.Border = false;
            this.input_Control5.Border_Color = System.Drawing.Color.Red;
            this.input_Control5.Border_Width = 2;
            this.input_Control5.CausesValidation = false;
            this.input_Control5.Combo_DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.input_Control5.ControlType = Lamedal_UIWinForms.domain.Enumerals.enControl_InputType.Edit;
            this.input_Control5.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_Control5.Edit_Mask = null;
            this.input_Control5.Edit_PasswordChar = '\0';
            this.input_Control5.EnableSet_Control = null;
            this.input_Control5.EnableSet_Index = 1;
            this.input_Control5.Field_Caption = "Click to select the file";
            this.input_Control5.Field_Caption2 = "FieldName2";
            this.input_Control5.Field_Caption3 = "FieldName3";
            this.input_Control5.Field_Caption4 = "FieldName4";
            this.input_Control5.Field_Description = null;
            this.input_Control5.Field_Name = null;
            this.input_Control5.Field_Value = "";
            this.input_Control5.Field_Value1 = false;
            this.input_Control5.Field_Value2 = false;
            this.input_Control5.Field_Value3 = false;
            this.input_Control5.Filter_Control = null;
            this.input_Control5.Filter_FieldName = null;
            this.input_Control5.Filter_FieldName2 = null;
            this.input_Control5.Filter_TableName = null;
            this.input_Control5.Filter_Value = null;
            this.input_Control5.Filter_Value2 = null;
            this.input_Control5.Location = new System.Drawing.Point(3, 152);
            this.input_Control5.Lookup_IDName = null;
            this.input_Control5.Lookup_ValueName = null;
            this.input_Control5.Name = "input_Control5";
            this.input_Control5.Parent_GroupBox = this.groupBox_1;
            this.input_Control5.Parent_Panel = null;
            this.input_Control5.Path_Filter = "*.*";
            this.input_Control5.Path_FilterName = "All Files";
            this.input_Control5.Size = new System.Drawing.Size(202, 35);
            this.input_Control5.TabIndex = 0;
            this.input_Control5.ValueSet_Control = null;
            this.input_Control5.VisibleSet_Control = null;
            this.input_Control5.VisibleSet_Index = 1;
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.button_Standard1);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2.Location = new System.Drawing.Point(0, 255);
            this.panel_2.Name = "panel_2";
            this.panel_2.Parent_GroupBox = null;
            this.panel_2.Parent_Panel = null;
            this.panel_2.Size = new System.Drawing.Size(530, 42);
            this.panel_2.TabIndex = 2;
            // 
            // button_Standard1
            // 
            this.button_Standard1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_Standard1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.button_Standard1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.button_Standard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Standard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Standard1.CausesValidation = false;
            this.button_Standard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Standard1.Location = new System.Drawing.Point(0, 0);
            this.button_Standard1.Name = "button_Standard1";
            this.button_Standard1.Size = new System.Drawing.Size(530, 42);
            this.button_Standard1.TabIndex = 0;
            this.button_Standard1.Text_Apply = "&Apply";
            this.button_Standard1.Text_Cancel = "&Cancel";
            this.button_Standard1.Text_Clipboard = "Copy to Clipboard";
            this.button_Standard1.Text_Help = "&Help";
            this.button_Standard1.Text_Ok = "&Ok";
            this.button_Standard1.Text_Reset = false;
            this.button_Standard1.Visible_Apply = true;
            this.button_Standard1.Visible_Cancel = true;
            this.button_Standard1.Visible_Clipboard = true;
            this.button_Standard1.Visible_Help = true;
            this.button_Standard1.Visible_Ok = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 297);
            this.Controls.Add(this.groupBox_1);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.panel_2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.panel_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.panel.Panel_ panel_1;
        private UControl._Designer.ComboBox_ comboBox_1;
        private UControl._Designer.Label_ label_1;
        private UControl._Designer.GroupBox_ groupBox_1;
        private UControl.Input.Input_Control input_Control5;
        private UControl.Input.Input_Control input_Control4;
        private UControl.Input.Input_Control input_Control3;
        private UControl.Input.Input_Control input_Control2;
        private UControl.Input.Input_Control input_Control1;
        private UControl.panel.Panel_ panel_2;
        private UControl.button.Button_Standard button_Standard1;
    }
}

