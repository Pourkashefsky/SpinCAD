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
    public partial class Simulator : DevExpress.XtraEditors.XtraUserControl
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void Parameter1_EditValueChanged(object sender, EventArgs e)
        {
            labelControl1.Text = "P.1" + Environment.NewLine + (((double)Parameter1.Value * 100.0d) / (double)Parameter1.Properties.Maximum).ToString("F1") + "%" + Environment.NewLine + "(" + Parameter1.Value.ToString() + ")";
            //Fires to sim core
        }
        private void Parameter2_EditValueChanged(object sender, EventArgs e)
        {
            labelControl2.Text = "P.2" + Environment.NewLine + (((double)Parameter2.Value * 100.0d) / (double)Parameter2.Properties.Maximum).ToString("F1") + "%" + Environment.NewLine + "(" + Parameter2.Value.ToString() + ")";
            //Fires to sim core
        }
        private void Parameter3_EditValueChanged(object sender, EventArgs e)
        {
            labelControl3.Text = "P.3" + Environment.NewLine + (((double)Parameter3.Value * 100.0d) / (double)Parameter3.Properties.Maximum).ToString("F1") + "%" + Environment.NewLine + "(" + Parameter3.Value.ToString() + ")";
            //Fires to sim core
        }
        private void Selector_EditValueChanged(object sender, EventArgs e)
        {
            groupControl1.Text = "Patch selector (" + Selector.Value.ToString() + ")";
            //Fires to sim core
        }
    }
}
