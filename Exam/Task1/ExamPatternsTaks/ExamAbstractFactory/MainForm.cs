using Services;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamAbstractFactory
{
    public partial class MainForm : Form
    {
        private readonly IAudioService _audioService = ServiceFactory.GetAudioService();
        private readonly IFileService _fileReaderService = ServiceFactory.GetFileService();
        private readonly IMessageBoxService _messageBoxService = ServiceFactory.GetMessageBoxService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            _messageBoxService.DescriptionException(() => _audioService.Play(tbEnterText.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _audioService.Stop();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbEnterText.Text = ofd.FileName;
            }
            var description = _audioService.GetInformarion(tbEnterText.Text);
            tbDescription.Text = description.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEnterText.Text))
            {
                return;
            }
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _fileReaderService.Save(tbEnterText.Text, sfd.FileName);
            }
        }

        
    }
}
