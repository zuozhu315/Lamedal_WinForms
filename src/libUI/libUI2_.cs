using LamedalCore.domain.Attributes;
using LamedalCore.domain.Enumerals;
using Lamedal_UIWinForms.libUI.AvalonEdit;
using Lamedal_UIWinForms.libUI.WinForms;

namespace Lamedal_UIWinForms.libUI
{
    [BlueprintRule_Class(enBlueprint_ClassNetworkType.Undefined)]
    public sealed class libUI2_
    {
        #region AvalonEdit
        /// <summary>
        /// Gets the AvalonEdit library methods.
        /// </summary>
        public AvalonEdit_ AvalonEdit
        {
            get { return _AvalonEdit ?? (_AvalonEdit = new AvalonEdit_()); }
        }
        private  AvalonEdit_ _AvalonEdit;
        #endregion

        #region WinForms
        /// <summary>
        /// Gets the WinForms library methods.
        /// </summary>
        public WinForms_ WinForms
        {
            get { return _WinForms ?? (_WinForms = new WinForms_()); }
        }
        private WinForms_ _WinForms;
        #endregion
        
    }
}
