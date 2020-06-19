using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIconExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Etier.IconHelper.IconReader.GetFileIcon(opf.FileName, Etier.IconHelper.IconReader.IconSize.Large, false).ToBitmap();
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sdf = new SaveFileDialog();
            sdf.Filter = "PNG-Dateien|*.png";
            if(sdf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sdf.FileName);
            }
        }
    }
}
