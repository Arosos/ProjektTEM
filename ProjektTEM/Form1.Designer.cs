namespace ProjektTEM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.pictureBoxAfterThreshold = new System.Windows.Forms.PictureBox();
            this.pictureBoxFiltered = new System.Windows.Forms.PictureBox();
            this.thresholdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfterThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBefore.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBefore.TabIndex = 1;
            this.pictureBoxBefore.TabStop = false;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadImageButton.Location = new System.Drawing.Point(13, 651);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 23);
            this.loadImageButton.TabIndex = 2;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // pictureBoxAfterThreshold
            // 
            this.pictureBoxAfterThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAfterThreshold.Location = new System.Drawing.Point(379, 13);
            this.pictureBoxAfterThreshold.Name = "pictureBoxAfterThreshold";
            this.pictureBoxAfterThreshold.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxAfterThreshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAfterThreshold.TabIndex = 3;
            this.pictureBoxAfterThreshold.TabStop = false;
            // 
            // pictureBoxFiltered
            // 
            this.pictureBoxFiltered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFiltered.Location = new System.Drawing.Point(745, 13);
            this.pictureBoxFiltered.Name = "pictureBoxFiltered";
            this.pictureBoxFiltered.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFiltered.TabIndex = 4;
            this.pictureBoxFiltered.TabStop = false;
            // 
            // thresholdButton
            // 
            this.thresholdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thresholdButton.Location = new System.Drawing.Point(94, 651);
            this.thresholdButton.Name = "thresholdButton";
            this.thresholdButton.Size = new System.Drawing.Size(131, 23);
            this.thresholdButton.TabIndex = 5;
            this.thresholdButton.Text = "Generate binary image";
            this.thresholdButton.UseVisualStyleBackColor = true;
            this.thresholdButton.Click += new System.EventHandler(this.ThresholdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 686);
            this.Controls.Add(this.thresholdButton);
            this.Controls.Add(this.pictureBoxFiltered);
            this.Controls.Add(this.pictureBoxAfterThreshold);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.pictureBoxBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfterThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox pictureBoxAfterThreshold;
        private System.Windows.Forms.PictureBox pictureBoxFiltered;
        private System.Windows.Forms.Button thresholdButton;
    }
}

