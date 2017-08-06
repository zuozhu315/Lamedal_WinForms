using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamedal_UIWinForms.domain.Enumerals;
using Xunit;

namespace Lamedal_UIWinForms.Test.tests
{
    public sealed class AssetResource_Test
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib

        [Fact]
        public void Image_FromResourceFile_Test()
        {
            string resourcePath;
            Image Image = _lamedWin.Assets.Image.Image_FromResourceFile(enBlueprintUIAssets.All.ToString(), "toolZap", out resourcePath);
            Assert.Equal("BlueprintUI.Assets.Images.ToolOther.toolZap", resourcePath);

            Image = _lamedWin.Assets.Image.Image_FromResourceFile("", "toolZap", out resourcePath);
            Assert.Equal("BlueprintUI.Assets.Images.ToolOther.toolZap", resourcePath);

            Image = _lamedWin.Assets.Image.Image_FromResourceFile("ToolOther", "toolZap", out resourcePath);
            Assert.Equal("BlueprintUI.Assets.Images.ToolOther.toolZap", resourcePath);
        }

        [Fact]
        //[ExpectedException(typeof(ArgumentException))]
        public void Image_FromResourceFile_TestFail1()
        {
            string resourcePath;
            Image Image = _lamedWin.Assets.Image.Image_FromResourceFile("All1", "toolZap", out resourcePath);

        }

        [Fact]
        //[ExpectedException(typeof(ArgumentException))]
        public void Image_FromResourceFile_TestFail2()
        {
            string resourcePath;
            Image Image = _lamedWin.Assets.Image.Image_FromResourceFile("ToolIO", "toolZap", out resourcePath);
            Assert.Equal("BlueprintUI.Assets.Images.ToolOther.toolZap", resourcePath);

        }
    }
}
