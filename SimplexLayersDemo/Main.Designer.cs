namespace SimplexLayersDemo
{
    partial class Main
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonRender = new System.Windows.Forms.Button();
            this.LabelConsole = new System.Windows.Forms.Label();
            this.LabelConsolePrint = new System.Windows.Forms.Label();
            this.NumericLayers = new System.Windows.Forms.NumericUpDown();
            this.LabelLayers = new System.Windows.Forms.Label();
            this.TextBoxScale = new System.Windows.Forms.TextBox();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.LabelSeed = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.TextBoxSeed = new System.Windows.Forms.TextBox();
            this.ButtonRollSeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(176, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(830, 440);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonRender
            // 
            this.ButtonRender.Location = new System.Drawing.Point(12, 410);
            this.ButtonRender.Name = "ButtonRender";
            this.ButtonRender.Size = new System.Drawing.Size(154, 42);
            this.ButtonRender.TabIndex = 1;
            this.ButtonRender.Text = "Render";
            this.ButtonRender.UseVisualStyleBackColor = true;
            this.ButtonRender.Click += new System.EventHandler(this.ButtonRender_Click);
            // 
            // LabelConsole
            // 
            this.LabelConsole.AutoSize = true;
            this.LabelConsole.Location = new System.Drawing.Point(13, 459);
            this.LabelConsole.Name = "LabelConsole";
            this.LabelConsole.Size = new System.Drawing.Size(63, 17);
            this.LabelConsole.TabIndex = 4;
            this.LabelConsole.Text = "Console:";
            // 
            // LabelConsolePrint
            // 
            this.LabelConsolePrint.AutoSize = true;
            this.LabelConsolePrint.Location = new System.Drawing.Point(83, 459);
            this.LabelConsolePrint.Name = "LabelConsolePrint";
            this.LabelConsolePrint.Size = new System.Drawing.Size(44, 17);
            this.LabelConsolePrint.TabIndex = 5;
            this.LabelConsolePrint.Text = "ready";
            // 
            // NumericLayers
            // 
            this.NumericLayers.Location = new System.Drawing.Point(12, 91);
            this.NumericLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericLayers.Name = "NumericLayers";
            this.NumericLayers.Size = new System.Drawing.Size(158, 22);
            this.NumericLayers.TabIndex = 6;
            this.NumericLayers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LabelLayers
            // 
            this.LabelLayers.AutoSize = true;
            this.LabelLayers.Location = new System.Drawing.Point(9, 71);
            this.LabelLayers.Name = "LabelLayers";
            this.LabelLayers.Size = new System.Drawing.Size(51, 17);
            this.LabelLayers.TabIndex = 7;
            this.LabelLayers.Text = "Layers";
            // 
            // TextBoxScale
            // 
            this.TextBoxScale.Location = new System.Drawing.Point(12, 136);
            this.TextBoxScale.Name = "TextBoxScale";
            this.TextBoxScale.Size = new System.Drawing.Size(158, 22);
            this.TextBoxScale.TabIndex = 8;
            this.TextBoxScale.Text = "0.008";
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(12, 116);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(43, 17);
            this.ScaleLabel.TabIndex = 9;
            this.ScaleLabel.Text = "Scale";
            // 
            // LabelSeed
            // 
            this.LabelSeed.AutoSize = true;
            this.LabelSeed.Location = new System.Drawing.Point(12, 12);
            this.LabelSeed.Name = "LabelSeed";
            this.LabelSeed.Size = new System.Drawing.Size(41, 17);
            this.LabelSeed.TabIndex = 10;
            this.LabelSeed.Text = "Seed";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(543, 458);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(463, 23);
            this.ProgressBar.TabIndex = 11;
            // 
            // TextBoxSeed
            // 
            this.TextBoxSeed.Location = new System.Drawing.Point(12, 33);
            this.TextBoxSeed.Name = "TextBoxSeed";
            this.TextBoxSeed.Size = new System.Drawing.Size(94, 22);
            this.TextBoxSeed.TabIndex = 12;
            this.TextBoxSeed.Text = "12345";
            // 
            // ButtonRollSeed
            // 
            this.ButtonRollSeed.Location = new System.Drawing.Point(112, 33);
            this.ButtonRollSeed.Name = "ButtonRollSeed";
            this.ButtonRollSeed.Size = new System.Drawing.Size(58, 23);
            this.ButtonRollSeed.TabIndex = 13;
            this.ButtonRollSeed.Text = "Reroll";
            this.ButtonRollSeed.UseVisualStyleBackColor = true;
            this.ButtonRollSeed.Click += new System.EventHandler(this.ButtonRollSeed_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1018, 485);
            this.Controls.Add(this.ButtonRollSeed);
            this.Controls.Add(this.TextBoxSeed);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.LabelSeed);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.TextBoxScale);
            this.Controls.Add(this.LabelLayers);
            this.Controls.Add(this.NumericLayers);
            this.Controls.Add(this.LabelConsolePrint);
            this.Controls.Add(this.LabelConsole);
            this.Controls.Add(this.ButtonRender);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Main";
            this.Text = "Simplex Layers Demo";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ButtonRender;
        private System.Windows.Forms.Label LabelConsole;
        private System.Windows.Forms.Label LabelConsolePrint;
        private System.Windows.Forms.NumericUpDown NumericLayers;
        private System.Windows.Forms.Label LabelLayers;
        private System.Windows.Forms.TextBox TextBoxScale;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label LabelSeed;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox TextBoxSeed;
        private System.Windows.Forms.Button ButtonRollSeed;
    }
}