using System.Windows.Forms;
using ICSharpCode.AvalonEdit;
using LamedalCore.zz;
using LamedalCore_Templates;
using Lamedal_UIWinForms.zzz;

namespace Lamedal_UIWinForms.Test.tests.Forms
{
    public static class Form_cSharpCode_Methods
    {
        /// <summary>
        /// Automatic execute this code on form load.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        /// <param name="editor">The editor.</param>
        public static void AutoExec(Form_cSharpCode form, out TextEditor editor)
        {
            form.groupHeader.Text = "";
            form.groupDetail.Text = "";
            form.Top = 70;
            Size_Small(form);
            Move_RightEdge(form);
            editor = Lamedal_WinForms.Instance.libUI.AvalonEdit.TextEditor_Create(form.groupDetail, form.elementHost1);

        }

        #region Size

        /// <summary>
        /// Size the form to be small.
        /// </summary>
        /// <param name="form">The form</param>
        public static void Size_Small(Form form)
        {
            form.Width = 360;
            form.Height = 250;
        }

        /// <summary>
        /// Size form to medium.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Size_Medium(Form_cSharpCode form)
        {
            form.Width = 500;
            form.Height = 400;
        }

        /// <summary>
        /// Size form to large.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Size_Large(Form_cSharpCode form)
        {
            form.Width = 500;
            form.Height = 700;
        }

        #endregion


        #region Move

        /// <summary>
        /// Moves the form to the right edge.
        /// </summary>
        /// <param name="form">The form</param>
        public static void Move_RightEdge(Form form)
        {
            Lamedal_WinForms.Instance.libUI.WinForms.Form.Screen_MoveRightEdge(form);
        }

        /// <summary>
        /// Moves the form to the left edge.
        /// </summary>
        /// <param name="form">The form</param>
        public static void Move_LeftEdge(Form form)
        {
            Lamedal_WinForms.Instance.libUI.WinForms.Form.Screen_MoveLeftEdge(form);
        }

        /// <summary>
        /// Moves the form to the left edge.
        /// </summary>
        /// <param name="form">The form</param>
        public static void Move_TopBottomEdge(Form form)
        {
            Lamedal_WinForms.Instance.libUI.WinForms.Form.Screen_MoveTopBottomEdge(form);
        }

        #endregion


        #region Buttons

        /// <summary>
        /// Hides the buttons on the form.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Buttons_Hide(Form_cSharpCode form)
        {
            form.groupHeader.Visible = false;
            form.buttonUnHide.Visible = true;
            form.buttonPaste2.Visible = true;
        }

        /// <summary>
        /// Unhides the buttons.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Buttons_UnHide(Form_cSharpCode form)
        {
            form.groupHeader.Visible = true;
            form.buttonUnHide.Visible = false;
            form.buttonPaste2.Visible = false;
        }

        #endregion


        #region Editor

        /// <summary>
        /// Paste code from the clipboard.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Editor_PasteCodeFromClipboard(Form_cSharpCode form)
        {
            form.TopMost = true;
            string code = "".zClipboard_GetStrFrom();
            string[] lines = code.zConvert_Array_FromStr("".NL()).ToArray();
            lines = lines.zTrimLeft();
            code = lines.zTo_Str("".NL());
            form._editor.Text =code;
        }

        /// <summary>
        /// Clears the editor.
        /// </summary>
        /// <param name="form">The c sharp code form</param>
        public static void Editor_Clear(Form_cSharpCode form)
        {
            form._editor.Text = "";
        }

        #endregion

    }
}
