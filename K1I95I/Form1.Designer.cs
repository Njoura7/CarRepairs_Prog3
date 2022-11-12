
namespace K1I95I
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.Payment = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Worksheet = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.worksheetControl1 = new K1I95I.WorksheetControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcControl = new K1I95I.Material_Time_CostsControl1();
            this.aboutControl1 = new K1I95I.AboutControl();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sidePanel.Controls.Add(this.Payment);
            this.sidePanel.Controls.Add(this.About);
            this.sidePanel.Controls.Add(this.Worksheet);
            this.sidePanel.Controls.Add(this.LoadFile);
            this.sidePanel.Controls.Add(this.Home);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 734);
            this.sidePanel.TabIndex = 0;
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.Indigo;
            this.Payment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Payment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Payment.Location = new System.Drawing.Point(39, 448);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(172, 64);
            this.Payment.TabIndex = 4;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Indigo;
            this.About.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.About.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.About.Location = new System.Drawing.Point(39, 612);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(172, 64);
            this.About.TabIndex = 3;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Worksheet
            // 
            this.Worksheet.BackColor = System.Drawing.Color.Indigo;
            this.Worksheet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Worksheet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Worksheet.Location = new System.Drawing.Point(39, 329);
            this.Worksheet.Name = "Worksheet";
            this.Worksheet.Size = new System.Drawing.Size(172, 64);
            this.Worksheet.TabIndex = 2;
            this.Worksheet.Text = "Worksheet";
            this.Worksheet.UseVisualStyleBackColor = false;
            this.Worksheet.Click += new System.EventHandler(this.Worksheet_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.BackColor = System.Drawing.Color.Indigo;
            this.LoadFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoadFile.Location = new System.Drawing.Point(39, 210);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(172, 64);
            this.LoadFile.TabIndex = 1;
            this.LoadFile.Text = "Load File";
            this.LoadFile.UseVisualStyleBackColor = false;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Indigo;
            this.Home.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Home.Location = new System.Drawing.Point(39, 83);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(172, 64);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.IndianRed;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.Location = new System.Drawing.Point(1047, 670);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(172, 64);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // worksheetControl1
            // 
            this.worksheetControl1.AutoScroll = true;
            this.worksheetControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.worksheetControl1.Location = new System.Drawing.Point(278, 25);
            this.worksheetControl1.Name = "worksheetControl1";
            this.worksheetControl1.Size = new System.Drawing.Size(877, 585);
            this.worksheetControl1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 75);
            this.panel1.TabIndex = 8;
            // 
            // mtcControl
            // 
            this.mtcControl.Location = new System.Drawing.Point(263, 651);
            this.mtcControl.MaterialCostLabel = "";
            this.mtcControl.Name = "mtcControl";
            this.mtcControl.Size = new System.Drawing.Size(778, 83);
            this.mtcControl.TabIndex = 0;
            this.mtcControl.TimeCostLabel = "";
            // 
            // aboutControl1
            // 
            this.aboutControl1.Location = new System.Drawing.Point(256, 12);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(939, 622);
            this.aboutControl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 734);
            this.Controls.Add(this.aboutControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.worksheetControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mtcControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Worksheet;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
       
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private WorksheetControl worksheetControl1;
        private Material_Time_CostsControl1 material_Time_CostsControl11;
        private System.Windows.Forms.Panel panel1;
        private Material_Time_CostsControl1 mtcControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Payment;
        private AboutControl aboutControl1;
    }
}

