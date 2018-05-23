using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektTEM
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            morphologyTypeDropdownList.Items.AddRange(Enum.GetNames(typeof(Morphology)));
            morphologyTypeDropdownList.SelectedItem = morphologyTypeDropdownList.Items[0];
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG)| *.BMP; *.JPG; *.PNG; | All files(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBefore.ImageLocation = fileDialog.FileName;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (pictureBoxAfterThreshold.Image == null)
                MessageBox.Show("Generate binary image first.");
            else
                pictureBoxFiltered.Image = ImageFiltering.Filter((Bitmap)pictureBoxAfterThreshold.Image, (Morphology)Enum.Parse(typeof(Morphology), morphologyTypeDropdownList.SelectedItem.ToString()));
        }

        private void ThresholdButton_Click(object sender, EventArgs e)
        {
            if (pictureBoxBefore.Image == null)
                MessageBox.Show("Load image first.");
            else
                pictureBoxAfterThreshold.Image = ImageFiltering.Threshold(pictureBoxBefore.ImageLocation, (float)thresholdFactor.Value);
        }

        private void saveThresholdButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = ImageUtil.AddSuffix(pictureBoxBefore.ImageLocation, "Thresholded");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                pictureBoxAfterThreshold.Image.Save(saveFileDialog.FileName);
        }

        private void saveFilteredButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = ImageUtil.AddSuffix(pictureBoxBefore.ImageLocation, morphologyTypeDropdownList.SelectedItem.ToString());
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                pictureBoxFiltered.Image.Save(saveFileDialog.FileName);
        }
    }
}
