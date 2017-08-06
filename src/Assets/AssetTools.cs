using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lamedal_UIWinForms.Assets
{
    public static class AssetTools
    {
        /// <summary>
        /// Converts enumeral to IList. 
        /// </summary>
        /// <param name="toList">The list.</param>
        /// <param name="enumToConvert">typeof(myEnum) <br></br> The enum to convert.</param>
        /// <param name="clearList">if set to <c>true</c> [clear list].</param>
        /// <param name="prefix">The prefix.</param>
        /// <param name="postfix">The postfix.</param>
        /// <param name="replaceUnderscoreWith">The replace underscore with.</param>
        /// <exception cref="System.ArgumentNullException">list</exception>
        /// <code ShortcutClass="Enums" GenerateParameter1="enumToConvert"></code>
        public static void zEnum_To_IList(this IList toList, Type enumToConvert, bool clearList = true, string prefix = "", string postfix = "", string replaceUnderscoreWith = "_")
        {
            if (toList == null) throw new ArgumentNullException("toList");

            if (clearList) toList.Clear();
            foreach (string enumValue in Enum.GetNames(enumToConvert))
            {
                toList.Add(prefix + enumValue.Replace("_", replaceUnderscoreWith) + postfix);
            }
        }

        /// <summary>
        /// Converts enumeral to IList. 
        /// </summary>
        /// <param name="toList">The list.</param>
        /// <param name="enumToConvert">typeof(myEnum) <br></br> The enum to convert.</param>
        /// <param name="clearList">if set to <c>true</c> [clear list].</param>
        /// <param name="prefix">The prefix.</param>
        /// <param name="postfix">The postfix.</param>
        /// <param name="replaceUnderscoreWith">The replace underscore with.</param>
        /// <exception cref="System.ArgumentNullException">list</exception>
        /// <code>CTIM_Generation;</code>
        public static void zEnum_To_IList(this Type enumToConvert, IList toList, bool clearList = true, string prefix = "", string postfix = "", string replaceUnderscoreWith = "_")
        {
            //=================
            // Generated @ 2015/01/23
            // Generated from 'Blueprint.Rules.Types.List.To_IList'() -> the parameter order was changed to ensure better MTIN results after transformations.
            zEnum_To_IList(toList, enumToConvert, clearList, prefix, postfix, replaceUnderscoreWith);
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
        public static T zEnum_To_EnumValue<T>(this string value, bool ignoreCase = false, string ignoreStrPart = "")
        {
            if (ignoreStrPart != "") value = value.Replace(ignoreStrPart, "");
            T result = default(T);
            try
            {
                result = (T)Enum.Parse(typeof(T), value, ignoreCase);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                string typeName = typeof(T).ToString();
                string errMsg = string.Format("ERROR: Value '{0}' was not found in type {1}", value, typeName);
               MessageBox.Show(errMsg);
            }
            return result;
        }

        /// <summary>
        /// Create ListView from image list.
        /// </summary>
        /// <param name="listView">The list view</param>
        /// <param name="imageList">The image list</param>
        /// <param name="view">The view setting. Default value = View.LargeIcon.</param>
        public static void zListView_FromImageList(this ListView listView, ImageList imageList, View view = View.LargeIcon)
        {
            listView.View = view; //View.LargeIcon;  View.Icon16;  View.Details;
            listView.LargeImageList = imageList;
            listView.SmallImageList = imageList;
            listView.Items.Clear();
            for (int ii = 0; ii < imageList.Images.Count; ii++)
            {
                zListView_FromImageList(listView, imageList, ii);
            }
        }

        /// <summary>
        /// Create ListView from image list.
        /// </summary>
        /// <param name="listView">The list view</param>
        /// <param name="imageList">The image list</param>
        /// <param name="index">The index</param>
        public static void zListView_FromImageList(ListView listView, ImageList imageList, int index)
        {
            var item1 = new ListViewItem();
            item1.ImageIndex = index;
            item1.Text = "" + imageList.Images.Keys[index];
            listView.Items.Add(item1);
        }

        /// <summary>
        /// Send text followed by the 'Enter' key to the specified control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        public static void zENTERtext(this Control control, string text)
        {
            control.Text = text;
            zENTER(control);
        }

        /// <summary>
        /// Send 'Enter' to the specified control.
        /// </summary>
        /// <param name="control">The control.</param>
        public static void zENTER(this Control control)
        {
            control.Focus();
            SendKeys.Send("{ENTER}");
        }

        /// <summary>
        /// Determines whether the specified e (event argument) is a ENTER key.
        /// </summary>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        public static bool zIsEnter(this KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                return true;
            }
            return false;
        }

        /// <summary>Search for item in ListBox and return the index of the item.</summary>
        /// <param name="listBox">The list box.</param>
        /// <param name="searchItem">The search item.</param>
        public static int zListBox_SearchItem(this ListBox listBox, string searchItem)
        {
            listBox.SelectedIndex = -1;
            for (int ii = 0; ii < listBox.Items.Count; ii++)
            {
                string item = listBox.Items[ii].ToString();
                if (item == searchItem)
                {
                    listBox.Focus();
                    listBox.SelectedIndex = ii;
                    return ii;
                }
            }
            return -1;
        }
    }
}
