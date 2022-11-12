
namespace K1I95I
{
    partial class Material_Time_CostsControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.MaterialCosts = new System.Windows.Forms.Label();
            this.TimeCosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(646, 16);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(124, 50);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl1.Location = new System.Drawing.Point(3, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(128, 50);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Material Costs";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl2.Location = new System.Drawing.Point(331, 16);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(126, 50);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Time Costs";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaterialCosts
            // 
            this.MaterialCosts.BackColor = System.Drawing.Color.White;
            this.MaterialCosts.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaterialCosts.ForeColor = System.Drawing.Color.RosyBrown;
            this.MaterialCosts.Location = new System.Drawing.Point(137, 17);
            this.MaterialCosts.Name = "MaterialCosts";
            this.MaterialCosts.Size = new System.Drawing.Size(153, 50);
            this.MaterialCosts.TabIndex = 3;
            this.MaterialCosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeCosts
            // 
            this.TimeCosts.BackColor = System.Drawing.Color.White;
            this.TimeCosts.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeCosts.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TimeCosts.Location = new System.Drawing.Point(463, 17);
            this.TimeCosts.Name = "TimeCosts";
            this.TimeCosts.Size = new System.Drawing.Size(157, 49);
            this.TimeCosts.TabIndex = 4;
            this.TimeCosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Material_Time_CostsControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeCosts);
            this.Controls.Add(this.MaterialCosts);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Register);
            this.Name = "Material_Time_CostsControl1";
            this.Size = new System.Drawing.Size(782, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label MaterialCosts;
        private System.Windows.Forms.Label TimeCosts;
    }
}
