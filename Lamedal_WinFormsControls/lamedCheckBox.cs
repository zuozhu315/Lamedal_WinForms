using System.Globalization;
using System;
using System.Windows.Forms;
using Lamedal_UIWinForms.UControl._Designer;

namespace Lamedal_WinFormsControls
{
    [ProvideToolboxControl("Lamedal_WinFormsControls.lamedCheckBox", false)]
    public partial class LamedCheckBox : UserControl
    {
        public LamedCheckBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(CultureInfo.CurrentUICulture, "We are inside {0}.Button1_Click()", this.ToString()));
        }
    }
}
