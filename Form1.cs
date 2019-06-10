using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro3D;
using Cognex.VisionPro.ImageProcessing;

using Cognex.VisionPro.ImageFile;



namespace visionproScriptStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open iamge and show 
            CogImageFile cif = new Cognex.VisionPro.ImageFile.CogImageFile();
            string nameOfImageFile = "C:\\20181103145139_H-90CG-MPA08-0200-A5-2354_CF-7#_L/145236313_ReCheck_Left_001_20181103145139_H-90CG-MPA08-0200-A5-2354_CF-7#_L_Accept.jpg";
            cif.Open(nameOfImageFile, CogImageFileModeConstants.Read);

            if (false)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CogImageFile imagefile = new CogImageFile();
                    imagefile.Open(dlg.FileName, CogImageFileModeConstants.Read);
                }
            }
            cogRecordDisplay1.Image = cif[0];// imagefile[0];
            cogRecordDisplay1.Fit();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
