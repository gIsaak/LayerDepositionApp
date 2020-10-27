using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CU30Interface;

namespace CameraAndStage
{
    public partial class CameraAndStageForm : Form
    {
        CU30 CU30obj = new CU30();
        public CameraAndStageForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            string szResult = CU30obj.m_CU30Open(0).ToString(); //TODO - check index

            if (szResult.Length > 5)
            {
                this.bottomTextBox.Text = szResult;
            }
            else
            {
                this.bottomTextBox.Text = "connected";
            }
        }

        //TODO - check direction of motion when pressing the buttons
        private void XPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.XVelocityNumericUpDown.Value;
            int steps = (int)this.XStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(1, vel, steps);
        }

        private void XMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.XVelocityNumericUpDown.Value;
            int steps = (int)this.XStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(1, -vel, steps);
        }

        private void YPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.YVelocityNumericUpDown.Value;
            int steps = (int)this.YStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(2, vel, steps);
        }

        private void YMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.YVelocityNumericUpDown.Value;
            int steps = (int)this.YStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(2, -vel, steps);
        }

        private void ZPlusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.ZVelocityNumericUpDown.Value;
            int steps = (int)this.ZStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(3, vel, steps);
        }

        private void ZMinusButton_Click(object sender, EventArgs e)
        {
            int vel = (int)this.ZVelocityNumericUpDown.Value;
            int steps = (int)this.ZStepsNumericUpDown.Value;
            CU30obj.m_CU30Step(3, -vel, steps);
        }

        private void CameraAndStageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
