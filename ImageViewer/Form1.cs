using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageViewer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1) openFile(args[1]);
        }

        //Global vars
        private Point startingPoint = Point.Empty;
        private Point movingPoint = Point.Empty;
        private bool panning = false;
        int imageIndex = 0;
        string[] files = null;
        Timer t;
        bool slideOn = false;
        int slideTime = 1000;
        Image currImage = null;
        int zoomFactor = 0;

        #region Functions
        private void setImage() {
            //Reset origin
            panning = false;
            zoomFactor = 0;
            startingPoint = new Point(0,0);
            movingPoint = new Point(0, 0);

            //Trigger repaint
            imageMain.SizeMode = PictureBoxSizeMode.Zoom;
            imageMain.Invalidate();
        }

        private void prevImage() {
            imageIndex = imageIndex <= 0 ? files.Length - 1 : imageIndex - 1;
            setImage();
        }

        private void nextImage() {
            imageIndex = imageIndex >= files.Length - 1 ? 0 : imageIndex + 1;
            setImage();
        }

        void timer_Tick(object sender, EventArgs e) {
            nextImage();
        }

        private void slideShowStart() {
            t = new Timer();
            t.Interval = slideTime; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void slideShowStop() {
            t.Stop();
            t.Dispose();
        }

        private void openFile(string file = null) {
            //If image isnt open via cmd line, use OFD to set 'file' var
            if (file == null) {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Bitmap|*.bmp|" +
                            "JPEG|*.jpg;*.jpeg|" +
                            "PNG|*.png|" +
                            "Targa|*.tga" +
                            "|All Formats|*.bmp;*.jpg;*.jpeg;*.png;*.tga";
                fd.FilterIndex = 5;
                if (fd.ShowDialog() == DialogResult.OK) {
                    file = fd.FileName;
                }
            }

            //Get all files in dir
            string path = Path.GetDirectoryName(file);
            files = Directory.GetFiles(path, "*.*").Where(s => s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".tga")).ToArray();

            //Initialize controls
            nextButton.Enabled = true;
            prevButton.Enabled = true;
            slideShowButton.Enabled = true;
            imageMain.Invalidate();

            //Find index of selected image
            for (int i = 0; i < files.Length - 1; i++) {
                if (files[i].Equals(file, StringComparison.Ordinal)) {
                    imageIndex = i;
                    return;
                }
            }

            //Set image
            setImage();
        }
        #endregion

        #region Listeners
        private void slideShowButton_Click(object sender, EventArgs e) {
            slideShowStart();
        }

        private void prevButton_Click(object sender, EventArgs e) {
            prevImage();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            nextImage();
        }

        private void openButton_Click(object sender, EventArgs e) {
            openFile();
        }

        private void imageMain_MouseMove(object sender, MouseEventArgs e) {
            if (panning) {
                movingPoint = new Point(e.Location.X - startingPoint.X, e.Location.Y - startingPoint.Y);
                imageMain.Invalidate();
            }
        }

        private void imageMain_MouseDown(object sender, MouseEventArgs e) {
            panning = true;
            startingPoint = new Point(e.Location.X - movingPoint.X, e.Location.Y - movingPoint.Y);
        }

        private void imageMain_MouseUp(object sender, MouseEventArgs e) {
            panning = false;
        }

        private void imageMain_MouseWheel(object sender, MouseEventArgs e) {
            //currImage = Image.FromFile(files[imageIndex]);
            //Size newSize = new Size((int)(currImage.Width * zoomFactor), (int)(currImage.Height * zoomFactor));
            //imageMain.Image = new Bitmap(currImage, newSize);
        }

        private void imageMain_MouseEnter(object sender, EventArgs e) {
            imageMain.Focus();
        }

        private void imageMain_Paint(object sender, PaintEventArgs e) {
            if (files != null) {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(Image.FromFile(files[imageIndex]), movingPoint);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (files != null) {
                switch (e.KeyCode) {
                    case Keys.Left:
                        prevImage();
                        break;
                    case Keys.Right:
                        nextImage();
                        break;
                    case Keys.F11:
                        slideShowStart();
                        break;
                    case Keys.O:
                        openFile();
                        break;
                    case Keys.Escape:
                        slideShowStop();
                        break;
                }
            }
        }
        #endregion
    }
}
