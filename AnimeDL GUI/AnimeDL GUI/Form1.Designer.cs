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
            this.RB480p = new System.Windows.Forms.RadioButton();
            this.RB720p = new System.Windows.Forms.RadioButton();
            this.download = new System.Windows.Forms.Button();
            this.RB1080p = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // animeList
            // 
            this.animeList.FormattingEnabled = true;
            this.animeList.ItemHeight = 16;
            this.animeList.Location = new System.Drawing.Point(52, 71);
            this.animeList.Margin = new System.Windows.Forms.Padding(4);
            this.animeList.Name = "animeList";
            this.animeList.Size = new System.Drawing.Size(348, 116);
            this.animeList.TabIndex = 0;
            this.animeList.SelectedIndexChanged += new System.EventHandler(this.animeList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
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
            this.animeInput.Margin = new System.Windows.Forms.Padding(4);
            this.animeInput.Name = "animeInput";
            this.animeInput.Size = new System.Drawing.Size(132, 22);
            this.animeInput.TabIndex = 2;
            this.animeInput.TextChanged += new System.EventHandler(this.animeInput_TextChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(301, 196);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
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
            // RB480p
            // 
            this.RB480p.AutoSize = true;
            this.RB480p.Location = new System.Drawing.Point(517, 71);
            this.RB480p.Name = "RB480p";
            this.RB480p.Size = new System.Drawing.Size(61, 21);
            this.RB480p.TabIndex = 5;
            this.RB480p.Text = "480p";
            this.RB480p.UseVisualStyleBackColor = true;
            this.RB480p.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB720p
            // 
            this.RB720p.AutoSize = true;
            this.RB720p.Location = new System.Drawing.Point(517, 121);
            this.RB720p.Name = "RB720p";
            this.RB720p.Size = new System.Drawing.Size(61, 21);
            this.RB720p.TabIndex = 6;
            this.RB720p.Text = "720p";
            this.RB720p.UseVisualStyleBackColor = true;
            this.RB720p.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // RB1080p
            // 
            this.RB1080p.AutoSize = true;
            this.RB1080p.Checked = true;
            this.RB1080p.Location = new System.Drawing.Point(517, 165);
            this.RB1080p.Name = "RB1080p";
            this.RB1080p.Size = new System.Drawing.Size(69, 21);
            this.RB1080p.TabIndex = 8;
            this.RB1080p.TabStop = true;
            this.RB1080p.Text = "1080p";
            this.RB1080p.UseVisualStyleBackColor = true;
            this.RB1080p.CheckedChanged += new System.EventHandler(this.RB1080p_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RB1080p);
            this.Controls.Add(this.download);
            this.Controls.Add(this.RB720p);
            this.Controls.Add(this.RB480p);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.animeInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.animeList);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.RadioButton RB480p;
        private System.Windows.Forms.RadioButton RB720p;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.RadioButton RB1080p;
    }
}

