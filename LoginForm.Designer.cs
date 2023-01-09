
namespace Student_Project
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.lblForgotStudent = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.checkTeacherRem = new System.Windows.Forms.CheckBox();
            this.lblForgotTeach = new System.Windows.Forms.Label();
            this.lblCreateAccTeacher = new System.Windows.Forms.Label();
            this.btnTeacherClear = new System.Windows.Forms.Button();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkTeacher = new System.Windows.Forms.CheckBox();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 23);
            this.panel2.TabIndex = 98;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.checkRemember);
            this.panelStudent.Controls.Add(this.lblForgotStudent);
            this.panelStudent.Controls.Add(this.btnCreate);
            this.panelStudent.Controls.Add(this.btnClear);
            this.panelStudent.Controls.Add(this.txtPassword);
            this.panelStudent.Controls.Add(this.label3);
            this.panelStudent.Controls.Add(this.txtUsername);
            this.panelStudent.Controls.Add(this.label1);
            this.panelStudent.Controls.Add(this.label9);
            this.panelStudent.Controls.Add(this.checkShow);
            this.panelStudent.Controls.Add(this.btnLogin);
            this.panelStudent.Controls.Add(this.label2);
            this.panelStudent.Location = new System.Drawing.Point(26, 127);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(313, 537);
            this.panelStudent.TabIndex = 100;
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRemember.Location = new System.Drawing.Point(140, 324);
            this.checkRemember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(124, 23);
            this.checkRemember.TabIndex = 100;
            this.checkRemember.Text = "Remember me";
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // lblForgotStudent
            // 
            this.lblForgotStudent.AutoSize = true;
            this.lblForgotStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotStudent.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotStudent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblForgotStudent.Location = new System.Drawing.Point(151, 385);
            this.lblForgotStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotStudent.Name = "lblForgotStudent";
            this.lblForgotStudent.Size = new System.Drawing.Size(113, 17);
            this.lblForgotStudent.TabIndex = 102;
            this.lblForgotStudent.Text = "Forgot Password";
            this.lblForgotStudent.Click += new System.EventHandler(this.btnForgot_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCreate.Location = new System.Drawing.Point(102, 498);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 17);
            this.btnCreate.TabIndex = 104;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Firebrick;
            this.btnClear.Location = new System.Drawing.Point(43, 422);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(216, 35);
            this.btnClear.TabIndex = 103;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(55, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(59, 122);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "User Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 479);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 106;
            this.label9.Text = "Dont Have an Account";
            // 
            // checkShow
            // 
            this.checkShow.AutoSize = true;
            this.checkShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkShow.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShow.Location = new System.Drawing.Point(169, 205);
            this.checkShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkShow.Name = "checkShow";
            this.checkShow.Size = new System.Drawing.Size(104, 17);
            this.checkShow.TabIndex = 99;
            this.checkShow.Text = "Show Password";
            this.checkShow.UseVisualStyleBackColor = true;
            this.checkShow.CheckedChanged += new System.EventHandler(this.checkShow_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(43, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 35);
            this.btnLogin.TabIndex = 101;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(69, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 105;
            this.label2.Text = "Student Login";
            // 
            // cmbSelectUser
            // 
            this.cmbSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbSelectUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSelectUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSelectUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSelectUser.ForeColor = System.Drawing.Color.Black;
            this.cmbSelectUser.ItemHeight = 30;
            this.cmbSelectUser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbSelectUser.Location = new System.Drawing.Point(28, 74);
            this.cmbSelectUser.Name = "cmbSelectUser";
            this.cmbSelectUser.Size = new System.Drawing.Size(257, 36);
            this.cmbSelectUser.TabIndex = 101;
            this.cmbSelectUser.SelectedIndexChanged += new System.EventHandler(this.cmbSelectUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Select User Type";
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.checkTeacherRem);
            this.panelTeacher.Controls.Add(this.lblForgotTeach);
            this.panelTeacher.Controls.Add(this.lblCreateAccTeacher);
            this.panelTeacher.Controls.Add(this.btnTeacherClear);
            this.panelTeacher.Controls.Add(this.txtTeacherPassword);
            this.panelTeacher.Controls.Add(this.label7);
            this.panelTeacher.Controls.Add(this.txtTeacherName);
            this.panelTeacher.Controls.Add(this.label8);
            this.panelTeacher.Controls.Add(this.label10);
            this.panelTeacher.Controls.Add(this.checkTeacher);
            this.panelTeacher.Controls.Add(this.btnTeacherLogin);
            this.panelTeacher.Controls.Add(this.label11);
            this.panelTeacher.Location = new System.Drawing.Point(26, 127);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(313, 537);
            this.panelTeacher.TabIndex = 109;
            // 
            // checkTeacherRem
            // 
            this.checkTeacherRem.AutoSize = true;
            this.checkTeacherRem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTeacherRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTeacherRem.Location = new System.Drawing.Point(145, 298);
            this.checkTeacherRem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkTeacherRem.Name = "checkTeacherRem";
            this.checkTeacherRem.Size = new System.Drawing.Size(124, 23);
            this.checkTeacherRem.TabIndex = 112;
            this.checkTeacherRem.Text = "Remember me";
            this.checkTeacherRem.UseVisualStyleBackColor = true;
            // 
            // lblForgotTeach
            // 
            this.lblForgotTeach.AutoSize = true;
            this.lblForgotTeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotTeach.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotTeach.ForeColor = System.Drawing.Color.Firebrick;
            this.lblForgotTeach.Location = new System.Drawing.Point(157, 360);
            this.lblForgotTeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotTeach.Name = "lblForgotTeach";
            this.lblForgotTeach.Size = new System.Drawing.Size(113, 17);
            this.lblForgotTeach.TabIndex = 114;
            this.lblForgotTeach.Text = "Forgot Password";
            // 
            // lblCreateAccTeacher
            // 
            this.lblCreateAccTeacher.AutoSize = true;
            this.lblCreateAccTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAccTeacher.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccTeacher.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCreateAccTeacher.Location = new System.Drawing.Point(107, 468);
            this.lblCreateAccTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccTeacher.Name = "lblCreateAccTeacher";
            this.lblCreateAccTeacher.Size = new System.Drawing.Size(105, 17);
            this.lblCreateAccTeacher.TabIndex = 116;
            this.lblCreateAccTeacher.Text = "Create Account";
            // 
            // btnTeacherClear
            // 
            this.btnTeacherClear.BackColor = System.Drawing.Color.White;
            this.btnTeacherClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherClear.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherClear.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTeacherClear.Location = new System.Drawing.Point(51, 398);
            this.btnTeacherClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTeacherClear.Name = "btnTeacherClear";
            this.btnTeacherClear.Size = new System.Drawing.Size(216, 35);
            this.btnTeacherClear.TabIndex = 115;
            this.btnTeacherClear.Text = "CLEAR";
            this.btnTeacherClear.UseVisualStyleBackColor = false;
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherPassword.Location = new System.Drawing.Point(51, 182);
            this.txtTeacherPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeacherPassword.Multiline = true;
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.PasswordChar = '*';
            this.txtTeacherPassword.Size = new System.Drawing.Size(216, 28);
            this.txtTeacherPassword.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 119;
            this.label7.Text = "Password";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(49, 124);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeacherName.Multiline = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(216, 28);
            this.txtTeacherName.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 118;
            this.label8.Text = "User Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 451);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 117;
            this.label10.Text = "Dont Have an Account";
            // 
            // checkTeacher
            // 
            this.checkTeacher.AutoSize = true;
            this.checkTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTeacher.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTeacher.Location = new System.Drawing.Point(167, 208);
            this.checkTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkTeacher.Name = "checkTeacher";
            this.checkTeacher.Size = new System.Drawing.Size(104, 17);
            this.checkTeacher.TabIndex = 111;
            this.checkTeacher.Text = "Show Password";
            this.checkTeacher.UseVisualStyleBackColor = true;
            this.checkTeacher.CheckedChanged += new System.EventHandler(this.checkTeacher_CheckedChanged);
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnTeacherLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherLogin.FlatAppearance.BorderSize = 0;
            this.btnTeacherLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.ForeColor = System.Drawing.Color.White;
            this.btnTeacherLogin.Location = new System.Drawing.Point(51, 324);
            this.btnTeacherLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(216, 35);
            this.btnTeacherLogin.TabIndex = 113;
            this.btnTeacherLogin.Text = "LOGIN";
            this.btnTeacherLogin.UseVisualStyleBackColor = false;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(71, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 31);
            this.label11.TabIndex = 105;
            this.label11.Text = "Teacher Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(331, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 110;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.lblcross_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 23);
            this.panel1.TabIndex = 111;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSelectUser);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.CheckBox checkRemember;
        private System.Windows.Forms.Label lblForgotStudent;
        private System.Windows.Forms.Label btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSelectUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkTeacherRem;
        private System.Windows.Forms.Label lblForgotTeach;
        private System.Windows.Forms.Label lblCreateAccTeacher;
        private System.Windows.Forms.Button btnTeacherClear;
        private System.Windows.Forms.TextBox txtTeacherPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkTeacher;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}