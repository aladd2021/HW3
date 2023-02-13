
namespace HelloEmgu
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
            this.emguPictureBox = new System.Windows.Forms.PictureBox();
            this.binaryPictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdTrackbar = new System.Windows.Forms.TrackBar();
            this.whitePixelsLFLbl = new System.Windows.Forms.Label();
            this.whitePixelsLLbl = new System.Windows.Forms.Label();
            this.whitePixelsMLbl = new System.Windows.Forms.Label();
            this.whitePixelsRLbl = new System.Windows.Forms.Label();
            this.whitePixelsRFLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // emguPictureBox
            // 
            this.emguPictureBox.Location = new System.Drawing.Point(37, 47);
            this.emguPictureBox.Name = "emguPictureBox";
            this.emguPictureBox.Size = new System.Drawing.Size(342, 267);
            this.emguPictureBox.TabIndex = 0;
            this.emguPictureBox.TabStop = false;
            // 
            // binaryPictureBox
            // 
            this.binaryPictureBox.Location = new System.Drawing.Point(414, 47);
            this.binaryPictureBox.Name = "binaryPictureBox";
            this.binaryPictureBox.Size = new System.Drawing.Size(342, 267);
            this.binaryPictureBox.TabIndex = 1;
            this.binaryPictureBox.TabStop = false;
            // 
            // thresholdTrackbar
            // 
            this.thresholdTrackbar.Location = new System.Drawing.Point(37, 349);
            this.thresholdTrackbar.Maximum = 255;
            this.thresholdTrackbar.Minimum = 1;
            this.thresholdTrackbar.Name = "thresholdTrackbar";
            this.thresholdTrackbar.Size = new System.Drawing.Size(719, 69);
            this.thresholdTrackbar.TabIndex = 2;
            this.thresholdTrackbar.Value = 1;
            this.thresholdTrackbar.ValueChanged += new System.EventHandler(this.thresholdTrackbar_ValueChanged);
            // 
            // whitePixelsLFLbl
            // 
            this.whitePixelsLFLbl.AutoSize = true;
            this.whitePixelsLFLbl.Location = new System.Drawing.Point(12, 9);
            this.whitePixelsLFLbl.Name = "whitePixelsLFLbl";
            this.whitePixelsLFLbl.Size = new System.Drawing.Size(94, 20);
            this.whitePixelsLFLbl.TabIndex = 3;
            this.whitePixelsLFLbl.Text = "White Pixels";
            // 
            // whitePixelsLLbl
            // 
            this.whitePixelsLLbl.AutoSize = true;
            this.whitePixelsLLbl.Location = new System.Drawing.Point(190, 9);
            this.whitePixelsLLbl.Name = "whitePixelsLLbl";
            this.whitePixelsLLbl.Size = new System.Drawing.Size(94, 20);
            this.whitePixelsLLbl.TabIndex = 4;
            this.whitePixelsLLbl.Text = "White Pixels";
            // 
            // whitePixelsMLbl
            // 
            this.whitePixelsMLbl.AutoSize = true;
            this.whitePixelsMLbl.Location = new System.Drawing.Point(349, 9);
            this.whitePixelsMLbl.Name = "whitePixelsMLbl";
            this.whitePixelsMLbl.Size = new System.Drawing.Size(94, 20);
            this.whitePixelsMLbl.TabIndex = 5;
            this.whitePixelsMLbl.Text = "White Pixels";
            // 
            // whitePixelsRLbl
            // 
            this.whitePixelsRLbl.AutoSize = true;
            this.whitePixelsRLbl.Location = new System.Drawing.Point(522, 9);
            this.whitePixelsRLbl.Name = "whitePixelsRLbl";
            this.whitePixelsRLbl.Size = new System.Drawing.Size(94, 20);
            this.whitePixelsRLbl.TabIndex = 6;
            this.whitePixelsRLbl.Text = "White Pixels";
            // 
            // whitePixelsRFLbl
            // 
            this.whitePixelsRFLbl.AutoSize = true;
            this.whitePixelsRFLbl.Location = new System.Drawing.Point(683, 9);
            this.whitePixelsRFLbl.Name = "whitePixelsRFLbl";
            this.whitePixelsRFLbl.Size = new System.Drawing.Size(94, 20);
            this.whitePixelsRFLbl.TabIndex = 7;
            this.whitePixelsRFLbl.Text = "White Pixels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.whitePixelsRFLbl);
            this.Controls.Add(this.whitePixelsRLbl);
            this.Controls.Add(this.whitePixelsMLbl);
            this.Controls.Add(this.whitePixelsLLbl);
            this.Controls.Add(this.whitePixelsLFLbl);
            this.Controls.Add(this.thresholdTrackbar);
            this.Controls.Add(this.binaryPictureBox);
            this.Controls.Add(this.emguPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emguPictureBox;
        private System.Windows.Forms.PictureBox binaryPictureBox;
        private System.Windows.Forms.TrackBar thresholdTrackbar;
        private System.Windows.Forms.Label whitePixelsLFLbl;
        private System.Windows.Forms.Label whitePixelsLLbl;
        private System.Windows.Forms.Label whitePixelsMLbl;
        private System.Windows.Forms.Label whitePixelsRLbl;
        private System.Windows.Forms.Label whitePixelsRFLbl;
    }
}

