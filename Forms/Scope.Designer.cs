namespace SpinCAD.Forms
{
    partial class Scope
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barToggleSwitchItem2 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Location = new System.Drawing.Point(1, 29);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(620, 351);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barToggleSwitchItem1.BindableChecked = true;
            this.barToggleSwitchItem1.Caption = "Run";
            this.barToggleSwitchItem1.Checked = true;
            this.barToggleSwitchItem1.Id = 0;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barToggleSwitchItem2
            // 
            this.barToggleSwitchItem2.Caption = "Frequency based";
            this.barToggleSwitchItem2.Id = 1;
            this.barToggleSwitchItem2.Name = "barToggleSwitchItem2";
            // 
            // Scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(622, 381);
            this.Links.Add(this.barToggleSwitchItem1);
            this.Links.Add(this.barToggleSwitchItem2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scope";
            this.Text = "SuperScope";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem2;
    }
}