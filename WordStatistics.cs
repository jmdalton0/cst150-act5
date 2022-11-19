using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act5
{
    public partial class WordStatistics : Form
    {

        private String filename;

        public WordStatistics()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\Users\\jmdal\\Projects\\CST150\\Topic3\\Act5\\rsrc";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                openFileTextBox.Text = filename;
            }
            else
            {
                openFileTextBox.Text = "no file selected";
            }
        }
    }
}
