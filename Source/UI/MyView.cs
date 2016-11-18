
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NSQRScan {
    public class MyView : Control {
        public MyView() {
            InitializeComponent();
        }

        void InitializeComponent() {
            this.AllowDrop = true;
        }

        Image _img;

        [RefreshProperties(RefreshProperties.All)]
        public Image image {
            get {
                return _img;
            }
            set {
                _img = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            Rectangle r;

            if (DesignMode) {
                r = new Rectangle(Point.Empty, new Size(Bounds.Size.Width - 1, Bounds.Size.Height - 1));
                e.Graphics.DrawRectangle(Pens.Red, r);
            }
            if (image != null) {
                e.Graphics.DrawImage(_img, Point.Empty);
            }
            base.OnPaint(e);
        }
    }
}