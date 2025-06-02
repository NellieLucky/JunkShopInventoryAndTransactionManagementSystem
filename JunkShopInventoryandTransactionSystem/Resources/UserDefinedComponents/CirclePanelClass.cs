using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JUNKSHOP.Resources.UserDefinedComponents
{
    [ToolboxItem(true)]
    internal class CirclePanelClass : Panel
    {
        private Image? image;
        private Size originalImageSize;
        private Color backgroundColor = Color.LightGray;
        private float imageScaleFactor = 1.0f;  // Default scaling at 100%

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Set the image for the circular panel.")]
        public Image? BackgroundImageCustom
        {
            get { return image; }
            set
            {
                image = value;
                if (image != null) originalImageSize = image.Size;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Set the background color if no image is provided.")]
        public Color BackgroundColorCustom
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Scale factor for the image (0.5 = 50%, 1.0 = 100%, 2.0 = 200%).")]
        public float ImageScaleFactor
        {
            get { return imageScaleFactor; }
            set
            {
                imageScaleFactor = Math.Max(0.1f, value); // Prevent scale going below 10%
                Invalidate(); // Force redraw when scale changes
            }
        }

        public CirclePanelClass()
        {
            BackColor = Color.Transparent;
            DoubleBuffered = true;
            Resize += (s, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, Width, Height);
                Region = new Region(path);
            }

            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillEllipse(brush, 0, 0, Width, Height);
            }

            if (image != null)
            {
                // Scale the image properly inside the circular panel
                float scale = imageScaleFactor;

                int newWidth = (int)(originalImageSize.Width * scale);
                int newHeight = (int)(originalImageSize.Height * scale);

                // Ensure image doesn't go out of bounds
                newWidth = Math.Min(newWidth, Width);
                newHeight = Math.Min(newHeight, Height);

                // **Force image to be centered**
                int x = (Width - newWidth) / 2;
                int y = (Height - newHeight) / 2;

                Rectangle imgRect = new Rectangle(x, y, newWidth, newHeight);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawImage(image, imgRect);
            }
        }
    }
}
