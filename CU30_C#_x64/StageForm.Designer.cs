namespace CU30_dotNet
{
    partial class StageForm
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
            this.openButton = new System.Windows.Forms.Button();
            this.EEIDlistBox = new System.Windows.Forms.ListBox();
            this.bottomTextBox = new System.Windows.Forms.TextBox();
            this.DCDConButton = new System.Windows.Forms.Button();
            this.DCDCoffButton = new System.Windows.Forms.Button();
            this.XScrollBar = new System.Windows.Forms.HScrollBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.echoButton = new System.Windows.Forms.Button();
            this.readyButton = new System.Windows.Forms.Button();
            this.XSetButton = new System.Windows.Forms.Button();
            this.XVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XVelocityLabel = new System.Windows.Forms.Label();
            this.XStepsLabel = new System.Windows.Forms.Label();
            this.XGroupBox = new System.Windows.Forms.GroupBox();
            this.YGroupBox = new System.Windows.Forms.GroupBox();
            this.YStepsLabel = new System.Windows.Forms.Label();
            this.YVelocityLabel = new System.Windows.Forms.Label();
            this.YStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YScrollBar = new System.Windows.Forms.HScrollBar();
            this.YSetButton = new System.Windows.Forms.Button();
            this.ZGroupBox = new System.Windows.Forms.GroupBox();
            this.ZStepsLabel = new System.Windows.Forms.Label();
            this.ZVelocityLabel = new System.Windows.Forms.Label();
            this.ZStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ZVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ZScrollBar = new System.Windows.Forms.HScrollBar();
            this.ZSetButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.XVelocityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XStepsNumericUpDown)).BeginInit();
            this.XGroupBox.SuspendLayout();
            this.YGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVelocityNumericUpDown)).BeginInit();
            this.ZGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVelocityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(367, 50);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 28);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // EEIDlistBox
            // 
            this.EEIDlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EEIDlistBox.FormattingEnabled = true;
            this.EEIDlistBox.ItemHeight = 20;
            this.EEIDlistBox.Items.AddRange(new object[] {
            "EEID    0",
            "EEID    1",
            "EEID    2",
            "EEID    3",
            "EEID    4",
            "EEID    5",
            "EEID    6",
            "EEID    7",
            "EEID    8",
            "EEID    9",
            "EEID  10",
            "EEID  11",
            "EEID  12",
            "EEID  13",
            "EEID  14",
            "EEID  15",
            ""});
            this.EEIDlistBox.Location = new System.Drawing.Point(367, 26);
            this.EEIDlistBox.Margin = new System.Windows.Forms.Padding(4);
            this.EEIDlistBox.Name = "EEIDlistBox";
            this.EEIDlistBox.Size = new System.Drawing.Size(97, 24);
            this.EEIDlistBox.TabIndex = 1;
            // 
            // bottomTextBox
            // 
            this.bottomTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bottomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bottomTextBox.Location = new System.Drawing.Point(1, 566);
            this.bottomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bottomTextBox.Name = "bottomTextBox";
            this.bottomTextBox.Size = new System.Drawing.Size(507, 15);
            this.bottomTextBox.TabIndex = 2;
            // 
            // DCDConButton
            // 
            this.DCDConButton.Location = new System.Drawing.Point(367, 79);
            this.DCDConButton.Margin = new System.Windows.Forms.Padding(4);
            this.DCDConButton.Name = "DCDConButton";
            this.DCDConButton.Size = new System.Drawing.Size(100, 28);
            this.DCDConButton.TabIndex = 0;
            this.DCDConButton.Text = "DCDCon";
            this.DCDConButton.UseVisualStyleBackColor = true;
            this.DCDConButton.Click += new System.EventHandler(this.DCDConButton_Click);
            // 
            // DCDCoffButton
            // 
            this.DCDCoffButton.Location = new System.Drawing.Point(367, 107);
            this.DCDCoffButton.Margin = new System.Windows.Forms.Padding(4);
            this.DCDCoffButton.Name = "DCDCoffButton";
            this.DCDCoffButton.Size = new System.Drawing.Size(100, 28);
            this.DCDCoffButton.TabIndex = 0;
            this.DCDCoffButton.Text = "DCDCoff";
            this.DCDCoffButton.UseVisualStyleBackColor = true;
            this.DCDCoffButton.Click += new System.EventHandler(this.DCDCoffButton_Click);
            // 
            // XScrollBar
            // 
            this.XScrollBar.Location = new System.Drawing.Point(15, 18);
            this.XScrollBar.Maximum = 1000;
            this.XScrollBar.Minimum = -1000;
            this.XScrollBar.Name = "XScrollBar";
            this.XScrollBar.Size = new System.Drawing.Size(433, 17);
            this.XScrollBar.TabIndex = 3;
            this.XScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.XScrollBar_Scroll);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(367, 135);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(367, 220);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // echoButton
            // 
            this.echoButton.Location = new System.Drawing.Point(367, 192);
            this.echoButton.Margin = new System.Windows.Forms.Padding(4);
            this.echoButton.Name = "echoButton";
            this.echoButton.Size = new System.Drawing.Size(100, 28);
            this.echoButton.TabIndex = 0;
            this.echoButton.Text = "Echo";
            this.echoButton.UseVisualStyleBackColor = true;
            this.echoButton.Click += new System.EventHandler(this.echoButton_Click);
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(367, 164);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(100, 28);
            this.readyButton.TabIndex = 0;
            this.readyButton.Text = "Ready ?";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // XSetButton
            // 
            this.XSetButton.Location = new System.Drawing.Point(389, 48);
            this.XSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.XSetButton.Name = "XSetButton";
            this.XSetButton.Size = new System.Drawing.Size(59, 28);
            this.XSetButton.TabIndex = 0;
            this.XSetButton.Text = "Set";
            this.XSetButton.UseVisualStyleBackColor = true;
            this.XSetButton.Click += new System.EventHandler(this.XSetButton_Click);
            // 
            // XVelocityNumericUpDown
            // 
            this.XVelocityNumericUpDown.Location = new System.Drawing.Point(15, 49);
            this.XVelocityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.XVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XVelocityNumericUpDown.Name = "XVelocityNumericUpDown";
            this.XVelocityNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.XVelocityNumericUpDown.TabIndex = 4;
            this.XVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // XStepsNumericUpDown
            // 
            this.XStepsNumericUpDown.Location = new System.Drawing.Point(189, 49);
            this.XStepsNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.XStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.XStepsNumericUpDown.Name = "XStepsNumericUpDown";
            this.XStepsNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.XStepsNumericUpDown.TabIndex = 5;
            // 
            // XVelocityLabel
            // 
            this.XVelocityLabel.AutoSize = true;
            this.XVelocityLabel.Location = new System.Drawing.Point(124, 54);
            this.XVelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XVelocityLabel.Name = "XVelocityLabel";
            this.XVelocityLabel.Size = new System.Drawing.Size(55, 17);
            this.XVelocityLabel.TabIndex = 6;
            this.XVelocityLabel.Text = "velocity";
            // 
            // XStepsLabel
            // 
            this.XStepsLabel.AutoSize = true;
            this.XStepsLabel.Location = new System.Drawing.Point(311, 54);
            this.XStepsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XStepsLabel.Name = "XStepsLabel";
            this.XStepsLabel.Size = new System.Drawing.Size(44, 17);
            this.XStepsLabel.TabIndex = 7;
            this.XStepsLabel.Text = "Steps";
            // 
            // XGroupBox
            // 
            this.XGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.XGroupBox.Controls.Add(this.XStepsLabel);
            this.XGroupBox.Controls.Add(this.XVelocityLabel);
            this.XGroupBox.Controls.Add(this.XStepsNumericUpDown);
            this.XGroupBox.Controls.Add(this.XVelocityNumericUpDown);
            this.XGroupBox.Controls.Add(this.XScrollBar);
            this.XGroupBox.Controls.Add(this.XSetButton);
            this.XGroupBox.Location = new System.Drawing.Point(19, 257);
            this.XGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.XGroupBox.Name = "XGroupBox";
            this.XGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.XGroupBox.Size = new System.Drawing.Size(463, 91);
            this.XGroupBox.TabIndex = 8;
            this.XGroupBox.TabStop = false;
            this.XGroupBox.Text = "X axis";
            // 
            // YGroupBox
            // 
            this.YGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.YGroupBox.Controls.Add(this.YStepsLabel);
            this.YGroupBox.Controls.Add(this.YVelocityLabel);
            this.YGroupBox.Controls.Add(this.YStepsNumericUpDown);
            this.YGroupBox.Controls.Add(this.YVelocityNumericUpDown);
            this.YGroupBox.Controls.Add(this.YScrollBar);
            this.YGroupBox.Controls.Add(this.YSetButton);
            this.YGroupBox.Location = new System.Drawing.Point(19, 356);
            this.YGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.YGroupBox.Name = "YGroupBox";
            this.YGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.YGroupBox.Size = new System.Drawing.Size(463, 91);
            this.YGroupBox.TabIndex = 8;
            this.YGroupBox.TabStop = false;
            this.YGroupBox.Text = "Y axis";
            // 
            // YStepsLabel
            // 
            this.YStepsLabel.AutoSize = true;
            this.YStepsLabel.Location = new System.Drawing.Point(311, 54);
            this.YStepsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YStepsLabel.Name = "YStepsLabel";
            this.YStepsLabel.Size = new System.Drawing.Size(44, 17);
            this.YStepsLabel.TabIndex = 7;
            this.YStepsLabel.Text = "Steps";
            // 
            // YVelocityLabel
            // 
            this.YVelocityLabel.AutoSize = true;
            this.YVelocityLabel.Location = new System.Drawing.Point(124, 54);
            this.YVelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YVelocityLabel.Name = "YVelocityLabel";
            this.YVelocityLabel.Size = new System.Drawing.Size(55, 17);
            this.YVelocityLabel.TabIndex = 6;
            this.YVelocityLabel.Text = "velocity";
            // 
            // YStepsNumericUpDown
            // 
            this.YStepsNumericUpDown.Location = new System.Drawing.Point(189, 49);
            this.YStepsNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.YStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.YStepsNumericUpDown.Name = "YStepsNumericUpDown";
            this.YStepsNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.YStepsNumericUpDown.TabIndex = 5;
            // 
            // YVelocityNumericUpDown
            // 
            this.YVelocityNumericUpDown.Location = new System.Drawing.Point(15, 49);
            this.YVelocityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.YVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YVelocityNumericUpDown.Name = "YVelocityNumericUpDown";
            this.YVelocityNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.YVelocityNumericUpDown.TabIndex = 4;
            this.YVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // YScrollBar
            // 
            this.YScrollBar.Location = new System.Drawing.Point(15, 18);
            this.YScrollBar.Maximum = 1000;
            this.YScrollBar.Minimum = -1000;
            this.YScrollBar.Name = "YScrollBar";
            this.YScrollBar.Size = new System.Drawing.Size(433, 17);
            this.YScrollBar.TabIndex = 3;
            this.YScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.YScrollBar_Scroll);
            // 
            // YSetButton
            // 
            this.YSetButton.Location = new System.Drawing.Point(389, 48);
            this.YSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.YSetButton.Name = "YSetButton";
            this.YSetButton.Size = new System.Drawing.Size(59, 28);
            this.YSetButton.TabIndex = 0;
            this.YSetButton.Text = "Set";
            this.YSetButton.UseVisualStyleBackColor = true;
            this.YSetButton.Click += new System.EventHandler(this.YSetButton_Click);
            // 
            // ZGroupBox
            // 
            this.ZGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.ZGroupBox.Controls.Add(this.ZStepsLabel);
            this.ZGroupBox.Controls.Add(this.ZVelocityLabel);
            this.ZGroupBox.Controls.Add(this.ZStepsNumericUpDown);
            this.ZGroupBox.Controls.Add(this.ZVelocityNumericUpDown);
            this.ZGroupBox.Controls.Add(this.ZScrollBar);
            this.ZGroupBox.Controls.Add(this.ZSetButton);
            this.ZGroupBox.Location = new System.Drawing.Point(19, 460);
            this.ZGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZGroupBox.Name = "ZGroupBox";
            this.ZGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ZGroupBox.Size = new System.Drawing.Size(463, 91);
            this.ZGroupBox.TabIndex = 8;
            this.ZGroupBox.TabStop = false;
            this.ZGroupBox.Text = "Z axis";
            // 
            // ZStepsLabel
            // 
            this.ZStepsLabel.AutoSize = true;
            this.ZStepsLabel.Location = new System.Drawing.Point(311, 54);
            this.ZStepsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZStepsLabel.Name = "ZStepsLabel";
            this.ZStepsLabel.Size = new System.Drawing.Size(44, 17);
            this.ZStepsLabel.TabIndex = 7;
            this.ZStepsLabel.Text = "Steps";
            // 
            // ZVelocityLabel
            // 
            this.ZVelocityLabel.AutoSize = true;
            this.ZVelocityLabel.Location = new System.Drawing.Point(124, 54);
            this.ZVelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZVelocityLabel.Name = "ZVelocityLabel";
            this.ZVelocityLabel.Size = new System.Drawing.Size(55, 17);
            this.ZVelocityLabel.TabIndex = 6;
            this.ZVelocityLabel.Text = "velocity";
            // 
            // ZStepsNumericUpDown
            // 
            this.ZStepsNumericUpDown.Location = new System.Drawing.Point(189, 49);
            this.ZStepsNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ZStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.ZStepsNumericUpDown.Name = "ZStepsNumericUpDown";
            this.ZStepsNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.ZStepsNumericUpDown.TabIndex = 5;
            // 
            // ZVelocityNumericUpDown
            // 
            this.ZVelocityNumericUpDown.Location = new System.Drawing.Point(15, 49);
            this.ZVelocityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ZVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZVelocityNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ZVelocityNumericUpDown.Name = "ZVelocityNumericUpDown";
            this.ZVelocityNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.ZVelocityNumericUpDown.TabIndex = 4;
            this.ZVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ZScrollBar
            // 
            this.ZScrollBar.Location = new System.Drawing.Point(15, 18);
            this.ZScrollBar.Maximum = 1000;
            this.ZScrollBar.Minimum = -1000;
            this.ZScrollBar.Name = "ZScrollBar";
            this.ZScrollBar.Size = new System.Drawing.Size(433, 17);
            this.ZScrollBar.TabIndex = 3;
            this.ZScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZScrollBar_Scroll);
            // 
            // ZSetButton
            // 
            this.ZSetButton.Location = new System.Drawing.Point(389, 48);
            this.ZSetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ZSetButton.Name = "ZSetButton";
            this.ZSetButton.Size = new System.Drawing.Size(59, 28);
            this.ZSetButton.TabIndex = 0;
            this.ZSetButton.Text = "Set";
            this.ZSetButton.UseVisualStyleBackColor = true;
            this.ZSetButton.Click += new System.EventHandler(this.ZSetButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Location = new System.Drawing.Point(19, 26);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(325, 223);
            this.infoTextBox.TabIndex = 9;
            // 
            // StageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 583);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.ZGroupBox);
            this.Controls.Add(this.YGroupBox);
            this.Controls.Add(this.XGroupBox);
            this.Controls.Add(this.bottomTextBox);
            this.Controls.Add(this.EEIDlistBox);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.echoButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.DCDCoffButton);
            this.Controls.Add(this.DCDConButton);
            this.Controls.Add(this.openButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StageForm";
            this.Text = "Mechonics CU30 Stage";
            this.Load += new System.EventHandler(this.stageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XVelocityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XStepsNumericUpDown)).EndInit();
            this.XGroupBox.ResumeLayout(false);
            this.XGroupBox.PerformLayout();
            this.YGroupBox.ResumeLayout(false);
            this.YGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVelocityNumericUpDown)).EndInit();
            this.ZGroupBox.ResumeLayout(false);
            this.ZGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZVelocityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox EEIDlistBox;
        private System.Windows.Forms.TextBox bottomTextBox;
        private System.Windows.Forms.Button DCDConButton;
        private System.Windows.Forms.Button DCDCoffButton;
        private System.Windows.Forms.HScrollBar XScrollBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button echoButton;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Button XSetButton;
        private System.Windows.Forms.NumericUpDown XVelocityNumericUpDown;
        private System.Windows.Forms.NumericUpDown XStepsNumericUpDown;
        private System.Windows.Forms.Label XVelocityLabel;
        private System.Windows.Forms.Label XStepsLabel;
        private System.Windows.Forms.GroupBox XGroupBox;
        private System.Windows.Forms.GroupBox YGroupBox;
        private System.Windows.Forms.Label YStepsLabel;
        private System.Windows.Forms.Label YVelocityLabel;
        private System.Windows.Forms.NumericUpDown YStepsNumericUpDown;
        private System.Windows.Forms.NumericUpDown YVelocityNumericUpDown;
        private System.Windows.Forms.HScrollBar YScrollBar;
        private System.Windows.Forms.Button YSetButton;
        private System.Windows.Forms.GroupBox ZGroupBox;
        private System.Windows.Forms.Label ZStepsLabel;
        private System.Windows.Forms.Label ZVelocityLabel;
        private System.Windows.Forms.NumericUpDown ZStepsNumericUpDown;
        private System.Windows.Forms.NumericUpDown ZVelocityNumericUpDown;
        private System.Windows.Forms.HScrollBar ZScrollBar;
        private System.Windows.Forms.Button ZSetButton;
        private System.Windows.Forms.TextBox infoTextBox;
    }
}

