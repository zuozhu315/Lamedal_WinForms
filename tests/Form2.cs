using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.AvalonEdit;

namespace Lamedal_UIWinForms.Test
{
    public partial class Form2 : Form
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib
        private TextEditor _editor;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _editor = _lamedWin.libUI.AvalonEdit.TextEditor_Create(panel_2, elementHost1);
            _editor.Text = "test";
        }
    }
}
