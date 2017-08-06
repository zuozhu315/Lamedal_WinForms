using System.Windows.Forms;
using Lamedal_UIWinForms.domain.Enumerals;

namespace Lamedal_UIWinForms.zzz
{
    public static class ImageList_BlueprintUIAssets
    {

        /// <summary>
        /// Load images from the Resource files.
        /// </summary>
        /// <param name="imageList">The image list</param>
        /// <param name="resourceFile">The resource file.</param>
        /// <param name="reset">if set to <c>true</c> [reset].</param>
        /// <param name="findValue">The find value.</param>
        /// <code>CTIN_Transformation;</code>
        public static void zFromResourceFile(this ImageList imageList, enBlueprintUIAssets resourceFile = enBlueprintUIAssets.All, bool reset = true, string findValue = "")
        {
            Lamedal_WinForms.Instance.Assets.ImageList.ImageList_FromResourceFile(imageList, resourceFile, reset, findValue);
        }

        /// <summary>
        /// Copies the image list to another image list.
        /// </summary>
        /// <param name="fromList">The from list</param>
        /// <param name="toList">The to list</param>
        /// <code>CTIN_Transformation;</code>
        public static void zToImageList(this ImageList fromList, ImageList toList)
        {
            Lamedal_WinForms.Instance.Assets.ImageList.ImageList_ToImageList(fromList, toList);
        }
    }
}
