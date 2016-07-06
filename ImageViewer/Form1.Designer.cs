namespace ImageViewer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openButton = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.PictureBox();
            this.prevButton = new System.Windows.Forms.PictureBox();
            this.slideShowButton = new System.Windows.Forms.PictureBox();
            this.imageMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideShowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMain)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.Image = global::ImageViewer.Properties.Resources.openImg;
            this.openButton.Location = new System.Drawing.Point(12, 405);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(30, 30);
            this.openButton.TabIndex = 4;
            this.openButton.TabStop = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Enabled = false;
            this.nextButton.Image = global::ImageViewer.Properties.Resources.rightImg;
            this.nextButton.Location = new System.Drawing.Point(306, 405);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 30);
            this.nextButton.TabIndex = 3;
            this.nextButton.TabStop = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.Enabled = false;
            this.prevButton.Image = global::ImageViewer.Properties.Resources.leftImg;
            this.prevButton.Location = new System.Drawing.Point(174, 405);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(60, 30);
            this.prevButton.TabIndex = 2;
            this.prevButton.TabStop = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // slideShowButton
            // 
            this.slideShowButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slideShowButton.Enabled = false;
            this.slideShowButton.Image = global::ImageViewer.Properties.Resources.slideshowImg;
            this.slideShowButton.Location = new System.Drawing.Point(240, 375);
            this.slideShowButton.Name = "slideShowButton";
            this.slideShowButton.Size = new System.Drawing.Size(60, 60);
            this.slideShowButton.TabIndex = 1;
            this.slideShowButton.TabStop = false;
            this.slideShowButton.Click += new System.EventHandler(this.slideShowButton_Click);
            // 
            // imageMain
            // 
            this.imageMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageMain.BackColor = System.Drawing.Color.Transparent;
            this.imageMain.Location = new System.Drawing.Point(0, 0);
            this.imageMain.Margin = new System.Windows.Forms.Padding(0);
            this.imageMain.Name = "imageMain";
            this.imageMain.Size = new System.Drawing.Size(540, 400);
            this.imageMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMain.TabIndex = 0;
            this.imageMain.TabStop = false;
            this.imageMain.Paint += new System.Windows.Forms.PaintEventHandler(this.imageMain_Paint);
            this.imageMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageMain_MouseDown);
            this.imageMain.MouseEnter += new System.EventHandler(this.imageMain_MouseEnter);
            this.imageMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageMain_MouseMove);
            this.imageMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageMain_MouseUp);
            this.imageMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.imageMain_MouseWheel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(540, 447);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.slideShowButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.imageMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.openButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideShowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageMain;
        private System.Windows.Forms.PictureBox slideShowButton;
        private System.Windows.Forms.PictureBox prevButton;
        private System.Windows.Forms.PictureBox nextButton;
        private System.Windows.Forms.PictureBox openButton;
    }
}

