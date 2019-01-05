namespace AnimeDL_GUI
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
            this.animeList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animeInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animeList
            // 
            this.animeList.FormattingEnabled = true;
            this.animeList.ItemHeight = 16;
            this.animeList.Location = new System.Drawing.Point(52, 71);
            this.animeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.animeList.Name = "animeList";
            this.animeList.Size = new System.Drawing.Size(348, 116);
            this.animeList.TabIndex = 0;
            this.animeList.SelectedIndexChanged += new System.EventHandler(this.animeList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animeInput
            // 
            this.animeInput.Location = new System.Drawing.Point(52, 196);
            this.animeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.animeInput.Name = "animeInput";
            this.animeInput.Size = new System.Drawing.Size(132, 22);
            this.animeInput.TabIndex = 2;
            this.animeInput.TextChanged += new System.EventHandler(this.animeInput_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(301, 196);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 28);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // SaveList
            // 
            this.SaveList.Location = new System.Drawing.Point(52, 226);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(348, 23);
            this.SaveList.TabIndex = 4;
            this.SaveList.Text = "Save changes";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(517, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Option 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(517, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Option 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(52, 271);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(548, 49);
            this.download.TabIndex = 7;
            this.download.Text = "Download now";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.download);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.animeInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.animeList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox animeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox animeInput;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button download;
    }
}

