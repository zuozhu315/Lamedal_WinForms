using System.ComponentModel;
using System.ComponentModel.Design;
using Lamedal_UIWinForms.libUI.WinForms.UIDesigner;

namespace Lamedal_UIWinForms.UControl.images
{
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ImageSetup_Designer : ComponentDesigner
    {
        private DesignerActionListCollection actionLists;

        public override DesignerActionListCollection ActionLists
        {
            // Use pull model to populate smart tag menu.
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ImageSetup_ActionList(Component));
                }
                return actionLists;
            }
        }
    }

    /// <summary>
    /// the control with the smart tag list.
    /// </summary>
    public class ImageSetup_ActionList : DesignerActionList
    {
        #region Init

        private readonly ImageSetup _Control;
        private readonly DesignerActionUIService _designerActionUIService;
        //private ImageSetup_Form _frmImageResouce;

        public ImageSetup_ActionList(IComponent component) : base(component)
        {
            // Cache a reference to DesignerActionUIService, so the DesigneractionList can be refreshed.
            this._Control = component as ImageSetup;
            this._designerActionUIService = UIDesigner_Service.DesignerActionUIService_FromActionList(this);
        }

        #endregion

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Image Setup"));
            items.Add(new DesignerActionPropertyItem("ImageSet", "Image Set:", "Image Setup"));
            return items;
        }

        public bool ImageSet
        {
            get { return _Control.ImageSet; }
            set
            {
                UIDesigner_Tools.Change_Begin(this);
                _Control.ImageSet = value;
                if (value)
                {
                    //_frmImageResouce = new ImageSetup_Form();
                    //_frmImageResouce.Setup(this);
                    //_Control.ImageSet = false;
                }
                UIDesigner_Tools.Change_End(this);
            }
        }
    }
}
