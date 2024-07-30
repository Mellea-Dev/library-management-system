using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace library_management_system.CustomComponents
{
    public class GradientPanel : Panel
    {
        private Color color1 = Color.Transparent;
        private Color color2 = Color.FromArgb(239, 237, 225);
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        public Color Color2
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
