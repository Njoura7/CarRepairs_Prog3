
namespace K1I95I
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.M_costs = new System.Windows.Forms.Label();
            this.S_Costs = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Costs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(73, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Costs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(73, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_costs
            // 
            this.M_costs.Location = new System.Drawing.Point(256, 91);
            this.M_costs.Name = "M_costs";
            this.M_costs.Size = new System.Drawing.Size(132, 56);
            this.M_costs.TabIndex = 3;
            this.M_costs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // S_Costs
            // 
            this.S_Costs.Location = new System.Drawing.Point(262, 174);
            this.S_Costs.Name = "S_Costs";
            this.S_Costs.Size = new System.Drawing.Size(132, 56);
            this.S_Costs.TabIndex = 4;
            this.S_Costs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(256, 285);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(132, 56);
            this.Total.TabIndex = 5;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 405);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.S_Costs);
            this.Controls.Add(this.M_costs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label M_costs;
        private System.Windows.Forms.Label S_Costs;
        private System.Windows.Forms.Label Total;
    }
}