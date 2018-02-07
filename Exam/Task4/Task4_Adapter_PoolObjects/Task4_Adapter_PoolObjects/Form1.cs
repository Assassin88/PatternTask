using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using Task4_Adapter_PoolObjects.Adapter;

namespace Task4_Adapter_PoolObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IList<Bitmap> _listBitmap = new List<Bitmap>();
        private Mediator _mediator;
        public IList<Bitmap> ListBitmap { get => _listBitmap; set => _listBitmap = value; }

        private void Init(Bitmap bitmap)
        {
            _mediator = new Mediator(bitmap);
            ListBitmap.Add(_mediator.GetPicture(PictureAdapter.Original));
            ListBitmap.Add(_mediator.GetPicture(PictureAdapter.Negative));
            ListBitmap.Add(_mediator.GetPicture(PictureAdapter.TurnLeft));
            ListBitmap.Add(_mediator.GetPicture(PictureAdapter.TurnRight));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbName.Text = opd.FileName;
                    var image = new Bitmap(opd.FileName);
                    Init(image);
                    MainPB.Image = image;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Can't open the selected file",
                    "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NegativePB.Image == null)
                return;

            var sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (NegativePB.Image != null)
                {
                    NegativePB.Image.Save(sfd.FileName);
                }
            }
        }

        private void SaveOriginal_Click(object sender, EventArgs e)
        {
            if (MainPB.Image == null)
                return;

            var sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (MainPB.Image != null)
                {
                    MainPB.Image.Save(sfd.FileName);
                }
            }
        }

        private void trackBarMain_Scroll(object sender, EventArgs e)
        {
            if (MainPB.Image == null)
            {
                return;
            }

            var rotate = new RotateBilinear(trackBarMain.Value, true);
            var bmp = (Bitmap)MainPB.Image;
            var bitmap = rotate.Apply(bmp);
            NegativePB.Image = bitmap;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (MainPB.Image == null)
            {
                return;
            }
            NegativePB.Image = ListBitmap[1];
        }

        private void btnTurnLeft_Click(object sender, EventArgs e)
        {
            if (MainPB.Image == null)
            {
                return;
            }
            NegativePB.Image = ListBitmap[2];
        }

        private void btnTurnRight_Click(object sender, EventArgs e)
        {
            if (MainPB.Image == null)
            {
                return;
            }
            NegativePB.Image = ListBitmap[3];
        }
    }
}
