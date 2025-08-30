using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EstiponaClinic
{
    public class RoundButton : Button
    {
        private Image buttonImage;

        public Image ButtonImage
        {
            get => buttonImage;
            set { buttonImage = value; Invalidate(); }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(gp);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Background + border
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.FillEllipse(brush, this.ClientRectangle);

                if (this.FlatAppearance.BorderSize > 0)
                {
                    using (Pen pen = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
                    {
                        pevent.Graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            // Image (optional)
            if (buttonImage != null)
            {
                int imgSize = Math.Min(ClientSize.Width - 8, ClientSize.Height - 8);
                Rectangle rect = new Rectangle(
                    (ClientSize.Width - imgSize) / 2,
                    (ClientSize.Height - imgSize) / 2,
                    imgSize,
                    imgSize
                );
                pevent.Graphics.DrawImage(buttonImage, rect);
            }

            // Draw centered text
            using (StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                pevent.Graphics.DrawString(
                    this.Text,
                    this.Font,
                    new SolidBrush(this.ForeColor),
                    this.ClientRectangle,
                    sf
                );
            }
        }
    }
}
