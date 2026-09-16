namespace MusicSales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSongName = new Label();
            lblSongCost = new Label();
            lblNumberOfPlays = new Label();
            txtSongName = new TextBox();
            txtSongCost = new TextBox();
            txtNumberOfPlays = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(321, 63);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Music Sales";
            lblTitle.Click += label1_Click;
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Location = new Point(76, 118);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(87, 20);
            lblSongName.TabIndex = 1;
            lblSongName.Text = "Song Name";
            // 
            // lblSongCost
            // 
            lblSongCost.AutoSize = true;
            lblSongCost.Location = new Point(76, 171);
            lblSongCost.Name = "lblSongCost";
            lblSongCost.Size = new Size(76, 20);
            lblSongCost.TabIndex = 2;
            lblSongCost.Text = "Song Cost";
            // 
            // lblNumberOfPlays
            // 
            lblNumberOfPlays.AutoSize = true;
            lblNumberOfPlays.Location = new Point(76, 216);
            lblNumberOfPlays.Name = "lblNumberOfPlays";
            lblNumberOfPlays.Size = new Size(118, 20);
            lblNumberOfPlays.TabIndex = 3;
            lblNumberOfPlays.Text = "Number of Plays";
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(303, 111);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(125, 27);
            txtSongName.TabIndex = 4;
            // 
            // txtSongCost
            // 
            txtSongCost.Location = new Point(303, 164);
            txtSongCost.Name = "txtSongCost";
            txtSongCost.Size = new Size(125, 27);
            txtSongCost.TabIndex = 5;
            // 
            // txtNumberOfPlays
            // 
            txtNumberOfPlays.Location = new Point(303, 213);
            txtNumberOfPlays.Name = "txtNumberOfPlays";
            txtNumberOfPlays.Size = new Size(125, 27);
            txtNumberOfPlays.TabIndex = 6;
            txtNumberOfPlays.TextChanged += txtNumberOfPlays_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumberOfPlays);
            Controls.Add(txtSongCost);
            Controls.Add(txtSongName);
            Controls.Add(lblNumberOfPlays);
            Controls.Add(lblSongCost);
            Controls.Add(lblSongName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSongName;
        private Label lblSongCost;
        private Label lblNumberOfPlays;
        private TextBox txtSongName;
        private TextBox txtSongCost;
        private TextBox txtNumberOfPlays;
    }
}
