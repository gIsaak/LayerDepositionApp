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
    public partial class Form1 : Form
    {
        CU30 CU30obj = new CU30();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            uint i = (uint) this.listBox1.TopIndex  ;
            string szResult = CU30obj.m_CU30Open(i).ToString();
                   
            if (szResult.Length > 5){
                // x64 Result.Length = 1 ?
                // x86 Result.Length = 1 ?
                this.textBox1.Text = szResult;
            }
            else{
                //this.textBox1.Text = String.Format("connected, Result.Length = {0:}", szResult.Length) ;
                this.textBox1.Text = "connected";
                this.textBox2.Text = CU30obj.m_CU30GetEEPromInfo();  
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30DCDCon();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            CU30obj.m_CU30DCDCoff();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30Stop();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CU30obj.m_CU30Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            uint sec = (uint) DateTime.Now.Second;
            this.textBox1.Text = String.Format("send = {0:} =>  echo = {1:}", sec, CU30obj.m_CU30Echo(sec).ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            uint i = CU30obj.m_CU30Ready();
            if (i > 0)
            {
                this.textBox1.Text = " The drive doesn't move";
            }
            else
            {
                this.textBox1.Text = " The drive moves";
            }           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int vel   = (int) this.numericUpDown1.Value;
            int steps = (int) this.numericUpDown2.Value;
            CU30obj.m_CU30Step(1, vel, steps);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int vel = (int)this.numericUpDown4.Value;
            int steps = (int)this.numericUpDown3.Value;
            CU30obj.m_CU30Step(2, vel, steps);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int vel = (int)this.numericUpDown6.Value;
            int steps = (int)this.numericUpDown5.Value;
            CU30obj.m_CU30Step(3, vel, steps);
        } 
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.hScrollBar1.Value;
            CU30obj.m_CU30Move(1, speed);
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.hScrollBar2.Value;
            CU30obj.m_CU30Move(2, speed);
        }
        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int speed = this.hScrollBar3.Value;
            CU30obj.m_CU30Move(3, speed);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
