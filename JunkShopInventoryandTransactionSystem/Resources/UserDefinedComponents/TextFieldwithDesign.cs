using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JUNKSHOP.Resources.UserDefinedComponents
{
    [ToolboxItem(true)]
    internal class TextFieldwithDesign : Panel
    {
        private TextBox textBox;
        private Color borderColor = Color.Black;
        private int borderSize = 2;
        private int cornerRadius = 10;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Set the border color.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Set the border thickness.")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = Math.Max(1, value);
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Set the roundness of corners (0 = square, higher = rounder).")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = Math.Max(0, value);
                Invalidate();
            }
        }

        public TextFieldwithDesign()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Parent = this
            };

            // Try to set transparent background, fallback to white if not supported
            try
            {
                textBox.BackColor = Color.Transparent;
            }
            catch
            {
                textBox.BackColor = Color.White;
            }

            Controls.Add(textBox);
            Resize += TextFieldwithDesign_Resize;
            Paint += TextFieldwithDesign_Paint;
        }

        private void TextFieldwithDesign_Resize(object? sender, EventArgs e)
        {
            AdjustFontSize();
            AdjustTextBox();
            Invalidate();
        }

        private void AdjustFontSize()
        {
            float newSize = Height * 0.5f;
            textBox.Font = new Font(textBox.Font.FontFamily, newSize);
        }

        private void AdjustTextBox()
        {
            // Add some padding for better appearance
            int padding = borderSize + 2;
            textBox.Location = new Point(padding, padding);
            textBox.Width = Width - padding * 2;
            textBox.Height = Height - padding * 2;
        }

        private void TextFieldwithDesign_Paint(object? sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(borderColor, borderSize))
            using (GraphicsPath path = new GraphicsPath())
            {
                // Adjust the drawing area to account for pen width
                Rectangle rect = new Rectangle(borderSize / 2, borderSize / 2,
                    Width - borderSize, Height - borderSize);

                if (cornerRadius > 0)
                {
                    path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
                    path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
                    path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                    path.CloseFigure();
                }
                else
                {
                    path.AddRectangle(rect);
                }

                Region = new Region(path);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}