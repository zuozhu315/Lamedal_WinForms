using System;
using System.ComponentModel;
using System.Drawing;
using Lamedal_UIWinForms.UControl._Designer;

namespace Lamedal_WinFormsControls.UControl
{
    [ProvideToolboxControl("Lamedal_WinFormsControls.UControl.zeeCheckBox", false)]
    [Description("CheckBox control")]
    [Serializable]
    //[DefaultEvent("Event_OnValueChange")]
    [DefaultProperty("Name")]
    //[Designer(typeof(UControl_Interface_Designer))] // Link the designer   
    //[Docking(DockingBehavior.Ask)] // Dock in parent control
    //[ToolboxItem(true)]
    [ToolboxBitmap("Resources.checkbox_16xLG.bmp")]
    public class zeeComboBox : ComboBox_
    {
    }
}
