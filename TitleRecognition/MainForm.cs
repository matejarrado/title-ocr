using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleRecognition
{
    public partial class MainForm : Form
    {
        public Mat inputMat = null;
        public List<List<KeyValuePair<RotatedRect, String>>> result = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = "Image Files(*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png||";
            if (ofn.ShowDialog() == DialogResult.OK)
            {
                inputMat = CvInvoke.Imread(ofn.FileName, ImreadModes.Color);
                imgImage.Image = inputMat;
            }
        }

        private void mnuEditDetect_Click(object sender, EventArgs e)
        {

        }

        private void mnuEditExport_Click(object sender, EventArgs e)
        {

        }
    }
}
