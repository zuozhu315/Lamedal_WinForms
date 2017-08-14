using System;
using System.Threading;
using System.Windows.Forms;
using Lamedal_UIWinForms.zzz;
using Xunit;

namespace Lamedal_UIWinForms.Test.tests.libUI_WinForms
{
    public sealed class WinForms_Tests
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib

        [Fact]
        [STAThread]
        public void Clipboard_CopyStrTo_Test()
        {
            var test1 = "This is a test string";
            var test2 = "Another string";
            _lamedWin.libUI.WinForms.Tools.Clipboard_CopyStrTo(test1);
            string testReturn1 = _lamedWin.libUI.WinForms.Tools.Clipboard_GetStrFrom();
            Assert.Equal(test1, testReturn1);

            _lamedWin.libUI.WinForms.Tools.Clipboard_CopyStrTo(test2);
            string testReturn2 = _lamedWin.libUI.WinForms.Tools.Clipboard_GetStrFrom();
            Assert.Equal(test2, testReturn2);
        }
    }
}