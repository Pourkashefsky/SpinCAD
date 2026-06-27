using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinCAD.Controls
{
    public partial class PatchEditor : DevExpress.XtraEditors.XtraUserControl
    {
        public PatchEditor()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            dropDownButton1.ShowDropDown();
        }
    }
}
