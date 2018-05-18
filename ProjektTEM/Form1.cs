using System;
using System.Windows.Forms;

namespace ProjektTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            morphologyTypeDropdownList.Items.AddRange(Enum.GetNames(typeof(Morphology)));
            morphologyTypeDropdownList.SelectedItem = morphologyTypeDropdownList.Items[0];
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG; | All files(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBefore.ImageLocation = fileDialog.FileName;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            pictureBoxFiltered.ImageLocation = ImageFiltering.Filter(pictureBoxAfterThreshold.ImageLocation, (Morphology)Enum.Parse(typeof(Morphology), morphologyTypeDropdownList.SelectedItem.ToString()));
        }

        private void ThresholdButton_Click(object sender, EventArgs e)
        {
            pictureBoxAfterThreshold.ImageLocation = ImageFiltering.Threshold(pictureBoxBefore.ImageLocation, (float)thresholdFactor.Value);
        }
    }
}
