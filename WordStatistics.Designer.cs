namespace Act5
{
    partial class WordStatistics
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
            this.openFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.firstAlphaLabel = new System.Windows.Forms.Label();
            this.lastAlphaWord = new System.Windows.Forms.Label();
            this.firstAlphaTextBox = new System.Windows.Forms.TextBox();
            this.lastAlphaTextBox = new System.Windows.Forms.TextBox();
            this.longestLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.longestTextBox = new System.Windows.Forms.TextBox();
            this.mostVowelsTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openFileLabel.Location = new System.Drawing.Point(76, 66);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(165, 20);
            this.openFileLabel.TabIndex = 0;
            this.openFileLabel.Text = "Please choose a file:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.Teal;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(80, 116);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(142, 57);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.BackColor = System.Drawing.Color.White;
            this.openFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openFileTextBox.Enabled = false;
            this.openFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openFileTextBox.Location = new System.Drawing.Point(299, 66);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(665, 26);
            this.openFileTextBox.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusLabel.Location = new System.Drawing.Point(334, 278);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(105, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Processing...";
            this.statusLabel.Visible = false;
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.Teal;
            this.processButton.Enabled = false;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.ForeColor = System.Drawing.Color.White;
            this.processButton.Location = new System.Drawing.Point(80, 258);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(142, 57);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // firstAlphaLabel
            // 
            this.firstAlphaLabel.AutoSize = true;
            this.firstAlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstAlphaLabel.Location = new System.Drawing.Point(76, 358);
            this.firstAlphaLabel.Name = "firstAlphaLabel";
            this.firstAlphaLabel.Size = new System.Drawing.Size(184, 20);
            this.firstAlphaLabel.TabIndex = 5;
            this.firstAlphaLabel.Text = "First Alphabetical Word";
            // 
            // lastAlphaWord
            // 
            this.lastAlphaWord.AutoSize = true;
            this.lastAlphaWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastAlphaWord.Location = new System.Drawing.Point(76, 410);
            this.lastAlphaWord.Name = "lastAlphaWord";
            this.lastAlphaWord.Size = new System.Drawing.Size(183, 20);
            this.lastAlphaWord.TabIndex = 6;
            this.lastAlphaWord.Text = "Last Alphabetical Word";
            // 
            // firstAlphaTextBox
            // 
            this.firstAlphaTextBox.BackColor = System.Drawing.Color.White;
            this.firstAlphaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstAlphaTextBox.Enabled = false;
            this.firstAlphaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstAlphaTextBox.Location = new System.Drawing.Point(338, 356);
            this.firstAlphaTextBox.Name = "firstAlphaTextBox";
            this.firstAlphaTextBox.Size = new System.Drawing.Size(328, 26);
            this.firstAlphaTextBox.TabIndex = 7;
            // 
            // lastAlphaTextBox
            // 
            this.lastAlphaTextBox.BackColor = System.Drawing.Color.White;
            this.lastAlphaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastAlphaTextBox.Enabled = false;
            this.lastAlphaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastAlphaTextBox.Location = new System.Drawing.Point(338, 408);
            this.lastAlphaTextBox.Name = "lastAlphaTextBox";
            this.lastAlphaTextBox.Size = new System.Drawing.Size(328, 26);
            this.lastAlphaTextBox.TabIndex = 8;
            // 
            // longestLabel
            // 
            this.longestLabel.AutoSize = true;
            this.longestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.longestLabel.Location = new System.Drawing.Point(76, 461);
            this.longestLabel.Name = "longestLabel";
            this.longestLabel.Size = new System.Drawing.Size(114, 20);
            this.longestLabel.TabIndex = 9;
            this.longestLabel.Text = "Longest Word";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mostVowelsLabel.Location = new System.Drawing.Point(76, 510);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(213, 20);
            this.mostVowelsLabel.TabIndex = 10;
            this.mostVowelsLabel.Text = "Word with the Most Vowels";
            // 
            // longestTextBox
            // 
            this.longestTextBox.BackColor = System.Drawing.Color.White;
            this.longestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longestTextBox.Enabled = false;
            this.longestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.longestTextBox.Location = new System.Drawing.Point(338, 459);
            this.longestTextBox.Name = "longestTextBox";
            this.longestTextBox.Size = new System.Drawing.Size(328, 26);
            this.longestTextBox.TabIndex = 11;
            // 
            // mostVowelsTextBox
            // 
            this.mostVowelsTextBox.BackColor = System.Drawing.Color.White;
            this.mostVowelsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostVowelsTextBox.Enabled = false;
            this.mostVowelsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mostVowelsTextBox.Location = new System.Drawing.Point(338, 508);
            this.mostVowelsTextBox.Name = "mostVowelsTextBox";
            this.mostVowelsTextBox.Size = new System.Drawing.Size(328, 26);
            this.mostVowelsTextBox.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(845, 482);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 52);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // WordStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(232)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1085, 603);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mostVowelsTextBox);
            this.Controls.Add(this.longestTextBox);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestLabel);
            this.Controls.Add(this.lastAlphaTextBox);
            this.Controls.Add(this.firstAlphaTextBox);
            this.Controls.Add(this.lastAlphaWord);
            this.Controls.Add(this.firstAlphaLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.openFileTextBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.openFileLabel);
            this.Name = "WordStatistics";
            this.Text = "Word Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox openFileTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label firstAlphaLabel;
        private System.Windows.Forms.Label lastAlphaWord;
        private System.Windows.Forms.TextBox firstAlphaTextBox;
        private System.Windows.Forms.TextBox lastAlphaTextBox;
        private System.Windows.Forms.Label longestLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
        private System.Windows.Forms.TextBox longestTextBox;
        private System.Windows.Forms.TextBox mostVowelsTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}