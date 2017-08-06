using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Lamedal_UIWinForms.domain.Enumerals;

namespace Lamedal_UIWinForms.Assets
{
    public sealed class Assets_ImageList
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib

        /// <summary>
        /// Load images from the Resource files.
        /// </summary>
        /// <param name="imageList">The image list</param>
        /// <param name="resourceFile">The resource file.</param>
        /// <param name="reset">if set to <c>true</c> [reset].</param>
        /// <param name="findValue">The find value.</param>
        public void ImageList_FromResourceFile(ImageList imageList, enBlueprintUIAssets resourceFile = enBlueprintUIAssets.All, bool reset = true, string findValue = "")
        {
            Assembly assembly = typeof(Lamedal_WinForms).Assembly;

            if (reset) imageList.Images.Clear();
            if (findValue != "") resourceFile = enBlueprintUIAssets.All;  // Search all resource files

            if (resourceFile != enBlueprintUIAssets.All)
            {
                if (resourceFile == enBlueprintUIAssets.IconFileExtentions) FileIcons(imageList);
                else ImageList_FromResourceFile(assembly, imageList, _lamedWin.Assets.Namespace + resourceFile);
                return;  // <======================================================================
            }

            // No resource file was provided -> Load all images from all resource files
            string[] resourceFiles = Enum.GetNames(typeof(enBlueprintUIAssets));
            foreach (string file in resourceFiles)
            {
                if (file == "All") continue;
                if (file == "IconFileExtentions")
                {
                    FileIcons(imageList);
                    continue;
                }
                ImageList_FromResourceFile(assembly, imageList, _lamedWin.Assets.Namespace + file, findValue);
            }
            #region Ignore
            //ImageList_FromResourceFile(imageList, Namespace + "ActorBody", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ActorFace", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "DataBool", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "DataDB", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "DataNumbers", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "DataTree", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ShapeArrow", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ShapeOther", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ToolAction", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ToolChart", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ToolEdit", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ToolIO", typeof(eBlueprintUIAssets));
            //ImageList_FromResourceFile(imageList, Namespace + "ToolOther", typeof(eBlueprintUIAssets));
            #endregion
        }

        public void FileIcons(ImageList imageList)
        {
            var iconList = new List<string>();
            foreach (string enumValue in Enum.GetNames(typeof(enIconFileTypes)))
            {
                string ext = "." +enumValue.Replace("_", "");
                Icon icon = AssetIconTools.File_IconForExtension(ext, enIconShell32Sizes.Icon32);
                imageList.Images.Add(ext, icon.ToBitmap());
            }
        }

        /// <summary>
        /// Load images from the Resource files.
        /// </summary>
        /// <param name="assembly">The assembly type</param>
        /// <param name="imageList">The image list</param>
        /// <param name="ResourceAssemblyPath">The resource assembly path</param>
        /// <param name="findValue">The find value.</param>
        private void ImageList_FromResourceFile(Assembly assembly, ImageList imageList, string ResourceAssemblyPath, string findValue = "")
        {
            ResourceSet resourceSet = _lamedWin.Assets.ResourceSet(assembly, ResourceAssemblyPath);

            foreach (DictionaryEntry entry in resourceSet)
            {
                var resourceKey = entry.Key as string;
                var resourceIcon = entry.Value as Icon;
                Image resourceImage = (resourceIcon != null)? resourceIcon.ToBitmap() : entry.Value as Image;
                if (resourceImage != null && resourceKey != null)
                {
                    if (findValue == "" || resourceKey.ToLower().Contains(findValue)) imageList.Images.Add(resourceKey, resourceImage);
                }
            }
        }

        /// <summary>
        /// Copies the image list to another image list.
        /// </summary>
        /// <param name="fromList">The from list</param>
        /// <param name="toList">The to list</param>
        public void ImageList_ToImageList(ImageList fromList, ImageList toList)
        {
            for (int ii = 0; ii < fromList.Images.Count; ii++)
            {
                string key = fromList.Images.Keys[ii];
                toList.Images.Add(key, fromList.Images[ii]);
            }
        }
    }
}
