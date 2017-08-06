using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Resources;
using Lamedal_UIWinForms.domain.Enumerals;

namespace Lamedal_UIWinForms.Assets
{
    public sealed class Assets_Image
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib

        /// <summary>
        /// Creates the image from BlueprintUI resource file.
        /// </summary>
        /// <param name="resourceFile">The resource file</param>
        /// <param name="resourceName">The resource name</param>
        /// <param name="resourcePath">Return the resource path</param>
        /// <returns>Image</returns>
        public Image Image_FromResourceFile(string resourceFile, string resourceName, out string resourcePath)
        {
            Image image = null;
            resourcePath = "";

            if (resourceFile == "IconFileExtentions")
            {
                Icon icon = AssetIconTools.File_IconForExtension(resourceName, enIconShell32Sizes.Icon32);
                image = icon.ToBitmap();
                return image;  // ===============================================================
            }

            if (resourceFile == "") resourceFile = "All";
            try
            {
                var resourceFileEnum = To_EnumValue<enBlueprintUIAssets>(resourceFile);   // Get the BlueprintUIAssets enumeral
            }
            catch (Exception e)
            {
                // resourceFile error
                string error = string.Format("ERROR: Resource file '{0}' does not exist in {1}", resourceFile, _lamedWin.Assets.Namespace);
                throw new ArgumentException(error, "resourceFile", e);
            }

            if (resourceFile == "All") image = Image_FromResourceFile(resourceName, out resourceFile);
            else image = Image_FromResourceFile(_lamedWin.Assets.Namespace + resourceFile, resourceName);
            resourcePath = _lamedWin.Assets.Namespace + resourceFile + "." + resourceName;
            return image;
        }

        /// <summary>
        /// Convert enumeral string value to the enumeral type value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value</param>
        /// <param name="ignoreCase">Ignore case indicator. Default value = false.</param>
        /// <param name="ignoreStrPart">The ignore string part.</param>
        /// <returns>
        /// T
        /// </returns>
        /// <code Shortcut="Enums"></code>
        private T To_EnumValue<T>(string value, bool ignoreCase = false, string ignoreStrPart = "")
        {
            // Method code duplicated from path:
            // Blueprint_.Instance.lib.Rules.Types.Enum.To_EnumValue<T>(value, ignoreCase, removeStr);
            if (ignoreStrPart != "") value = value.Replace(ignoreStrPart, "");
            T result = default(T);
            try
            {
                result = (T)Enum.Parse(typeof(T), value, ignoreCase);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                string typeName = typeof(T).ToString();
                string errMsg = string.Format("ERROR: Value '{0}' was not found in type {1}", value, typeName);
                throw new ArgumentException(errMsg, value, e);
            }
            return result;
        }

        

        /// <summary>
        /// Creates the image from resource file from the key.
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="resourceFile">The resource file setting. Default value = eBlueprintUIAssets.ActorBody.</param>
        /// <returns>Image</returns>
        public Image Image_FromResourceFile(string key, out string resourceFile)
        {
            Image image = null;
            string[] resourceFiles = Enum.GetNames(typeof(enBlueprintUIAssets));
            foreach (string file in resourceFiles)
            {
                if (file == "All") continue;
                image = Image_FromResourceFile(_lamedWin.Assets.Namespace + file, key, false);
                if (image != null)
                {
                    resourceFile = file;
                    return image;
                }
            }
            resourceFile = "All";
            return null;
        }

        /// <summary>
        /// Creates the image from resource file from the resource assembly path.
        /// </summary>
        /// <param name="ResourceAssemblyPath">The resource assembly path</param>
        /// <param name="key">The key</param>
        /// <param name="showError">if set to <c>true</c> [show error].</param>
        /// <returns>
        /// Image
        /// </returns>
        public Image Image_FromResourceFile(string ResourceAssemblyPath, string key, bool showError = true)
        {
            Assembly assembly = typeof(Lamedal_WinForms).Assembly;
            Image image = Image_FromResourceFile(ResourceAssemblyPath, key, assembly, showError);
            return image;
        }

        /// <summary>
        /// Load images from the Resource files.
        /// </summary>
        /// <param name="ResourceAssemblyPath">The resource assembly path</param>
        /// <param name="key">The key.</param>
        /// <param name="assembly">The assembly.</param>
        /// <param name="showError">if set to <c>true</c> [show error].</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">key</exception>
        private Image Image_FromResourceFile(string ResourceAssemblyPath, string key, Assembly assembly, bool showError = true)
        {
            ResourceSet resourceSet = _lamedWin.Assets.ResourceSet(assembly, ResourceAssemblyPath);
            var resourceDictionary = new Dictionary<string, Image>();
            foreach (DictionaryEntry entry in resourceSet)
            {
                var imageIcon = entry.Value as Icon;
                Image image1 = (imageIcon == null) ? (Image)entry.Value : imageIcon.ToBitmap();
                resourceDictionary.Add(entry.Key.ToString(), image1);
            }
            Image image;
            resourceDictionary.TryGetValue(key, out image);

            if (showError && image == null)
            {
                // This means the image is not in the resrource file
                string error = string.Format("ERROR! Image was not in the resource file '{0}' for '{1}'.",ResourceAssemblyPath, key);
                throw new ArgumentException(error, "key");
            }
            return image;
        }
    }
}
