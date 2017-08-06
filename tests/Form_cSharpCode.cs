using System.Windows.Forms;

namespace Lamedal_UIWinForms.Test
{
    /// <summary>
    /// 
    /// </summary>
    public partial class form_cSharpCode : Form
    {
        #region Init

        public form_cSharpCode()
        {
            InitializeComponent();
        }

        private void form_cSharpCode_Load(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.AutoExec(this);
        }

        #endregion

        private void buttonHide_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Buttons_Hide(this);
        }

        private void buttonPaste_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Editor_PasteCodeFromClipboard(this);
        }
        
        private void buttonUnHide_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Buttons_UnHide(this);
        }

        private void buttonSmall_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Size_Small(this);  // 363, 358
        }

        private void buttonMedium_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Size_Medium(this);
        }

        private void buttonLarge_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Size_Large(this);
        }

        private void buttonRight_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Move_RightEdge(this);
        }

        private void buttonLeft_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Move_LeftEdge(this);
        }

        private void buttonTopBottom_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Move_TopBottomEdge(this);
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Editor_Clear(this);
        }

        private void buttonPaste2_Click(object sender, System.EventArgs e)
        {
            Form_cSharpCode_Agent.Editor_PasteCodeFromClipboard(this);
        }
    }
}
