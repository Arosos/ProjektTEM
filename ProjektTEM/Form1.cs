using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektTEM
{
    public partial class Form1 : Form
    {
        string originalImageFilename, imageFilenameAfterThresholding;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImageFilename = fileDialog.FileName;
                pictureBoxBefore.ImageLocation = fileDialog.FileName;
            }
        }

        private void ThresholdButton_Click(object sender, EventArgs e)
        {
            imageFilenameAfterThresholding = ImageFiltering.Threshold(originalImageFilename);
            pictureBoxAfterThreshold.ImageLocation = imageFilenameAfterThresholding;
        }
    }
}
