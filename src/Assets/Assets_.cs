using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Lamedal_UIWinForms.Assets
{
    public sealed class Assets_
    {
        private const string _Namespace = "Lamedal_UIWinForms.Assets.";

        #region Image
        /// <summary>
        /// Gets the Image library methods.
        /// </summary>
        public Assets_Image Image
        {
            get { return _Image ?? (_Image = new Assets_Image()); }
        }
        private Assets_Image _Image;
        #endregion

        #region ImageList
        /// <summary>
        /// Gets the ImageList library methods.
        /// </summary>
        public Assets_ImageList ImageList
        {
            get { return _ImageList ?? (_ImageList = new Assets_ImageList()); }
        }
        private Assets_ImageList _ImageList;
        #endregion

        /// <summary>
        /// Gets the namespace.
        /// </summary>
        public string Namespace { get { return _Namespace; } }


        /// <summary>
        /// Return the Resource sets from the resource assembly path.
        /// </summary>
        /// <param name="assembly">The assembly</param>
        /// <param name="ResourceAssemblyPath">The resource assembly path</param>
        /// <returns>ResourceSet</returns>
        internal ResourceSet ResourceSet(Assembly assembly, string ResourceAssemblyPath)
        {
            string resourceAssemblyPath = ResourceAssemblyPath;
            var MyResourceManager = new ResourceManager(resourceAssemblyPath, assembly);
            ResourceSet resourceSet = MyResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            return resourceSet;
        }

    }
}
