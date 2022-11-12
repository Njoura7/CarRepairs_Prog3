using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K1I95I
{
    public partial class Payment : Form
    {
      
        public Label lab1;
        public Payment()
        {
           
            InitializeComponent();
           
            //lab1 = M_costs;
            M_costs.Text = Form1.mc.ToString();
            S_Costs.Text = Form1.tc.ToString();
            Total.Text = (Form1.mc + Form1.tc).ToString();
        }

     
    }
}
