using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;
using LamedalCore.lib;
using LamedalCore.lib.IO;
using Lamedal_UIWinForms.lib.dotNet;

namespace Lamedal_UIWinForms.lib
{
    [BlueprintRule_Class(enBlueprint_ClassNetworkType.Undefined)]
    public class lib2_ : lib_
    {
        #region dotNet
        /// <summary>
        /// Gets the dotNet library methods.
        /// </summary>
        public dotNet_ dotNet
        {
            get { return _dotNet ?? (_dotNet = new dotNet_()); }
        }
        private dotNet_ _dotNet;
        #endregion


        #region Registry
        /// <summary>
        /// Gets the Registry library methods.
        /// </summary>
        public lib2_Registry Registry
        {
            get { return _Registry ?? (_Registry = new lib2_Registry()); }
        }
        private lib2_Registry _Registry;
        #endregion


        #region System
        /// <summary>
        /// Gets the lib2_System library methods.
        /// </summary>
        public lib2_System System
        {
            get { return _lib2_System ?? (_lib2_System = new lib2_System()); }
        }
        private lib2_System _lib2_System;
        #endregion
    }
}
