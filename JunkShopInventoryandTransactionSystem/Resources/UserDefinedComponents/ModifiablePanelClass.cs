using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JUNKSHOP.Resources.UserDefinedComponents
{
    internal class Gradient_Panel : Panel
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("The color at the start of the gradient.")]
        public Color ColorTop { get; set; } = Color.White;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The color at the end of the gradient.")]
        public Color ColorBottom { get; set; } = Color.Black;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The angle of the gradient in degrees (0 = horizontal, 90 = vertical).")]
        public float GradientAngle { get; set; } = 0f;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The position (0-1) where the top color ends and the bottom color starts.")]
        public float ColorPosition { get; set; } = 0.7f;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The radius for rounded corners.")]
        public int CornerRadius { get; set; } = 20;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Enable rounded top-left corner.")]
        public bool RoundTopLeft { get; set; } = true;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Enable rounded top-right corner.")]
        public bool RoundTopRight { get; set; } = true;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Enable rounded bottom-right corner.")]
        public bool RoundBottomRight { get; set; } = true;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Enable rounded bottom-left corner.")]
        public bool RoundBottomLeft { get; set; } = true;

        protected override void OnPaint(PaintEventArgs e)
        {
            // Clamp radius to avoid overlap
            int safeRadius = Math.Max(0, Math.Min(CornerRadius, Math.Min(Width, Height) / 2));

            using (GraphicsPath path = GetRoundRectanglePath(ClientRectangle, safeRadius, RoundTopLeft, RoundTopRight, RoundBottomRight, RoundBottomLeft))
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, GradientAngle))
                {
                    ColorBlend cb = new ColorBlend();
                    cb.Colors = new Color[] { ColorTop, ColorTop, ColorBottom };
                    cb.Positions = new float[] { 0f, ColorPosition, 1f };

                    lgb.InterpolationColors = cb;
                    e.Graphics.SetClip(path);
                    e.Graphics.FillRectangle(lgb, ClientRectangle);
                    e.Graphics.ResetClip();
                }
            }
            base.OnPaint(e);
        }

        private static GraphicsPath GetRoundRectanglePath(Rectangle bounds, int radius, bool tl, bool tr, bool br, bool bl)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            // Top left
            if (tl && radius > 0)
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y);

            // Top edge
            if (tr && radius > 0)
                path.AddLine(bounds.X + radius, bounds.Y, bounds.Right - radius, bounds.Y);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.Right, bounds.Y);

            // Top right
            if (tr && radius > 0)
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y);

            // Right edge
            if (br && radius > 0)
                path.AddLine(bounds.Right, bounds.Y + radius, bounds.Right, bounds.Bottom - radius);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Bottom);

            // Bottom right
            if (br && radius > 0)
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom);

            // Bottom edge
            if (bl && radius > 0)
                path.AddLine(bounds.Right - radius, bounds.Bottom, bounds.X + radius, bounds.Bottom);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.X, bounds.Bottom);

            // Bottom left
            if (bl && radius > 0)
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom);

            // Left edge
            if (tl && radius > 0)
                path.AddLine(bounds.X, bounds.Bottom - radius, bounds.X, bounds.Y + radius);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Y);

            path.CloseFigure();
            return path;
        }
    }
}
