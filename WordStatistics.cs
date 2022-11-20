using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Act5
{
    public partial class WordStatistics : Form
    {

        private String filename;
        private List<string> words;

        public WordStatistics()
        {
            InitializeComponent();
            words = new List<string>();
            processButton.Enabled = false;
            processButton.BackColor = Color.WhiteSmoke;
            statusLabel.Visible = false;
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            statusLabel.Visible = false;

            openFileDialog.InitialDirectory = "C:\\Users\\jmdal\\Projects\\CST150\\Topic3\\Act5\\rsrc";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                openFileTextBox.Text = filename;
                processButton.Enabled = true;
                processButton.BackColor = Color.Teal;
            }
            else
            {
                openFileTextBox.Text = "no file selected";
                processButton.Enabled = false;
                processButton.BackColor = Color.WhiteSmoke;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Processing...";
            statusLabel.Visible = true;

            try
            {
                StreamReader inFile = File.OpenText(filename);
                while(!inFile.EndOfStream)
                {
                    words.Add(inFile.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            statusLabel.Text = "Finished.";

            processWords();
        }

        private void processWords()
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words.ElementAt(i));
            }
        }
    }
}
