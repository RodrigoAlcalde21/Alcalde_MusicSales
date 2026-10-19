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
            lblNumberOfPlays = new Label();
            txtSongName = new TextBox();
            txtNumberOfPlays = new TextBox();
            btnCal = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lstOut = new ListBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(213, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Music Sales";
            lblTitle.Click += label1_Click;
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Location = new Point(80, 109);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(69, 15);
            lblSongName.TabIndex = 1;
            lblSongName.Text = "Song Name";
            lblSongName.Click += lblSongName_Click;
            // 
            // lblNumberOfPlays
            // 
            lblNumberOfPlays.AutoSize = true;
            lblNumberOfPlays.Location = new Point(80, 145);
            lblNumberOfPlays.Name = "lblNumberOfPlays";
            lblNumberOfPlays.Size = new Size(95, 15);
            lblNumberOfPlays.TabIndex = 3;
            lblNumberOfPlays.Text = "Number of Plays";
            lblNumberOfPlays.Click += lblNumberOfPlays_Click;
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(265, 109);
            txtSongName.Margin = new Padding(3, 2, 3, 2);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(110, 23);
            txtSongName.TabIndex = 4;
            txtSongName.Enter += txtSongName_Enter;
            txtSongName.Leave += txtSongName_Leave;
            // 
            // txtNumberOfPlays
            // 
            txtNumberOfPlays.Location = new Point(265, 145);
            txtNumberOfPlays.Margin = new Padding(3, 2, 3, 2);
            txtNumberOfPlays.Name = "txtNumberOfPlays";
            txtNumberOfPlays.Size = new Size(110, 23);
            txtNumberOfPlays.TabIndex = 6;
            txtNumberOfPlays.TextChanged += txtNumberOfPlays_TextChanged;
            txtNumberOfPlays.Enter += txtNumberOfPlays_Enter;
            txtNumberOfPlays.Leave += txtNumberOfPlays_Leave;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(34, 358);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(96, 71);
            btnCal.TabIndex = 8;
            btnCal.Text = "Calculate && &Display";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(204, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 71);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(371, 358);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(88, 71);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(80, 215);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(347, 109);
            lstOut.TabIndex = 11;
            lstOut.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(94, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 55);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(119, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(244, 30);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 453);
            Controls.Add(groupBox1);
            Controls.Add(lstOut);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(txtNumberOfPlays);
            Controls.Add(txtSongName);
            Controls.Add(lblNumberOfPlays);
            Controls.Add(lblSongName);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Rodrigo Alcalde";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSongName;
        private Label lblNumberOfPlays;
        private TextBox txtSongName;
        private TextBox txtNumberOfPlays;
        private Button btnCal;
        private Button btnClear;
        private Button btnQuit;
        private ListBox lstOut;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
