using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class TeacherForm : BaseForm
    {
        //private int FormId = 0;
        public TeacherForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Teacher;
        }

        protected override void SetControlProperty()
        {
            ////For connect the database add class and show data in student class
            //txtSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            //DataSet ds = Connection.GetData("Select concat(class, ' - ', section) as name from mst_class order by class");
            //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        txtSubject.Items.Add(dr["name"]);
            //    }
            //}

            txtFather.InputType = MyControls.ListSelection.TextInputType.String;
            txtQualification.InputType = MyControls.ListSelection.TextInputType.String;
            cmbGender.MaxLength = 20;
            txtAddress.MaxLength = 100;
            txtTeacherName.InputType = MyControls.ListSelection.TextInputType.String;
            txtMobile.InputType = MyControls.ListSelection.TextInputType.Phone;
            txtSubject.InputType = MyControls.ListSelection.TextInputType.String;
            txtMother.InputType = MyControls.ListSelection.TextInputType.String;
            txtSalary.InputType = MyControls.ListSelection.TextInputType.Numeric;
        }
        protected override void InitEntry()
        {
            base.InitEntry();
            dateTimePickerDOB.Text = "";
            dateTimePickerDOJ.Text = "";
            cmbGender.Text = "";
            txtFather.Text = "";
            txtAddress.Text = "";
            txtTeacherName.Text = "";
            txtMobile.Text = "";
            txtSubject.Text = "";
            txtMother.Text = "";
            txtQualification.Text = "";
            txtSalary.Text = "";
            pictureBoxTeacher.Tag = "";
        }
        protected override object ControlToClass()
        {
            Teacher t = new Teacher();
            t.dob = Convert.ToDateTime(dateTimePickerDOB.Text.ToString());
            t.doj = Convert.ToDateTime(dateTimePickerDOJ.Text.ToString());
            t.gender = cmbGender.Text;
            t.father_name = txtFather.Text;
            t.qualification = txtQualification.Text;
            t.address = txtAddress.Text;
            t.name = txtTeacherName.Text;
            t.mobile_no = txtMobile.Text;
            t.subject = txtSubject.Text;
            t.mother_name = txtMother.Text;
            t.salary = txtSalary.Text;
            t.image = Convert.ToString(pictureBoxTeacher.Tag).Replace("\\", "\\\\");



            return t;

        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Teacher t = objControlToClass as Teacher;

            if (t.name == "")
            {
                MessageBox.Show("Student name cannot be left blank");
                txtTeacherName.Focus();
                return false;
            }

            if (t.address == "")
            {
                MessageBox.Show("Address name cannot be left blank");
                txtAddress.Focus();
                return false;
            }
            if (t.subject == "")
            {
                MessageBox.Show("Class name cannot be left blank");
                txtSubject.Focus();
                return false;
            }

            return true;

        }

        protected override string SaveAsNew()
        {
            Teacher t = objControlToClass as Teacher;
            return Connection.SetData("Insert into mst_teacher(dob, doj, gender, qualification, father_name, salary , address, name, mobile_no, subject, mother_name, image)" +
           " values ('" + t.dob.ToString("yyyy-MM-dd") + "', '" + t.doj.ToString("yyyy-MM-dd") + "','" + t.gender + "', '" + t.qualification + "', '" + t.father_name + "', '" + t.salary + "', '" + t.address + "', '" + t.name + "',  '" + t.mobile_no + "', '" + t.subject + "', '" + t.mother_name + "' , '" + t.image + "' ) ");

        }

        protected override string Update()
        {
            Teacher t = objControlToClass as Teacher;
            return Connection.SetData("Update mst_teacher Set dob = '" + t.dob.ToString("yyyy-MM-dd") + "', doj = '" + t.doj.ToString("yyyy-MM-dd") + "', gender = '" + t.gender + "', qualification = '" + t.qualification + "', father_name = '" + t.father_name + "', salary = '" + t.salary + "', address = '" + t.address + "', name = '" + t.name + "', mobile_no = '" + t.mobile_no + "',  subject = '" + t.subject + "', mother_name = '" + t.mother_name + "', image = '" + t.image + "' where id = " + FormId);

        }

        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from mst_teacher where ID = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            

            DataRow dr = ds.Tables[0].Rows[0];
            //dateTimePickerDOB.Text = Convert.ToString(dr["dob"]);
            //dateTimePickerDOJ.Text = Convert.ToString(dr["doj"]);
            cmbGender.Text = Convert.ToString(dr["gender"]);
            txtFather.Text = Convert.ToString(dr["father_name"]);
            txtQualification.Text = Convert.ToString(dr["qualification"]);
            txtAddress.Text = Convert.ToString(dr["address"]);
            txtSalary.Text = Convert.ToString(dr["salary"]);
            txtTeacherName.Text = Convert.ToString(dr["name"]);
            txtMobile.Text = Convert.ToString(dr["mobile_No"]);
            txtSubject.Text = Convert.ToString(dr["subject"]);
            txtMother.Text = Convert.ToString(dr["mother_Name"]);
        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_Teacher where id = " + FormId);
        }

        private void TeacherForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTeacher.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBoxTeacher.Tag = openFileDialog1.FileName;
            }
        }
    }
    }

