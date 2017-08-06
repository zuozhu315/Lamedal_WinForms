using System.Drawing;
using System.Runtime.InteropServices;
using Lamedal_UIWinForms.domain.Enumerals;
using Lamedal_UIWinForms.libUI.Win32;

namespace Lamedal_UIWinForms.Assets
{
    /// <summary>
    /// Defines a set of utility methods for extracting icons for files and file types.
    /// </summary>
    public static class AssetIconTools {

        /// <summary>
        /// Icon file from the filename.
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="size">The icon size</param>
        /// <returns>Icon</returns>
        public static Icon File_Icon(string filename, enIconShell32Sizes size) 
        {
            var shell32FileInfo = new shell32_FileInfo();		
            shell32.SHGetFileInfo(filename, 0, ref shell32FileInfo, (uint)Marshal.SizeOf(shell32FileInfo), size);

            Icon icon = null;
            if (shell32FileInfo.hIcon.ToInt32() != 0) 
            {
                icon = (Icon)Icon.FromHandle(shell32FileInfo.hIcon).Clone();  
                user32.DestroyIcon(shell32FileInfo.hIcon);
            }
            return icon;
        }

        /// <summary>
        /// Icon for file extension.
        /// </summary>
        /// <param name="extension">The extension</param>
        /// <param name="size">The icon size shell3 to</param>
        /// <returns>Icon</returns>
        public static Icon File_IconForExtension(string extension, enIconShell32Sizes size) 
        {
            const uint shell32_UseFileAttributes = 0x10;  // Use the file attributes

            // Set enum to work on the file attributes
            size |= (enIconShell32Sizes)shell32_UseFileAttributes;
            return File_Icon(extension, size);
        }

    }


}