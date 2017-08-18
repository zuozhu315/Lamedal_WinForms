using System;
using System.ComponentModel;
using System.Windows.Forms;
using Lamedal_UIWinForms.domain.Enumerals;
using Lamedal_UIWinForms.zzz;

namespace Lamedal_UIWinForms.UControl.images
{
    [Description("Set ImageList images")]
    [Serializable]
    //DefaultEvent("Event_OnValueChange")]
    [DefaultProperty("Image_Source")]
    [ToolboxItem(true)]
    [Designer(typeof(ImageList_Setup_Designer))]   // Link the designer
    public partial class ImageList_Setup : Component
    {
        public ImageList_Setup()
        {
            InitializeComponent();
        }

        public ImageList_Setup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Image_Source
        [RefreshProperties(RefreshProperties.All)]
        [Description("Set the image resouce file to load")]
        public enBlueprintUIAssets Image_Source
        {
            get { return _Image_Source; }
            set
            {
                if (_Image_Source != value)
                {
                    _Image_Source = value;
                    Setup_Refresh(_imageList1);
                    Setup_Refresh(_imageList2);
                }
            }
        }
        private enBlueprintUIAssets _Image_Source = enBlueprintUIAssets.ToolEdit;
        #endregion

        #region Image_List1
        [RefreshProperties(RefreshProperties.All)]
        public System.Windows.Forms.ImageList Image_List1
        {
            get { return _imageList1; }
            set
            {
                _imageList1 = value;
                if (_imageList1 != null)
                {
                    _imageList1.RecreateHandle -= ImageList_Refresh;
                    _imageList1.RecreateHandle += ImageList_Refresh;
                    Setup_Refresh(_imageList1);
                }
            }
        }
        private System.Windows.Forms.ImageList _imageList1;
        #endregion

        #region Image_List2
        [RefreshProperties(RefreshProperties.All)]
        public System.Windows.Forms.ImageList Image_List2
        {
            get { return _imageList2; }
            set
            {
                _imageList2 = value;
                if (_imageList2 != null)
                {
                    _imageList2.RecreateHandle -= ImageList_Refresh;
                    _imageList2.RecreateHandle += ImageList_Refresh;
                    Setup_Refresh(_imageList2);
                }
            }
        }
        private System.Windows.Forms.ImageList _imageList2;
        #endregion

        #region Image_Refresh
        [RefreshProperties(RefreshProperties.All)]
        [Description("Refreshes the ImageList controls")]
        public bool Image_Refresh
        {
            get { return _Image_Refresh; }
            set
            {
                _Image_Refresh = value;
                if (value)
                {
                    Setup_Refresh(_imageList1);
                    Setup_Refresh(_imageList2);
                }
                _Image_Refresh = false;
            }
        }
        private bool _Image_Refresh;
        #endregion

        #region Image_Status
        [RefreshProperties(RefreshProperties.All)]
        [Description("Show the status of the ImageList controls.")]
        public bool Image_Status
        {
            get { return _Image_Status; }
            set
            {
                _Image_Status = value;
                if (value)
                {
                    var msg = "";
                    Setup_Status(_imageList1, 1, ref msg);
                    Setup_Status(_imageList2, 2, ref msg);

                    MessageBox.Show(msg);
                }
                _Image_Status = false;
            }
        }
        private bool _Image_Status;
        #endregion

        private void Setup_Refresh(ImageList imageList)
        {
            if (imageList == null) return;
            imageList.zFromResourceFile(_Image_Source);
        }

        private void Setup_Status(ImageList imageList, int no, ref string msg)
        {
            if (msg == "") msg = "Image_Source = " + _Image_Source.ToString() + Environment.NewLine;
            var name = "ImageList" + no;
            if (imageList == null) msg += name + " = 0." + Environment.NewLine;
            else
            {
                msg += name + " = " + imageList.Images.Count + "; (" + imageList.ImageSize.Width + "," +
                       imageList.ImageSize.Height + ")" + Environment.NewLine;
            }
        }

        private void ImageList_Refresh(object sender, EventArgs e)
        {
            var imageList = sender as ImageList;
            Setup_Refresh(imageList);
        }

    }
}
