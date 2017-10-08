using System.Windows.Forms;
using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;
using Lamedal_UIWinForms.libUI.WinForms.Controls;
using Lamedal_UIWinForms.libUI.WinForms.WinDB;
using Lamedal_UIWinForms.zzz;

namespace Lamedal_UIWinForms.libUI.WinForms
{
    [BlueprintRule_Class(enBlueprint_ClassNetworkType.Undefined)]
    public sealed class WinForms_
    {

        #region Dialog_Simple
        /// <summary>
        /// Gets the Dialog_Simple library methods.
        /// </summary>
        public WinForms_Dialog_Simple Dialog_Simple
        {
            get { return _Dialog_Simple ?? (_Dialog_Simple = new WinForms_Dialog_Simple()); }
        }
        private WinForms_Dialog_Simple _Dialog_Simple;
        #endregion


        #region Idle
        /// <summary>
        /// Gets the Idle library methods.
        /// </summary>
        public WinForms_Idle Idle
        {
            get { return _Idle ?? (_Idle = new WinForms_Idle()); }
        }
        private WinForms_Idle _Idle;
        #endregion


        #region Tools
        /// <summary>
        /// Gets the Tools library methods.
        /// </summary>
        public WinForms_Tools Tools
        {
            get { return _Tools ?? (_Tools = new WinForms_Tools()); }
        }
        private WinForms_Tools _Tools;
        #endregion


        #region MindMap
        /// <summary>
        /// Gets the MindMap library methods.
        /// </summary>
        public WinForms_MindMap MindMap
        {
            get { return _MindMap ?? (_MindMap = new WinForms_MindMap()); }
        }
        private WinForms_MindMap _MindMap;
        #endregion

        #region DB
        /// <summary>
        /// Gets the DB library methods.
        /// </summary>
        public WinDB_ DB
        {
            get { return _DB ?? (_DB = new WinDB_()); }
        }
        private WinDB_ _DB;
        #endregion


        #region Console
        /// <summary>
        /// Gets the Console library methods.
        /// </summary>
        public WinForms2_Console Console
        {
            get { return _Console ?? (_Console = new WinForms2_Console()); }
        }
        private WinForms2_Console _Console;
        #endregion


        #region Controls
        /// <summary>
        /// Gets the Controls library methods.
        /// </summary>
        public Controls_ Controls
        {
            get { return _Controls ?? (_Controls = new Controls_()); }
        }
        private Controls_ _Controls;
        #endregion


        #region Dialogs
        /// <summary>
        /// Gets the Dialogs library methods.
        /// </summary>
        public WinForms2_Dialogs Dialogs
        {
            get { return _Dialogs ?? (_Dialogs = new WinForms2_Dialogs()); }
        }
        private WinForms2_Dialogs _Dialogs;
        #endregion


        #region Form
        /// <summary>
        /// Gets the Forms library methods.
        /// </summary>
        public WinForms2_Form Form
        {
            get { return UI_Form ?? (UI_Form = new WinForms2_Form()); }
        }
        private WinForms2_Form UI_Form;
        #endregion


        #region FormGenerate
        /// <summary>
        /// Gets the FormGenerate library methods.
        /// </summary>
        public WinForms2_FormGenerate FormGenerate
        {
            get { return _FormGenerate ?? (_FormGenerate = new WinForms2_FormGenerate()); }
        }
        private WinForms2_FormGenerate _FormGenerate;
        #endregion


        #region Screen
        /// <summary>
        /// Gets the Screen library methods.
        /// </summary>
        public WinForms2_Screen Screen
        {
            get { return _Screen ?? (_Screen = new WinForms2_Screen()); }
        }
        private WinForms2_Screen _Screen;
        #endregion


        #region SendKeys
        /// <summary>
        /// Gets the SendKeys library methods.
        /// </summary>
        public WinForms2_SendKeys SendKeys
        {
            get { return _SendKeys ?? (_SendKeys = new WinForms2_SendKeys()); }
        }
        private WinForms2_SendKeys _SendKeys;
        #endregion


        #region Setting
        /// <summary>
        /// Gets the Setting library methods.
        /// </summary>
        public WinForms2_Setting Setting
        {
            get { return _Setting ?? (_Setting = new WinForms2_Setting()); }
        }
        private WinForms2_Setting _Setting;
        #endregion

        /// <summary>
        /// Move Method to UI Thread. If method was called on UI thread true is returned.
        /// </summary>
        /// <param name="control">The FRM.</param>
        /// <param name="method">The method.</param>
        /// <returns>True if the method was called on the UI threand</returns>
        public bool Method_Move2UI_Thread(Control control, MethodInvoker method)
        {
            // if (Method_Move2UI_Thread(control, methodName)) return;     // Call this method on the UI thread
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(method)); //{ sender, e }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether the control is on main thread.
        /// </summary>
        /// <param name="control">The control</param>
        /// <param name="showMsg">Show msg indicator. Default value = false.</param>
        /// <returns>bool</returns>
        public bool Control_IsNotOnMainThread(Control control, bool showMsg = false)
        {
            if (control.InvokeRequired)
            {
                if (showMsg) "Error! Not on main thread.".zOk();
                return true;
            }
            return false;
        }
    }
}
