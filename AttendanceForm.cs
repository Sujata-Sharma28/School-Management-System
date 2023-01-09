using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;

namespace Student_Project
{
   
    public partial class AttendanceForm : BaseForm
    {
      
        public AttendanceForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Attendance;
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
           
        }

        protected override void SetControlProperty()
        {
            //For connect the database add class and show data in student class
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds1 = Connection.GetData("Select id, name as name from mst_student order by name");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                }
            }
            //For connect the database add class and show data in student class
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select id, concat(class, ' - ', section) as name from mst_class order by class");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbClass.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                }
            }
            cmbStatus.MaxLength = 10;
            cmbName.MaxLength = 30;
            cmbClass.MaxLength = 10;
        }
        protected override void InitEntry()
        {
            base.InitEntry();
            cmbStatus.Text = "";
            cmbName.Text = "";
            cmbClass.Text = "";
        }
        protected override object ControlToClass()
        {
            Attendance a = new Attendance();
            a.date = Convert.ToDateTime(dateTimePickerDate.Text.ToString());
            a.status = cmbStatus.Text;

            //a.name = cmbName.Text;
            ComboItem SelectedItem = cmbName.SelectedItem as ComboItem;
            if (SelectedItem != null)
            {
                a.studentID = Convert.ToInt32(SelectedItem.ID);
            }

            // a.class1 = cmbClass.Text;
            ComboItem SelectedItem1 = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem1 != null)
            {
                a.classID = Convert.ToInt32(SelectedItem1.ID);
            }
            return a;
        }
        protected override bool InputIsValid()
        {
             base.InputIsValid();
            Attendance a = objControlToClass as Attendance;

            if (a.studentID == 0)
            {
                MessageBox.Show("Student name cannot be left blank");
                cmbName.Focus();
                return false;
            }

            if (a.status == "")
            {
                MessageBox.Show("Status cannot be left blank");
                cmbStatus.Focus();
                return false;
            }
            return true;
        }
        protected override string SaveAsNew()
        {
            Attendance a = objControlToClass as Attendance;
            //return Connection.SetData("Insert into et_attendance(date, status, name, class1) values ('" + a.date.ToString("yyyy-MM-dd") + "','" + a.status + "', '" + a.name + "', '" + a.class1 + "') ");
            return Connection.SetData("Insert into et_attendance(date, status, student_id, class_id ) values ('" + a.date.ToString("yyyy-MM-dd") + "','" + a.status + "', '" + a.studentID + "', '" + a.classID + "') ");


        }

        protected override string Update()
        {
            Attendance a = objControlToClass as Attendance;
            //return Connection.SetData("Update et_attendance Set date = '" + a.date.ToString("yyyy-MM-dd") + "', status = '" + a.status + "', name = '" + a.name + "', class1 = '" + a.class1 + "' where id = " + FormId);
            return Connection.SetData("Update et_attendance Set date = '" + a.date.ToString("yyyy-MM-dd") + "', status = '" + a.status + "', student_id = '" + a.studentID + "', class_id = '" + a.classID + "' where id = " + FormId);

        }

        protected override void Display()
        {
            //DataSet ds = Connection.GetData("Select * from et_attendance where ID = " + FormId);
            DataSet ds = Connection.GetData("Select a.id, st.name, a.date, a.status, concat(c.class, ' - ', c.section) as class_name" +
                    " from et_attendance a " +
                    " left outer join mst_class c on c.id = a.class_id " +
                    " left outer join mst_student on st.id = a.student_id " +
                    " where a.id = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            dateTimePickerDate.Text = Convert.ToString(dr["date"]);
            cmbStatus.Text = Convert.ToString(dr["status"]);
            //cmbName.Text = Convert.ToString(dr["name"]);
            //cmbClass.Text = Convert.ToString(dr["class1"]);
            ControlUtility.SetComboItem(cmbName, Convert.ToString(dr["student_id"]));
            ControlUtility.SetComboItem(cmbClass, Convert.ToString(dr["class_id"]));

        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from et_attendance where id = " + FormId);
        }

        private void txtClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem == null)
            {
                return;
            }

            DataSet ds = Connection.GetData("Select name, id from mst_student where class_id = " + SelectedItem.ID);
            if (ds == null)
            {
                return;
            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
            }
        }
    }
}




