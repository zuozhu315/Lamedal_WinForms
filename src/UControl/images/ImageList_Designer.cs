using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using Lamedal_UIWinForms.domain.Enumerals;

namespace Lamedal_UIWinForms.UControl.images
{
    [System.Security.Permissions.PermissionSet
    (System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ImageList_Designer : ComponentDesigner
    {
        private DesignerActionListCollection actionLists;
        public override DesignerActionListCollection ActionLists
        {
            // Use pull model to populate smart tag menu.
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ImageList_Setup_ActionList(Component));
                }
                return actionLists;
            }
        }
    }

    /// <summary>
    /// the control with the smart tag list.
    /// </summary>
    public class ImageList_Setup_ActionList : DesignerActionList
    {
        #region Init

        private readonly ImageList_ _imageList;
        private readonly DesignerActionUIService _designerActionUISvc;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageList_Setup_ActionList" /> class. The constructor associates the control with the smart tag list.
        /// </summary>
        /// <param name="component">The component.</param>
        public ImageList_Setup_ActionList(IComponent component): base(component)
        {
            // Cache a reference to DesignerActionUIService, so the DesigneractionList can be refreshed.
            this._imageList = component as ImageList_;
            this._designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }
        #endregion

        #region Private

        private void FireChanging()
        {
            IComponentChangeService service = GetComponentChangeService();
            if (service != null) service.OnComponentChanging(this, null);
        }

        private void FireChanged()
        {
            IComponentChangeService service = GetComponentChangeService();
            if (service != null) service.OnComponentChanged(this, null, null, null);
        }

        private IComponentChangeService GetComponentChangeService()
        {
            return GetService(typeof(IComponentChangeService)) as IComponentChangeService;
        }

        #endregion

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("ImageList"));
            items.Add(new DesignerActionPropertyItem("Image_Source", "Image_Source", "ImageList"));
            items.Add(new DesignerActionPropertyItem("Image_List1", "Image_List1", "ImageList"));
            items.Add(new DesignerActionPropertyItem("Image_List2", "Image_List2", "ImageList"));
            items.Add(new DesignerActionPropertyItem("Image_Refresh", "Image_Refresh", "ImageList"));
            items.Add(new DesignerActionPropertyItem("Image_Status", "Image_Status", "ImageList"));
            
            return items;
        }
        public enBlueprintUIAssets Image_Source
        {
            get { return _imageList.Image_Source; }
            set
            {
                FireChanging();
                _imageList.Image_Source = value;
                _designerActionUISvc.Refresh(this.Component);
                FireChanged();
            }
        }
        public ImageList Image_List1
        {
            get { return _imageList.Image_List1; }
            set
            {
                FireChanging();
                _imageList.Image_List1 = value;
                FireChanged();
            }
        }
        public ImageList Image_List2
        {
            get { return _imageList.Image_List2; }
            set
            {
                FireChanging();
                _imageList.Image_List2 = value;
                FireChanged();
            }
        }
        public bool Image_Refresh
        {
            get { return _imageList.Image_Refresh; }
            set
            {
                FireChanging();
                _imageList.Image_Refresh = value;
                FireChanged();
            }
        }

        public bool Image_Status
        {
            get { return _imageList.Image_Status; }
            set
            {
                FireChanging();
                _imageList.Image_Status = value;
                FireChanged();
            }
        }
    }
}