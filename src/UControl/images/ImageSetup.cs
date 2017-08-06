using System;
using System.ComponentModel;

namespace Lamedal_UIWinForms.UControl.images
{
    [Description("Add images to buttons")]
    [Serializable]
    //DefaultEvent("Event_OnValueChange")]
    [DefaultProperty("ImageSetup")]
    [ToolboxItem(true)]
    [Designer(typeof(ImageSetup_Designer))]   // Link the designer
    public partial class ImageSetup : Component
    {
        public ImageSetup()
        {
            InitializeComponent();
        }

        public ImageSetup(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public bool ImageSet
        {
            get { return _ImageSet; }
            set
            {
                _ImageSet = value;
                if (value)
                {
                    // Do the Action
                    _frmImageResouce = new ImageSetup_Form();
                    _frmImageResouce.Setup(this);
                    _ImageSet = false;
                }
            }
        }
        private bool _ImageSet;
        private ImageSetup_Form _frmImageResouce;
    }
}
