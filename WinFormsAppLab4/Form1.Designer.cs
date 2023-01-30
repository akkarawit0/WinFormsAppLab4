namespace WinFormsAppLab4
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GpaMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GpaNim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GpaAvg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NameMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NameNim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(209, 27);
            this.tbName.TabIndex = 0;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(94, 61);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(209, 27);
            this.tbBirthYear.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(150, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ปีเกิด";
            // 
            // texName
            // 
            this.texName.Location = new System.Drawing.Point(418, 189);
            this.texName.Multiline = true;
            this.texName.Name = "texName";
            this.texName.Size = new System.Drawing.Size(138, 189);
            this.texName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายชื่อ";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(418, 149);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(138, 27);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.Text = "0";
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "อายุรวม";
            // 
            // GPA
            // 
            this.GPA.Location = new System.Drawing.Point(94, 100);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(209, 27);
            this.GPA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "GPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "GPA Max";
            // 
            // GpaMax
            // 
            this.GpaMax.Location = new System.Drawing.Point(418, 25);
            this.GpaMax.Name = "GpaMax";
            this.GpaMax.Size = new System.Drawing.Size(138, 27);
            this.GpaMax.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "GPA Min";
            // 
            // GpaNim
            // 
            this.GpaNim.Location = new System.Drawing.Point(418, 58);
            this.GpaNim.Name = "GpaNim";
            this.GpaNim.Size = new System.Drawing.Size(138, 27);
            this.GpaNim.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "GPA Avg";
            // 
            // GpaAvg
            // 
            this.GpaAvg.Location = new System.Drawing.Point(418, 91);
            this.GpaAvg.Name = "GpaAvg";
            this.GpaAvg.Size = new System.Drawing.Size(138, 27);
            this.GpaAvg.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "ชื่อ";
            // 
            // NameMax
            // 
            this.NameMax.Location = new System.Drawing.Point(644, 28);
            this.NameMax.Name = "NameMax";
            this.NameMax.Size = new System.Drawing.Size(138, 27);
            this.NameMax.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(573, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "ชื่อ";
            // 
            // NameNim
            // 
            this.NameNim.Location = new System.Drawing.Point(644, 61);
            this.NameNim.Name = "NameNim";
            this.NameNim.Size = new System.Drawing.Size(138, 27);
            this.NameNim.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.GpaAvg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameNim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GpaNim);
            this.Controls.Add(this.NameMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GpaMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private TextBox tbBirthYear;
        private Button button1;
        private Label label1;
        private Label label2;
        public TextBox texName;
        public Label label3;
        private TextBox tbTotal;
        private Label label4;
        private TextBox GPA;
        private Label label5;
        private Label label6;
        private TextBox GpaMax;
        private Label label7;
        private TextBox GpaNim;
        private Label label8;
        private TextBox GpaAvg;
        private Label label9;
        private TextBox NameMax;
        private Label label10;
        private TextBox NameNim;
    }
}