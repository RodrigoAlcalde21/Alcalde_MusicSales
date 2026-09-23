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
            btnCal = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(243, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Music Sales";
            lblTitle.Click += label1_Click;
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Location = new Point(91, 115);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(87, 20);
            lblSongName.TabIndex = 1;
            lblSongName.Text = "Song Name";
            lblSongName.Click += lblSongName_Click;
            // 
            // lblSongCost
            // 
            lblSongCost.AutoSize = true;
            lblSongCost.Location = new Point(91, 168);
            lblSongCost.Name = "lblSongCost";
            lblSongCost.Size = new Size(76, 20);
            lblSongCost.TabIndex = 2;
            lblSongCost.Text = "Song Cost";
            // 
            // lblNumberOfPlays
            // 
            lblNumberOfPlays.AutoSize = true;
            lblNumberOfPlays.Location = new Point(91, 217);
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
            // btnCal
            // 
            btnCal.Location = new Point(39, 477);
            btnCal.Margin = new Padding(3, 4, 3, 4);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(110, 95);
            btnCal.TabIndex = 8;
            btnCal.Text = "Calculate & &Display";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(233, 477);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 95);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(424, 477);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(101, 95);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(136, 281);
            lstOut.Margin = new Padding(3, 4, 3, 4);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(269, 144);
            lstOut.TabIndex = 11;
            lstOut.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 576);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
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
        private Button btnCal;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
    }
}
