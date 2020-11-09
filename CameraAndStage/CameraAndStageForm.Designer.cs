namespace CameraAndStage
{
    partial class CameraAndStageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.XGroupBox = new System.Windows.Forms.GroupBox();
            this.XMinusButton = new System.Windows.Forms.Button();
            this.XPlusButton = new System.Windows.Forms.Button();
            this.XStepsLabel = new System.Windows.Forms.Label();
            this.XStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XVelocityLabel = new System.Windows.Forms.Label();
            this.XVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YGroupBox = new System.Windows.Forms.GroupBox();
            this.YStepsLabel = new System.Windows.Forms.Label();
            this.YVelocityLabel = new System.Windows.Forms.Label();
            this.YMinusButton = new System.Windows.Forms.Button();
            this.YPlusButton = new System.Windows.Forms.Button();
            this.YStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ZGroupBox = new System.Windows.Forms.GroupBox();
            this.ZVelocityLabel = new System.Windows.Forms.Label();
            this.ZStepsLabel = new System.Windows.Forms.Label();
            this.ZMinusButton = new System.Windows.Forms.Button();
            this.ZPlusButton = new System.Windows.Forms.Button();
            this.ZVelocityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ZStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bottomTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.cameraControlsPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.liveViewButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.XGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XVelocityNumericUpDown)).BeginInit();
            this.YGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVelocityNumericUpDown)).BeginInit();
            this.ZGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZVelocityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZStepsNumericUpDown)).BeginInit();
            this.cameraControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1402, 696);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cameraControlsPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 690);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.XGroupBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.YGroupBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ZGroupBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.bottomTextBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.openButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 429);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // XGroupBox
            // 
            this.XGroupBox.Controls.Add(this.XMinusButton);
            this.XGroupBox.Controls.Add(this.XPlusButton);
            this.XGroupBox.Controls.Add(this.XStepsLabel);
            this.XGroupBox.Controls.Add(this.XStepsNumericUpDown);
            this.XGroupBox.Controls.Add(this.XVelocityLabel);
            this.XGroupBox.Controls.Add(this.XVelocityNumericUpDown);
            this.XGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XGroupBox.Location = new System.Drawing.Point(3, 45);
            this.XGroupBox.Name = "XGroupBox";
            this.XGroupBox.Size = new System.Drawing.Size(382, 114);
            this.XGroupBox.TabIndex = 0;
            this.XGroupBox.TabStop = false;
            this.XGroupBox.Text = "X axis";
            // 
            // XMinusButton
            // 
            this.XMinusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XMinusButton.Location = new System.Drawing.Point(318, 27);
            this.XMinusButton.Name = "XMinusButton";
            this.XMinusButton.Size = new System.Drawing.Size(59, 60);
            this.XMinusButton.TabIndex = 3;
            this.XMinusButton.Text = "-X";
            this.XMinusButton.UseVisualStyleBackColor = true;
            this.XMinusButton.Click += new System.EventHandler(this.XMinusButton_Click);
            // 
            // XPlusButton
            // 
            this.XPlusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XPlusButton.Location = new System.Drawing.Point(239, 27);
            this.XPlusButton.Name = "XPlusButton";
            this.XPlusButton.Size = new System.Drawing.Size(59, 60);
            this.XPlusButton.TabIndex = 3;
            this.XPlusButton.Text = "+X";
            this.XPlusButton.UseVisualStyleBackColor = true;
            this.XPlusButton.Click += new System.EventHandler(this.XPlusButton_Click);
            // 
            // XStepsLabel
            // 
            this.XStepsLabel.AutoSize = true;
            this.XStepsLabel.Location = new System.Drawing.Point(153, 27);
            this.XStepsLabel.Name = "XStepsLabel";
            this.XStepsLabel.Size = new System.Drawing.Size(45, 20);
            this.XStepsLabel.TabIndex = 1;
            this.XStepsLabel.Text = "Steps";
            // 
            // XStepsNumericUpDown
            // 
            this.XStepsNumericUpDown.Location = new System.Drawing.Point(129, 59);
            this.XStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.XStepsNumericUpDown.Name = "XStepsNumericUpDown";
            this.XStepsNumericUpDown.Size = new System.Drawing.Size(91, 27);
            this.XStepsNumericUpDown.TabIndex = 2;
            // 
            // XVelocityLabel
            // 
            this.XVelocityLabel.AutoSize = true;
            this.XVelocityLabel.Location = new System.Drawing.Point(34, 27);
            this.XVelocityLabel.Name = "XVelocityLabel";
            this.XVelocityLabel.Size = new System.Drawing.Size(61, 20);
            this.XVelocityLabel.TabIndex = 1;
            this.XVelocityLabel.Text = "Velocity";
            // 
            // XVelocityNumericUpDown
            // 
            this.XVelocityNumericUpDown.Location = new System.Drawing.Point(15, 59);
            this.XVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XVelocityNumericUpDown.Name = "XVelocityNumericUpDown";
            this.XVelocityNumericUpDown.Size = new System.Drawing.Size(98, 27);
            this.XVelocityNumericUpDown.TabIndex = 0;
            this.XVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // YGroupBox
            // 
            this.YGroupBox.Controls.Add(this.YStepsLabel);
            this.YGroupBox.Controls.Add(this.YVelocityLabel);
            this.YGroupBox.Controls.Add(this.YMinusButton);
            this.YGroupBox.Controls.Add(this.YPlusButton);
            this.YGroupBox.Controls.Add(this.YStepsNumericUpDown);
            this.YGroupBox.Controls.Add(this.YVelocityNumericUpDown);
            this.YGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YGroupBox.Location = new System.Drawing.Point(3, 165);
            this.YGroupBox.Name = "YGroupBox";
            this.YGroupBox.Size = new System.Drawing.Size(382, 114);
            this.YGroupBox.TabIndex = 1;
            this.YGroupBox.TabStop = false;
            this.YGroupBox.Text = "Y axis";
            // 
            // YStepsLabel
            // 
            this.YStepsLabel.AutoSize = true;
            this.YStepsLabel.Location = new System.Drawing.Point(153, 27);
            this.YStepsLabel.Name = "YStepsLabel";
            this.YStepsLabel.Size = new System.Drawing.Size(45, 20);
            this.YStepsLabel.TabIndex = 1;
            this.YStepsLabel.Text = "Steps";
            // 
            // YVelocityLabel
            // 
            this.YVelocityLabel.AutoSize = true;
            this.YVelocityLabel.Location = new System.Drawing.Point(34, 27);
            this.YVelocityLabel.Name = "YVelocityLabel";
            this.YVelocityLabel.Size = new System.Drawing.Size(61, 20);
            this.YVelocityLabel.TabIndex = 1;
            this.YVelocityLabel.Text = "Velocity";
            // 
            // YMinusButton
            // 
            this.YMinusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YMinusButton.Location = new System.Drawing.Point(318, 27);
            this.YMinusButton.Name = "YMinusButton";
            this.YMinusButton.Size = new System.Drawing.Size(59, 60);
            this.YMinusButton.TabIndex = 3;
            this.YMinusButton.Text = "-Y";
            this.YMinusButton.UseVisualStyleBackColor = true;
            this.YMinusButton.Click += new System.EventHandler(this.YMinusButton_Click);
            // 
            // YPlusButton
            // 
            this.YPlusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YPlusButton.Location = new System.Drawing.Point(239, 27);
            this.YPlusButton.Name = "YPlusButton";
            this.YPlusButton.Size = new System.Drawing.Size(59, 60);
            this.YPlusButton.TabIndex = 3;
            this.YPlusButton.Text = "+Y";
            this.YPlusButton.UseVisualStyleBackColor = true;
            this.YPlusButton.Click += new System.EventHandler(this.YPlusButton_Click);
            // 
            // YStepsNumericUpDown
            // 
            this.YStepsNumericUpDown.Location = new System.Drawing.Point(129, 59);
            this.YStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.YStepsNumericUpDown.Name = "YStepsNumericUpDown";
            this.YStepsNumericUpDown.Size = new System.Drawing.Size(91, 27);
            this.YStepsNumericUpDown.TabIndex = 2;
            // 
            // YVelocityNumericUpDown
            // 
            this.YVelocityNumericUpDown.Location = new System.Drawing.Point(15, 59);
            this.YVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YVelocityNumericUpDown.Name = "YVelocityNumericUpDown";
            this.YVelocityNumericUpDown.Size = new System.Drawing.Size(98, 27);
            this.YVelocityNumericUpDown.TabIndex = 0;
            this.YVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ZGroupBox
            // 
            this.ZGroupBox.Controls.Add(this.ZVelocityLabel);
            this.ZGroupBox.Controls.Add(this.ZStepsLabel);
            this.ZGroupBox.Controls.Add(this.ZMinusButton);
            this.ZGroupBox.Controls.Add(this.ZPlusButton);
            this.ZGroupBox.Controls.Add(this.ZVelocityNumericUpDown);
            this.ZGroupBox.Controls.Add(this.ZStepsNumericUpDown);
            this.ZGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZGroupBox.Location = new System.Drawing.Point(3, 285);
            this.ZGroupBox.Name = "ZGroupBox";
            this.ZGroupBox.Size = new System.Drawing.Size(382, 114);
            this.ZGroupBox.TabIndex = 2;
            this.ZGroupBox.TabStop = false;
            this.ZGroupBox.Text = "Z axis";
            // 
            // ZVelocityLabel
            // 
            this.ZVelocityLabel.AutoSize = true;
            this.ZVelocityLabel.Location = new System.Drawing.Point(34, 27);
            this.ZVelocityLabel.Name = "ZVelocityLabel";
            this.ZVelocityLabel.Size = new System.Drawing.Size(61, 20);
            this.ZVelocityLabel.TabIndex = 1;
            this.ZVelocityLabel.Text = "Velocity";
            // 
            // ZStepsLabel
            // 
            this.ZStepsLabel.AutoSize = true;
            this.ZStepsLabel.Location = new System.Drawing.Point(153, 27);
            this.ZStepsLabel.Name = "ZStepsLabel";
            this.ZStepsLabel.Size = new System.Drawing.Size(45, 20);
            this.ZStepsLabel.TabIndex = 1;
            this.ZStepsLabel.Text = "Steps";
            // 
            // ZMinusButton
            // 
            this.ZMinusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZMinusButton.Location = new System.Drawing.Point(318, 27);
            this.ZMinusButton.Name = "ZMinusButton";
            this.ZMinusButton.Size = new System.Drawing.Size(59, 60);
            this.ZMinusButton.TabIndex = 3;
            this.ZMinusButton.Text = "-Z";
            this.ZMinusButton.UseVisualStyleBackColor = true;
            this.ZMinusButton.Click += new System.EventHandler(this.ZMinusButton_Click);
            // 
            // ZPlusButton
            // 
            this.ZPlusButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZPlusButton.Location = new System.Drawing.Point(239, 27);
            this.ZPlusButton.Name = "ZPlusButton";
            this.ZPlusButton.Size = new System.Drawing.Size(59, 60);
            this.ZPlusButton.TabIndex = 3;
            this.ZPlusButton.Text = "+Z";
            this.ZPlusButton.UseVisualStyleBackColor = true;
            this.ZPlusButton.Click += new System.EventHandler(this.ZPlusButton_Click);
            // 
            // ZVelocityNumericUpDown
            // 
            this.ZVelocityNumericUpDown.Location = new System.Drawing.Point(15, 60);
            this.ZVelocityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZVelocityNumericUpDown.Name = "ZVelocityNumericUpDown";
            this.ZVelocityNumericUpDown.Size = new System.Drawing.Size(98, 27);
            this.ZVelocityNumericUpDown.TabIndex = 0;
            this.ZVelocityNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ZStepsNumericUpDown
            // 
            this.ZStepsNumericUpDown.Location = new System.Drawing.Point(129, 60);
            this.ZStepsNumericUpDown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.ZStepsNumericUpDown.Name = "ZStepsNumericUpDown";
            this.ZStepsNumericUpDown.Size = new System.Drawing.Size(91, 27);
            this.ZStepsNumericUpDown.TabIndex = 2;
            // 
            // bottomTextBox
            // 
            this.bottomTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bottomTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTextBox.Location = new System.Drawing.Point(3, 405);
            this.bottomTextBox.Name = "bottomTextBox";
            this.bottomTextBox.Size = new System.Drawing.Size(382, 27);
            this.bottomTextBox.TabIndex = 3;
            // 
            // openButton
            // 
            this.openButton.AutoSize = true;
            this.openButton.Location = new System.Drawing.Point(3, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(94, 36);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cameraControlsPanel
            // 
            this.cameraControlsPanel.Controls.Add(this.nameLabel);
            this.cameraControlsPanel.Controls.Add(this.liveViewButton);
            this.cameraControlsPanel.Controls.Add(this.captureButton);
            this.cameraControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControlsPanel.Location = new System.Drawing.Point(3, 3);
            this.cameraControlsPanel.Name = "cameraControlsPanel";
            this.cameraControlsPanel.Size = new System.Drawing.Size(388, 228);
            this.cameraControlsPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(219, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "No camera";
            // 
            // liveViewButton
            // 
            this.liveViewButton.Location = new System.Drawing.Point(115, 11);
            this.liveViewButton.Name = "liveViewButton";
            this.liveViewButton.Size = new System.Drawing.Size(86, 37);
            this.liveViewButton.TabIndex = 0;
            this.liveViewButton.Text = "Live View";
            this.liveViewButton.UseVisualStyleBackColor = true;
            this.liveViewButton.Click += new System.EventHandler(this.liveViewButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(10, 11);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(86, 37);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(403, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(996, 690);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // CameraAndStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 696);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CameraAndStageForm";
            this.Text = "Stage Control - Camera View";
            this.Load += new System.EventHandler(this.CameraAndStageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.XGroupBox.ResumeLayout(false);
            this.XGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XVelocityNumericUpDown)).EndInit();
            this.YGroupBox.ResumeLayout(false);
            this.YGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YVelocityNumericUpDown)).EndInit();
            this.ZGroupBox.ResumeLayout(false);
            this.ZGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZVelocityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZStepsNumericUpDown)).EndInit();
            this.cameraControlsPanel.ResumeLayout(false);
            this.cameraControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox XGroupBox;
        private System.Windows.Forms.NumericUpDown XVelocityNumericUpDown;
        private System.Windows.Forms.NumericUpDown XStenumericUpDown1;
        private System.Windows.Forms.Label XVelocityLabel;
        private System.Windows.Forms.NumericUpDown XStepsNumericUpDown;
        private System.Windows.Forms.Label XStepsLabel;
        private System.Windows.Forms.Button XMinusButton;
        private System.Windows.Forms.Button XPlusButton;
        private System.Windows.Forms.GroupBox YGroupBox;
        private System.Windows.Forms.GroupBox ZGroupBox;
        private System.Windows.Forms.Label YStepsLabel;
        private System.Windows.Forms.Label YVelocityLabel;
        private System.Windows.Forms.Button YMinusButton;
        private System.Windows.Forms.Button YPlusButton;
        private System.Windows.Forms.NumericUpDown YStepsNumericUpDown;
        private System.Windows.Forms.NumericUpDown YVelocityNumericUpDown;
        private System.Windows.Forms.Label ZVelocityLabel;
        private System.Windows.Forms.Label ZStepsLabel;
        private System.Windows.Forms.Button ZMinusButton;
        private System.Windows.Forms.Button ZPlusButton;
        private System.Windows.Forms.NumericUpDown ZVelocityNumericUpDown;
        private System.Windows.Forms.NumericUpDown ZStepsNumericUpDown;
        private System.Windows.Forms.TextBox bottomTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Panel cameraControlsPanel;
        private System.Windows.Forms.Button liveViewButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Label nameLabel;
    }
}

