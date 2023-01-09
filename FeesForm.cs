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
    public partial class FeesForm : BaseForm
    {
        //DataRow dr;
        //private int FormID = 0;

        public FeesForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Fees;
        }
       
        protected override void SetControlProperty()
        {
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select id, concat(class, ' - ', section) as name from mst_class order by class");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbClass.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                    cmbClass.DisplayMember = "concat(class, ' - ', section)";
                    cmbClass.ValueMember = "id";
                }
            }
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds1 = Connection.GetData("Select id, name as name from mst_student order by name");
            //DataSet ds1 = Connection.GetData("Select class_id, name from mst_student where  " +
            //  " from mst_student st " +
            //  " left outer join mst_class c on c.id = st.class_id " +
            //  " order by st.class_id");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    //cmbName.Items.Add(dr["name"]);
                    cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                    cmbName.DisplayMember = "name";
                    cmbName.ValueMember = "class_id";
                }
            }
            cmbName.MaxLength = 10;
            txtAmount.MaxLength = 10;
            cmbClass.MaxLength = 10;
        }
        protected override void InitEntry()
        {
            base.InitEntry();
            dateTimePickerDate.Text = "";
            cmbName.Text = "";
            txtAmount.Text = "";
            cmbClass.Text = "";
        }
        protected override object ControlToClass()
        {
            Fees f = new Fees();
            f.date = Convert.ToDateTime(dateTimePickerDate.Text.ToString());

            //f.name = cmbName.Text;
            ComboItem SelectedItem = cmbName.SelectedItem as ComboItem;
            if (SelectedItem != null)
            {
                f.studentID = Convert.ToInt32(SelectedItem.ID);
            }
            f.amount = Convert.ToInt32(txtAmount.Text);

            //f.class1 = cmbClass.Text;
            ComboItem SelectedItem1 = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem1 != null)
            {
                f.classID = Convert.ToInt32(SelectedItem1.ID);
            }
            return f;
        }
        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Fees f = objControlToClass as Fees;
            if (f.studentID == 0)
            {
                MessageBox.Show("Student name cannot be left blank");
                cmbName.Focus();
                return false;
            }

            if (f.classID == 0)
            {
                MessageBox.Show("Class name cannot be left blank");
                cmbClass.Focus();
                return false;
            }
            return true;
        }
        protected override string SaveAsNew()
        {
            Fees f = objControlToClass as Fees;
            return Connection.SetData("Insert into et_fees(date, student_id, amount, class_id)" + "" +
                "values ('" + f.date.ToString("yyyy-MM-dd") + "','" + f.studentID + "', '" + f.amount + "', '" + f.classID + "') ");
        }
        protected override string Update()
        {
            Fees f = objControlToClass as Fees;
            return Connection.SetData("Update et_fees Set date = '" + f.date.ToString("yyyy-MM-dd") + "', student_id = '" + f.studentID + "', amount = '" + f.amount + "' , class_id = '" + f.classID + "' where id = " + FormId);
        }
        protected override void Display()
        {
            //DataSet ds = Connection.GetData("Select * from et_fees where id = " + FormId);
             DataSet ds = Connection.GetData("Select f.id, st.name, f.date, f.amount, concat(c.class, ' - ', c.section) as class_name" +
                    " from et_fees f " +
                    " left outer join mst_class c on c.id = f.class_id " +
                    " left outer join mst_student on st.id = f.student_id " +
                    " where f.id = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            dateTimePickerDate.Text = Convert.ToString(dr["date"]);
            txtAmount.Text = Convert.ToString(dr["amount"]);
            //cmbName.Text = Convert.ToString(dr["name"]);
            ControlUtility.SetComboItem(cmbName, Convert.ToString(dr["student_id"]));
            ControlUtility.SetComboItem(cmbClass, Convert.ToString(dr["class_id"]));
            //cmbClass.Text = Convert.ToString(dr["class1"]);
        }
        protected override string Delete()
        {
            return Connection.SetData("Delete from et_fees where id = " + FormId);
        }
        private void FeesForm_Load(object sender, EventArgs e)
        {
            //DataSet ds = Connection.GetData("Select Distinct.mst_class.id from mst_class inner join mst_teacher on mst_class.id");
            //DataTable dt = new DataTable();
            //ds.Fill(dt);
            //cmbClass.DataSource = "mst_student";
            //cmbClass.DisplayMember = "id";
        }
        //void BindCombo()
        //{
        //    DataSet ds = Connection.GetData("Select * from mst_class");
        //    DataTable data = new DataTable();
        //    dr = data.NewRow();
        //    //dr.ItemArray = new object[] { 0, "--Select Class--" };
        //    data.Rows.InsertAt(dr, 0);
        //    cmbClass.DisplayMember = "class";
        //    cmbClass.ValueMember = "id";
        //    cmbClass.DataSource = data;
        //}
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbName.SelectedValue.ToString() != null)
            //{
            //    int class_id = Convert.ToInt32(cmbClass.SelectedValue.ToString());
            //}
        }

        private void cmbClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if(SelectedItem == null)
            {
                return;
            }

            DataSet ds = Connection.GetData("Select name, id from mst_student where class_id = " + SelectedItem.ID);
            if(ds == null)
            {
                return;
            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
            }
        }

        /*private void btnGenerate1_Click(object sender, EventArgs e)
        {
           Fees_PrintForm frm = new Fees_PrintForm();
           if (cmbName.SelectedIndex == -1)
           {
                frm.S_Name = "";
           }
           else
           {
               frm.S_Name = cmbName.SelectedItem.ToString();
           }
   //frm.Name = cmbName.SelectedItem.ToString();
          if (cmbClass.SelectedIndex == -1)
          {
              frm.Class = "";
          }
          else
          {
             frm.Class = cmbClass.SelectedItem.ToString();
          }
             frm.Date1 = dateTimePickerDate.Text;
             frm.Amount = txtAmount.Text;
             frm.ShowDialog();
        }*/
    }
}