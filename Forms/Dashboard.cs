using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinCAD
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void XtraTabControls_CustomDrawTabHeader(object sender, TabHeaderCustomDrawEventArgs e)//Selected Tabs Always Lined
        {
            XtraTabControl tabCtl = (XtraTabControl)sender;
            if (e.TabHeaderInfo is null || e.TabHeaderInfo.Page is null) return; // Guard: sometimes TabHeaderInfo or Page may be Nothing during layout
            if (object.ReferenceEquals(e.TabHeaderInfo.Page, tabCtl.SelectedTabPage)) // Only decorate the selected tab
            {
                e.DefaultDraw(); // Preserve default drawing (text, image, background)
                using (var pen = new Pen(Color.FromArgb(0, 103, 192), 1)) // Adjust color/width to taste/Dx WXI
                {
                    int y = e.Bounds.Top + 0;
                    e.Graphics.DrawLine(pen, e.Bounds.Left + 9, y, e.Bounds.Right - 9, y); // Upper
                }
                using (var pen = new Pen(Color.FromArgb(0, 103, 192), 1)) // Adjust color/width to taste/Dx WXI
                {
                    int y = e.Bounds.Top + 1;
                    e.Graphics.DrawLine(pen, e.Bounds.Left + 7, y, e.Bounds.Right - 7, y); // Lower
                }
                e.Handled = true; // Prevent further default overdraw
            }
            //var tabCtl = sender as XtraTabControl;
            //if (tabCtl == null) return;
            //if (e.TabHeaderInfo == null || e.TabHeaderInfo.Page == null) return;
            //// فقط تب انتخاب‌شده را تزیین کن
            //if (!ReferenceEquals(e.TabHeaderInfo.Page, tabCtl.SelectedTabPage)) return;
            //// 1) اول رندر پیش‌فرض DevExpress اجرا شود
            //// (رسم متن، تصویر، پس‌زمینه و هر چیزی که اسکین لازم دارد)
            //e.DefaultDraw();
            //// 2) خط‌های دلخواه را روی همان Graphics رسم کن
            //// توجه: در DirectXForm مهم است که روی Graphics داده‌شده از DevExpress کار کنیم
            //using (var pen1 = new Pen(Color.FromArgb(0, 103, 192), 1))
            //using (var pen2 = new Pen(Color.FromArgb(0, 103, 192), 1))
            //{
            //    // اگر جهت (Orientation) تب‌ها بالا/پایین است، Y را از Bounds.Top می‌گیریم
            //    int y1 = e.Bounds.Top + 0; // خط اول
            //    int y2 = e.Bounds.Top + 1; // خط دوم

            //    // کمی از چپ و راست فاصله می‌گیریم تا با گوشه‌های تب هماهنگ شود
            //    e.Cache.Graphics.DrawLine(pen1, e.Bounds.Left + 9, y1, e.Bounds.Right - 9, y1);
            //    e.Cache.Graphics.DrawLine(pen2, e.Bounds.Left + 7, y2, e.Bounds.Right - 7, y2);
            //}
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void Dashboard_Shown(object sender, EventArgs e)
        {

        }
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
