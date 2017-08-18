using System.Windows.Forms;
using ICSharpCode.AvalonEdit;

namespace Lamedal_UIWinForms.Test.tests.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form_cSharpCode : Form
    {
        #region Init
        private static readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib
        internal TextEditor _editor;


        public Form_cSharpCode()
        {
            InitializeComponent();
        }

        private void form_cSharpCode_Load(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.AutoExec(this, out _editor);
        }

        #endregion

        private void buttonHide_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Buttons_Hide(this);
        }

        private void buttonPaste_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Editor_PasteCodeFromClipboard(this);
        }
        
        private void buttonUnHide_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Buttons_UnHide(this);
        }

        private void buttonSmall_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Size_Small(this);  // 363, 358
        }

        private void buttonMedium_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Size_Medium(this);
        }

        private void buttonLarge_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Size_Large(this);
        }

        private void buttonRight_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Move_RightEdge(this);
        }

        private void buttonLeft_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Move_LeftEdge(this);
        }

        private void buttonTopBottom_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Move_TopBottomEdge(this);
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Editor_Clear(this);
        }

        private void buttonPaste2_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Methods.Editor_PasteCodeFromClipboard(this);
        }
    }
}
