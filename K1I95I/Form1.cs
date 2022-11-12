using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace K1I95I
{
    public partial class Form1 : Form
    {
   

        private string filepath;
        //time cost counter
        public static int TC = 0;
        //materisl cost counter
        public static int MC = 0;
        //payment variables
        public  static int tc=0;
        public  static int mc=0;

        private static List<WorksheetData> data = new List<WorksheetData>();

        public Form1()
        {
            InitializeComponent();
            
            pictureBox1.BringToFront();

            filepath = "";
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            mtcControl.Hide();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
            }
            else
            {
                filepath = "";
            }

        }

        public List<Label> TimeLabels = new List<Label>();
        public List<Label> CostLabels = new List<Label>();
        public static List<CheckBox> checkboxs = new List<CheckBox>();
        private void Event_CheckedChange(object sender, EventArgs e)
        {
         
            var chk = sender as CheckBox;
            //converting the stings into integers to manipulate them
            int y = 0;
            Int32.TryParse(TimeLabels.ElementAt(checkboxs.IndexOf(chk)).Text, out y);

            int z = 0;
            Int32.TryParse(CostLabels.ElementAt(checkboxs.IndexOf(chk)).Text, out z);

            if (chk.Checked)
           {
                TimeLabels.ElementAt(checkboxs.IndexOf(chk)).Visible=true;

          
                TC +=y;
                MC += z;
               // mc += z;
                //tc += y;
            } else

            {
                TimeLabels.ElementAt(checkboxs.IndexOf(chk)).Visible = false;

   
                TC -=y;
                MC -= z;
                //mc -= z;
                //tc -= y;

            }
            mtcControl.TimeCostLabel = TC.ToString();
            mtcControl.MaterialCostLabel = MC.ToString();

         
 
        }
   

        private String Convert(String time)
        {
            String ResultTime = "";
            int mins = int.Parse(time);
            if (mins >= 60)
                ResultTime += (mins / 60).ToString() + " hr" + ((mins % 60).ToString()) + " mins";
            else ResultTime = time + "mins";

            return ResultTime;
        }
        private void Worksheet_Click(object sender, EventArgs e)
        {
           //  int i = 0;

            if (filepath == "")
            {
                MessageBox.Show("No file selected");
                return;
            }

           

            //load the lines to a list of strings
            List<string> lines = File.ReadAllLines(filepath).ToList();


            foreach (var line in lines)
            {
                //splitting each line to a list of strings
                string[] entries = line.Split(';');

                WorksheetData newData = new WorksheetData
                {
                    NameOfWork = entries[0],
                    Time = entries[1],
                    MaterialCosts = entries[2]

                };

                data.Add(newData);

                int Top_Work = 90, Top_Time = 90, Top_Cost = 90, Top_Check = 90, Top_Tcost = 90;

                foreach (var element in data)
                {
                    //create a label inside the WorksheetControl
                    Label workElement = new Label();
                    this.worksheetControl1.Controls.Add(workElement);

                    //label properties
                    workElement.Top = Top_Work;
                    workElement.Left = 4;

                    workElement.ForeColor = Color.White;
                    workElement.BackColor = Color.Chocolate;
                    workElement.Padding = new Padding(7);
                    workElement.AutoSize = true;
                    workElement.Text = element.NameOfWork;


                    Top_Work += 100;

                    //create a label inside the WorksheetControl
                    Label timeElement = new Label();
                    this.worksheetControl1.Controls.Add(timeElement);

                    //label properties
                    timeElement.Top = Top_Time;
                    timeElement.Left =475;

                    timeElement.ForeColor = Color.White;
                    timeElement.BackColor = Color.Chocolate;
                    timeElement.Padding = new Padding(7);
                    timeElement.AutoSize = true;
                    timeElement.Text = Convert(element.Time);
                


                    Top_Time += 100;

                    //create a label inside the WorksheetControl
                    Label costElement = new Label();
                    this.worksheetControl1.Controls.Add(costElement);

                    //label properties
                    costElement.Top = Top_Cost;
                    costElement.Left = 275;

                    costElement.ForeColor = Color.White;
                    costElement.BackColor = Color.LightSkyBlue;
                    costElement.Padding = new Padding(7);
                    costElement.AutoSize = true;
                    costElement.Text = element.MaterialCosts;


                    Top_Cost += 100;

                   




                    //create checkbox
                    CheckBox check = new CheckBox();
                    this.worksheetControl1.Controls.Add(check);
                    //checkbox properties
                    check.Width = 30;
                    check.Top =Top_Check;
                    check.Left = 620;
                   
                    

                    Top_Check += 100;
                    //add an event handler for the checkbox
                    check.CheckedChanged += new EventHandler (Event_CheckedChange);

                    //create a label inside the WorksheetControl
                    Label totalCostElement = new Label();
                    this.worksheetControl1.Controls.Add(totalCostElement);

                    int x = 0;
                    Int32.TryParse(element.Time, out x);
                    if (x < 30)
                    {
                        x = 30;
                    }


                    //label properties
                    totalCostElement.Top = Top_Tcost;
                    totalCostElement.Left = 700;

                    totalCostElement.ForeColor = Color.Black;
                    totalCostElement.BackColor = Color.LightSkyBlue;
                    totalCostElement.Padding = new Padding(15);
                    totalCostElement.AutoSize = true;
                     totalCostElement.Text = (x * 250).ToString();
          
                    totalCostElement.Visible = false ;

                

                    Top_Tcost += 100;

                    //assigning the values to the external lists

                    TimeLabels.Add(totalCostElement);
                    CostLabels.Add(costElement);
                    checkboxs.Add(check);

                }



            }
            aboutControl1.Hide();
            worksheetControl1.BringToFront();
            mtcControl.BringToFront();
            //material_Time_CostsControl11.
            

        } 


        private void About_Click(object sender, EventArgs e)
        {
            aboutControl1.Show();
            aboutControl1.BringToFront();
            //mtcControl.Hide();
            //worksheetControl1.Hide();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //verify that the user want to quit
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        private void Payment_Click(object sender, EventArgs e)
        {


            Payment form = new Payment();

            form.Show();

            //Payment.inst


        }
    }
}
