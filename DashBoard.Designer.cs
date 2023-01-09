
namespace Student_Project
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTotalClass = new System.Windows.Forms.Label();
            this.lblTotalTeacher = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnbar = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnCandle = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb6 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb5 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFees = new System.Windows.Forms.Button();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.btnBooks = new System.Windows.Forms.Button();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalClass
            // 
            this.lblTotalClass.AutoSize = true;
            this.lblTotalClass.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTotalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClass.ForeColor = System.Drawing.Color.White;
            this.lblTotalClass.Location = new System.Drawing.Point(643, 176);
            this.lblTotalClass.Name = "lblTotalClass";
            this.lblTotalClass.Size = new System.Drawing.Size(18, 20);
            this.lblTotalClass.TabIndex = 18;
            this.lblTotalClass.Text = "0";
            // 
            // lblTotalTeacher
            // 
            this.lblTotalTeacher.AutoSize = true;
            this.lblTotalTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTeacher.ForeColor = System.Drawing.Color.White;
            this.lblTotalTeacher.Location = new System.Drawing.Point(419, 176);
            this.lblTotalTeacher.Name = "lblTotalTeacher";
            this.lblTotalTeacher.Size = new System.Drawing.Size(18, 20);
            this.lblTotalTeacher.TabIndex = 17;
            this.lblTotalTeacher.Text = "0";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.BackColor = System.Drawing.Color.Maroon;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(197, 176);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(18, 20);
            this.lblTotalStudents.TabIndex = 16;
            this.lblTotalStudents.Text = "0";
            this.lblTotalStudents.Click += new System.EventHandler(this.lblTotalStudents_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.Location = new System.Drawing.Point(459, 64);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(221, 137);
            this.btnClass.TabIndex = 15;
            this.btnClass.Text = "Class";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClass.UseVisualStyleBackColor = false;
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.Location = new System.Drawing.Point(233, 64);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(221, 137);
            this.btnTeacher.TabIndex = 14;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTeacher.UseVisualStyleBackColor = false;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Maroon;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.Location = new System.Drawing.Point(8, 64);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(221, 137);
            this.btnStudent.TabIndex = 13;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 738);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1223, 30);
            this.panel4.TabIndex = 12;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1223, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 734);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 34);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 704);
            this.panel2.TabIndex = 19;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 207);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Fees";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(445, 273);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Fees Chart";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnbar
            // 
            this.btnbar.Location = new System.Drawing.Point(473, 246);
            this.btnbar.Name = "btnbar";
            this.btnbar.Size = new System.Drawing.Size(75, 23);
            this.btnbar.TabIndex = 21;
            this.btnbar.Text = "Bar";
            this.btnbar.UseVisualStyleBackColor = true;
            this.btnbar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(473, 275);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 22;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(473, 304);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(75, 23);
            this.btnPie.TabIndex = 23;
            this.btnPie.Text = "Pie";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnCandle
            // 
            this.btnCandle.Location = new System.Drawing.Point(473, 333);
            this.btnCandle.Name = "btnCandle";
            this.btnCandle.Size = new System.Drawing.Size(75, 23);
            this.btnCandle.TabIndex = 24;
            this.btnCandle.Text = "Candle";
            this.btnCandle.UseVisualStyleBackColor = true;
            this.btnCandle.Click += new System.EventHandler(this.btnCandle_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(473, 362);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 25;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(567, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrevious.Location = new System.Drawing.Point(577, 333);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 45);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(1091, 349);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 45);
            this.btnNext.TabIndex = 28;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cb6);
            this.panel5.Controls.Add(this.cb5);
            this.panel5.Controls.Add(this.cb4);
            this.panel5.Controls.Add(this.cb3);
            this.panel5.Controls.Add(this.cb2);
            this.panel5.Controls.Add(this.cb1);
            this.panel5.Location = new System.Drawing.Point(796, 466);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 26);
            this.panel5.TabIndex = 29;
            // 
            // cb6
            // 
            this.cb6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb6.CheckedState.BorderThickness = 0;
            this.cb6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb6.Location = new System.Drawing.Point(109, 4);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(15, 15);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "guna2CustomRadioButton6";
            this.cb6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb6.UncheckedState.BorderThickness = 2;
            this.cb6.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb6.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb5
            // 
            this.cb5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.BorderThickness = 0;
            this.cb5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb5.Location = new System.Drawing.Point(88, 4);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(15, 15);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "guna2CustomRadioButton5";
            this.cb5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb5.UncheckedState.BorderThickness = 2;
            this.cb5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb4
            // 
            this.cb4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.BorderThickness = 0;
            this.cb4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb4.Location = new System.Drawing.Point(67, 4);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(15, 15);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "guna2CustomRadioButton4";
            this.cb4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb4.UncheckedState.BorderThickness = 2;
            this.cb4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb3
            // 
            this.cb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.BorderThickness = 0;
            this.cb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb3.Location = new System.Drawing.Point(46, 4);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 15);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "guna2CustomRadioButton3";
            this.cb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb3.UncheckedState.BorderThickness = 2;
            this.cb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb2
            // 
            this.cb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.BorderThickness = 0;
            this.cb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb2.Location = new System.Drawing.Point(25, 4);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 15);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "guna2CustomRadioButton2";
            this.cb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb2.UncheckedState.BorderThickness = 2;
            this.cb2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb1
            // 
            this.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.BorderThickness = 0;
            this.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb1.Location = new System.Drawing.Point(4, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 15);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "guna2CustomRadioButton1";
            this.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb1.UncheckedState.BorderThickness = 2;
            this.cb1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFees
            // 
            this.btnFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFees.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFees.ForeColor = System.Drawing.Color.White;
            this.btnFees.Image = ((System.Drawing.Image)(resources.GetObject("btnFees.Image")));
            this.btnFees.Location = new System.Drawing.Point(685, 64);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(221, 137);
            this.btnFees.TabIndex = 30;
            this.btnFees.Text = "Fees";
            this.btnFees.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFees.UseVisualStyleBackColor = false;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.White;
            this.lblTotalFees.Location = new System.Drawing.Point(872, 176);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(18, 20);
            this.lblTotalFees.TabIndex = 31;
            this.lblTotalFees.Text = "0";
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.Location = new System.Drawing.Point(911, 64);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(221, 137);
            this.btnBooks.TabIndex = 32;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooks.ForeColor = System.Drawing.Color.White;
            this.lblTotalBooks.Location = new System.Drawing.Point(1099, 176);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(18, 20);
            this.lblTotalBooks.TabIndex = 33;
            this.lblTotalBooks.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DASHBOARD";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblTotalBooks);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.btnFees);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnCandle);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnbar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotalClass);
            this.Controls.Add(this.lblTotalTeacher);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(1228, 768);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalClass;
        private System.Windows.Forms.Label lblTotalTeacher;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnbar;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnCandle;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb6;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Label label2;
    }
}
