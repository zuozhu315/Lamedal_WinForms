using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Lamedal_UIWinForms.Assets;
using Lamedal_UIWinForms.domain.Enumerals;
using Lamedal_UIWinForms.libUI.WinForms.UIDesigner;
using Lamedal_UIWinForms.zzz;

namespace Lamedal_UIWinForms.UControl.images
{
    public partial class ImageSetup_Form : Form
    {
        private readonly Lamedal_WinForms _lamedWin = Lamedal_WinForms.Instance;  // Load the winforms lib

        private string _resourceText;
        private List<Component> _components;
        private IDesignerHost _host;
        private Image _image;
        private Component _designer;
        private bool _SelectionChanged;

        public ImageSetup_Form()
        {
            InitializeComponent();

            // Load combobox values
            typeof(View).zEnum_To_IList(comboBox_Icons.Items);
            typeof(enBlueprintUIAssets).zEnum_To_IList(comboBox_Resources.Items);
            comboBox_Resources.Text = "All";
            Setup_Refresh();
        }

        private void button_LoadImages_Click(object sender, EventArgs e)
        {
            Setup_Refresh();
        }

        private void comboBox_Resources_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
            Setup_Refresh();
        }

        private void comboBox_Icons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setup_Refresh();
        }

        private void Setup_Refresh(string findValue = "")
        {
            // Load all images from the resource file
            _resourceText = comboBox_Resources.Text;
            var resourceFile = _resourceText.zEnum_To_EnumValue<enBlueprintUIAssets>();   // Get the BlueprintUIAssets enumeral
            imageList1.zFromResourceFile(resourceFile, findValue: findValue);  // Load the resources into imagelist

            // Show all images in the listview control
            AssetTools.zListView_FromImageList(listView1, imageList1, View_Get());
        }

        private View View_Get()
        {
            string viewText = comboBox_Icons.Text;
            var view = viewText.zEnum_To_EnumValue<View>(); // Get the View enumeral
            return view;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            ListViewItem item = listView1.SelectedItems[0];
            string resourceName = item.Text;
            string resourceFile = _resourceText;

            string resourcePath;
            _image = _lamedWin.Assets.Image.Image_FromResourceFile(resourceFile, resourceName, out resourcePath);
            Image image2 = Image_Scale(_image, comboBox_Resize);
            textBox_Path2Image.Text = resourcePath+";";

            button_Image.Image = image2;
            input_Width.Text = _image.Width.ToString();
            input_Height.Text = _image.Height.ToString();

            //if (_image.Width <= 32 && _image.Height <= 32) checkBox_Iconable.Checked = true;
            Icon icon = Bmp_ToIcon(new Bitmap(_image));
            this.Icon = icon;
        }

        private void comboBox_Resize_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged(sender, e);
        }

        private void button_Pictures_Click(object sender, EventArgs e)
        {
            //Send text followed by the 'Enter' key to the specified control.
            textBox_Search.zENTERtext("pic");
        }

        private void textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.zIsEnter())
            {
                // Do the search of the text box
                //textBox_Search.Text.zOk();
                Setup_Refresh(textBox_Search.Text);
                _resourceText = "All";
            }
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            if (_image == null) return;

            Image image2 = Image_Scale(_image, comboBox_Resize);
            Icon icon = Bmp_ToIcon(new Bitmap(image2));
            this.Icon = icon;

            if (_components == null) return;  // This form was run in normal mode (and not from a component)

            //Component component1 = Control_Selected();
            Component component1 = UIDesigner_Component.ControlNames(_components, listBox_Components.Text);
            if (component1 == null) return;

            // ========================================================
            var form1 = component1 as Form;
            var button1 = component1 as Button;
            var buttonTool1 = component1 as ToolStripButton;
            var toolStripMenuItem1 = component1 as ToolStripMenuItem;
            // Form
            if (form1 != null)
            {
                form1.Icon = icon;
            }
            // Buttons
            else if (button1 != null)
            {
                button1.Image = image2;
                button1.ImageAlign = ContentAlignment.TopLeft;
                button1.TextAlign = ContentAlignment.BottomCenter;
            }
            // ButtonTool
            else if (buttonTool1 != null)
            {
                buttonTool1.Image = image2;
                buttonTool1.ImageAlign = ContentAlignment.TopLeft;
                buttonTool1.TextAlign = ContentAlignment.BottomCenter;
            }
                // ToolStripMenuItem
            else if (toolStripMenuItem1 != null)
            {
                toolStripMenuItem1.Image = image2;
                toolStripMenuItem1.ImageAlign = ContentAlignment.TopLeft;
                toolStripMenuItem1.TextAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                // Other controls
                var control1 = component1 as Control;
                if (control1 != null)
                {
                    control1.BackgroundImage = image2;
                    control1.BackgroundImageLayout = ImageLayout.None;
                }
            }
        }

        private Image Image_Scale(Image image, ComboBox comboBoxResize)
        {
            if (comboBoxResize.Text == "(Default)") return image;

            if (comboBoxResize.SelectedIndex == 1) return ScaleImage(image, 16, 16);
            if (comboBoxResize.SelectedIndex == 2) return ScaleImage(image, 32, 32);
            if (comboBoxResize.SelectedIndex == 3) return ScaleImage(image, 48, 48);
            if (comboBoxResize.SelectedIndex == 4) return ScaleImage(image, 64, 64);
            if (comboBoxResize.SelectedIndex == 5) return ScaleImage(image, 128, 128);
            if (comboBoxResize.SelectedIndex == 6) return ScaleImage(image, 256, 256);

            MessageBox.Show("Error! Scale setting not imlplemented in Image_Scale()");
            return _image;
        }

        public void Setup(Component designer)
        {
            _designer = designer;
            listBox_Components.Items.Clear();
            _host = UIDesigner_Service.IDesignerHost_FromComponent(designer);
            if (_host != null)
            {
                UIDesigner_Tools.Host_Controls_SelectionChange(_host, OnselectionChanged);  // Set the events

                _components = UIDesigner_Tools.Host_Components_All(_host);
                // Load the controls
                foreach (Component component in _components)
                {
                    string name = UIDesigner_Component.Component_AsStr(component, true, true);
                    if (name != "") listBox_Components.Items.Add(name);
                }

                this.TopMost = true;
                this.Show();
            }
        }

        private void OnselectionChanged(object sender, EventArgs e)
        {
            //Setup(_designer, true);
            Component component = UIDesigner_Tools.Host_Controls_SelectedFirst(_host);
            string name = UIDesigner_Component.Component_AsStr(component, true, true);
            if (name != "") listBox_Components.zListBox_SearchItem(name);
        }

        private void Form_ImageResources_FormClosed(object sender, FormClosedEventArgs e)
        {
            UIDesigner_Tools.Host_Controls_SelectionChange(_host, OnselectionChanged, true);  // Set the events
        }

        private void listBox_Components_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SelectionChanged) return;
            _SelectionChanged = true;
            try
            {
                //Component control1 = Control_Selected();
                Component control1 = UIDesigner_Component.ControlNames(_components,listBox_Components.Text);
                if (control1 != null)
                {
                    UIDesigner_Tools.Host_Controls_SelectedSet1(_host, control1);
                    //control1.ToString().zOk();
                }
            }
            finally
            {
                _SelectionChanged = false;
            }
        }

        //private Component Control_Selected()
        //{
        //    string controlName = listBox_Components.Text;
        //    Component control1 = null;
        //    foreach (Component component in _components)
        //    {
        //        string name = UIDesigner_Component.Component_AsStr(component, true, true);
        //        if (name == "") continue;

        //        if (name == controlName)
        //        {
        //            control1 = component;
        //            break;
        //        }
        //    }
        //    return control1;
        //}

        /// <summary>Scales an image to a specific with and height.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>The scaled image to the specific width and height.</returns>
        public Image ScaleImage(Image @this, int width, int height)
        {
            var r = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(@this, 0, 0, width, height);
            }

            return r;
        }

        /// <summary>Convert a bitmap to an icon</summary>
        public Icon Bmp_ToIcon(Bitmap bmp)
        {
            IntPtr handle = bmp.GetHicon();
            return Icon.FromHandle(handle);
        }

    }
}
