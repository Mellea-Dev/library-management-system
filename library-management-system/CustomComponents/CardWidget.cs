using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibraryManagementSystem.CustomComponents
{
    public class CardWidget : Panel
    {
        private int borderSize = 0;
        private int borderRadius = 10;
        private Color borderColor = Color.White;
        private int dropShadow = 0x00020000;

        private Label cardTitle;
        private PictureBox cardIcon;
        private Label countLabel;

        private int padding = 10;

        public string CardTitleText
        {
            get => cardTitle.Text;
            set
            {
                cardTitle.Text = value;
                AdjustSize();
            }
        }

        public Image CardIconImage
        {
            get => cardIcon.Image;
            set => cardIcon.Image = value;
        }

        public string CountLabelText
        {
            get => countLabel.Text;
            set => countLabel.Text = value;
        }

        public CardWidget()
        {
            this.BackColor = Color.White;
            InitializeComponents();
            AdjustSize();
        }

        private void InitializeComponents()
        {
            cardTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(91, 42, 9),
                Location = new Point(padding, padding + 27), // Adjusted for padding
                Name = "cardTitle",
                Size = new Size(99, 21),
                TabIndex = 2,
                Tag = "",
                Text = "Total Books"
            };

            cardIcon = new PictureBox
            {
                Image = (Image)(new Bitmap(52, 48)), // Placeholder image
                Location = new Point(122, padding), // Adjusted for padding
                Name = "cardIcon",
                Size = new Size(52, 48),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 1,
                TabStop = false
            };

            countLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(91, 42, 9),
                Location = new Point(padding, padding), // Adjusted for padding
                Name = "countLabel",
                Size = new Size(36, 27),
                TabIndex = 0,
                Text = "24"
            };

            this.Controls.Add(cardTitle);
            this.Controls.Add(cardIcon);
            this.Controls.Add(countLabel);
        }

        private void AdjustSize()
        {
            using (Graphics g = this.CreateGraphics())
            {
                SizeF titleSize = g.MeasureString(cardTitle.Text, cardTitle.Font);
                int newWidth = (int)(padding + titleSize.Width + 10 + cardIcon.Width + padding);
                int newHeight = padding + cardIcon.Height + padding;

                if (newWidth > this.Width || newHeight > this.Height)
                {
                    this.Size = new Size(newWidth, newHeight);
                }

                // Adjust cardIcon position based on the new width
                cardIcon.Location = new Point(this.Width - padding - cardIcon.Width, padding);
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                //button border
                if (borderSize >= 1)
                {
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dropShadow;
                return cp;
            }
        }
    }
}
