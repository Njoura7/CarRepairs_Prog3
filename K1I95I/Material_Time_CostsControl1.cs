using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K1I95I
{
    public partial class Material_Time_CostsControl1 : UserControl
    {
      
      public String TimeCostLabel
        {
            get { return TimeCosts.Text; }
            set { TimeCosts.Text = value;} 
            
        }

        public String MaterialCostLabel
        {
            get { return MaterialCosts.Text; }
            set { MaterialCosts.Text = value; }
        }
        public Material_Time_CostsControl1()
        {
            InitializeComponent();

          
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form1.tc += Form1.TC;
            Form1.mc += Form1.MC;

            foreach (CheckBox chk in Form1.checkboxs)
            {
                if (chk.Checked)
                {
                    chk.Checked = false;
                }
            }
           
            Form1.TC = 0;
            Form1.MC = 0;
            MaterialCosts.Text = "";
            TimeCosts.Text = "";

        }
    }
}
