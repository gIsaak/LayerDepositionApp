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
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.startLiveViewButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.imageBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1422, 763);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // startLiveViewButton
            // 
            this.startLiveViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLiveViewButton.Location = new System.Drawing.Point(3, 3);
            this.startLiveViewButton.Name = "startLiveViewButton";
            this.startLiveViewButton.Size = new System.Drawing.Size(278, 70);
            this.startLiveViewButton.TabIndex = 1;
            this.startLiveViewButton.Text = "Start Live View";
            this.startLiveViewButton.UseVisualStyleBackColor = true;
            this.startLiveViewButton.Click += new System.EventHandler(this.startLiveViewButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(287, 3);
            this.imageBox.Name = "imageBox";
            this.tableLayoutPanel.SetRowSpan(this.imageBox, 4);
            this.imageBox.Size = new System.Drawing.Size(1132, 757);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DrawingForm";
            this.Text = "Drawing Form";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button startLiveViewButton;
        private Emgu.CV.UI.ImageBox imageBox;
    }
}

