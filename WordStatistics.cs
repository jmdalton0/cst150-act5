using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Act5
{
    // WinForm for gathering statistics about a list of words
    public partial class WordStatistics : Form
    {

        private string filename;
        private List<string> words;

        public WordStatistics()
        {
            InitializeComponent();
            words = new List<string>();
            processButton.Enabled = false;
            processButton.BackColor = Color.WhiteSmoke;
            statusLabel.Visible = false;
        }
        
        // close form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // choose a file to read words from
        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            statusLabel.Visible = false;

            openFileDialog.InitialDirectory = "C:\\Users\\jmdal\\Projects\\CST150\\Topic3\\Act5\\rsrc";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                openFileTextBox.Text = filename;
                // if the user chooses a word, enable the process button
                processButton.Enabled = true;
                processButton.BackColor = Color.Teal;
            }
            else
            {
                openFileTextBox.Text = "no file selected";
                // if the user does not choose a word, disable the process button
                processButton.Enabled = false;
                processButton.BackColor = Color.WhiteSmoke;
            }
        }

        // read words from file and clean data
        private void processButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Processing...";
            statusLabel.Visible = true;
            words.Clear();

            try
            {
                // read each char individually and build next word
                StreamReader inFile = File.OpenText(filename);
                StringBuilder nextWord = new StringBuilder();
                while(!inFile.EndOfStream)
                {
                    char nextChar = Convert.ToChar(inFile.Read());
                    if (Char.IsLetter(nextChar))
                    {
                        // if the char is valid, add it to the next word
                        nextWord.Append(nextChar.ToString().ToLower());
                    }
                    else if (nextWord.Length > 0)
                    {
                        // if the char is invalid, we have reached the end of the next word
                        words.Add(nextWord.ToString());
                        nextWord.Clear();
                    }
                    // else skip char
                }
                words.Add(nextWord.ToString());
                inFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            processWords();
            writeStatistics();

            statusLabel.Text = "Finished.";
        }

        // count the number of vowels in a string
        private int numVowels(string word)
        {
            int numVowels = 0;
            foreach (char letter in word)
            {
                if (letter == 'a' ||
                        letter == 'e' ||
                        letter == 'i' ||
                        letter == 'o' ||
                        letter == 'u' ||
                        letter == 'y'
                )
                {
                    numVowels++;
                }
            }
            return numVowels;
        }

        // gather statistics about words
        private void processWords()
        {
            // sort alphabetically and update first and last
            words.Sort();
            firstAlphaTextBox.Text = words.First();
            lastAlphaTextBox.Text = words.Last();

            // track running best for longest word and word with most vowels
            string longestWord = words.First();
            string mostVowelsWord = words.First();
            foreach(string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
                
                if (numVowels(word) > numVowels(mostVowelsWord))
                {
                    mostVowelsWord = word;
                }
            }

            // update longest word and word with most vowels
            longestTextBox.Text = longestWord;
            mostVowelsTextBox.Text = mostVowelsWord;
        }

        // save statisics to a file
        private void writeStatistics()
        {
            try
            {
                StreamWriter outFile = File.CreateText("C:\\Users\\jmdal\\Projects\\CST150\\Topic3\\Act5\\rsrc\\out.txt");
                foreach (string word in words)
                {
                    outFile.WriteLine(word);
                }
                outFile.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
