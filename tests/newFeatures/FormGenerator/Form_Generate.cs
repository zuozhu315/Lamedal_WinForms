using System;
using System.Windows.Forms;

namespace Lamedal_UIWinForms.Test.newFeatures.FormGenerator
{
    public partial class Form_Generate : Form
    {
        public Form_Generate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormCreator_SelectClasses_Form(this);
            frm.ShowDialog();
        }
    }
}
