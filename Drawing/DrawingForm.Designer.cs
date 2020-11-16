namespace Drawing
{
    partial class DrawingForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startLiveViewButton = new System.Windows.Forms.Button();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.trackLabel = new System.Windows.Forms.Label();
            this.mouseTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel.Controls.Add(this.startLiveViewButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.imageBox, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.drawButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.clearButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.trackListBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.trackLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.mouseTextBox, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1066, 620);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // startLiveViewButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.startLiveViewButton, 2);
            this.startLiveViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLiveViewButton.Location = new System.Drawing.Point(2, 2);
            this.startLiveViewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startLiveViewButton.Name = "startLiveViewButton";
            this.startLiveViewButton.Size = new System.Drawing.Size(208, 58);
            this.startLiveViewButton.TabIndex = 1;
            this.startLiveViewButton.Text = "Start Live View";
            this.startLiveViewButton.UseVisualStyleBackColor = true;
            this.startLiveViewButton.Click += new System.EventHandler(this.startLiveViewButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(214, 2);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageBox.Name = "imageBox";
            this.tableLayoutPanel.SetRowSpan(this.imageBox, 4);
            this.imageBox.Size = new System.Drawing.Size(850, 616);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // drawButton
            // 
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawButton.Location = new System.Drawing.Point(2, 64);
            this.drawButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(102, 58);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(108, 64);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 58);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // trackListBox
            // 
            this.trackListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackListBox.FormattingEnabled = true;
            this.trackListBox.Location = new System.Drawing.Point(108, 126);
            this.trackListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.Size = new System.Drawing.Size(102, 58);
            this.trackListBox.TabIndex = 5;
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLabel.Location = new System.Drawing.Point(2, 124);
            this.trackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(102, 62);
            this.trackLabel.TabIndex = 6;
            this.trackLabel.Text = "Track";
            this.trackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseTextBox
            // 
            this.mouseTextBox.Location = new System.Drawing.Point(2, 188);
            this.mouseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mouseTextBox.Name = "mouseTextBox";
            this.mouseTextBox.Size = new System.Drawing.Size(102, 20);
            this.mouseTextBox.TabIndex = 7;
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 620);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DrawingForm";
            this.Text = "Drawing Form";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button startLiveViewButton;
        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox trackListBox;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.TextBox mouseTextBox;
    }
}

