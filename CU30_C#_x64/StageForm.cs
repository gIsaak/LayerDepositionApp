using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using CU30Interface;


namespace CU30_dotNet
{
    public partial class StageForm : Form
    {
        CU30 CU30obj = new CU30();
        public StageForm()
        {
            InitializeComponent();
        }
        private void openButton_Click(object sender, EventArgs e)
        {           
            uint i = (uint) this.EEIDlistBox.TopIndex  ;
            string szResult = CU30obj.m_CU30Open(i).ToString();
                   
            if (szResult.Length > 5){
                // x64 Result.Length = 1 ?
                // x86 Result.Length = 1 ?
                this.bottomTextBox.Text = szResult;
            }
            else{
                //this.bottomTextBox.Text = String.Format("connected, Result.Length = {0:}", szResult.Length) ;
                this.bottomTextBox.Text = "connected";
                this.infoTextBox.Text = CU30obj.m_CU30GetEEPromInfo();  
            }

        }
        private void DCDConButton_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30DCDCon();
        }
        private void DCDCoffButton_Click(object sender, EventArgs e)
        {

            CU30obj.m_CU30DCDCoff();
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30Stop();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30Close();
        }
        private void echoButton_Click(object sender, EventArgs e)
        {
            uint sec = (uint) DateTime.Now.Second;
            this.bottomTextBox.Text = String.Format("send = {0:} =>  echo = {1:}", sec, CU30obj.m_CU30Echo(sec).ToString());
        }
        private void readyButton_Click(object sender, EventArgs e)
        {
            uint i = CU30obj.m_CU30Ready();
            if (i > 0)
            {
                this.bottomTextBox.Text = " The drive doesn't move";
            }
            else
            {
                this.bottomTextBox.Text = " The drive moves";
            }           
        }
        private void XSetButton_Click(object sender, EventArgs e)
        {
            int vel   = (int) this.XVelocityNumericUpDown.Value;
            int steps = (int) this.XStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(1, vel, steps);
        }
        private void YSetButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.YVelocityNumericUpDown.Value;
            int steps = (int)this.YStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(2, vel, steps);
        }
        private void ZSetButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.ZVelocityNumericUpDown.Value;
            int steps = (int)this.ZStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(3, vel, steps);
        } 
        private void XScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.XScrollBar.Value;
            CU30obj.m_CU30Move(1, speed);
        }
        private void YScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.YScrollBar.Value;
            CU30obj.m_CU30Move(2, speed);
        }
        private void ZScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.ZScrollBar.Value;
            CU30obj.m_CU30Move(3, speed);
        }
        private void stageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
