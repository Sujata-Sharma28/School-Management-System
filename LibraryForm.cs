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
    public partial class LibraryForm : BaseForm
    {
        //private int FormID = 0;
        public LibraryForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Library;
        }
        protected override void SetControlProperty()
        {
            txtName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds1 = Connection.GetData("Select name as name from mst_student order by name");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    txtName.Items.Add(dr["name"]);
                }
            }

            //For connect the database add class and show data in student class
            txtClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select concat(class, '-', section) as name from mst_class order by id");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    txtClass.Items.Add(dr["name"]);
                }
            }

            //For connect the database add class and show data in student class
            txtName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds2 = Connection.GetData("Select title as name from mst_addbook order by id");
            if (ds2 != null && ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds2.Tables[0].Rows)
                {
                    txtTitle.Items.Add(dr["name"]);
                }
            }

            //For connect the database add class and show data in student class
            txtClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds3 = Connection.GetData("Select author as name from mst_addbook order by author");
            if (ds3 != null && ds.Tables.Count > 0 && ds3.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds3.Tables[0].Rows)
                {
                    txtAuthor.Items.Add(dr["name"]);
                }
            }
            txtTitle.MaxLength = 20;
            txtClass.MaxLength = 10;
            txtName.MaxLength = 10;
            txtAuthor.MaxLength = 40;

        }

        protected override void InitEntry()
        {
            dateTimePickerBooks.Text = "";
            txtName.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";

            dateTimeReturn.Text = "";
            txtClass.Text = "";
        }

        protected override object ControlToClass()
        {
            Library b = new Library();

            b.title = txtTitle.Text;
            b.class1 = txtClass.Text;
            b.issue_date = Convert.ToDateTime(dateTimePickerBooks.Text);
            b.name = txtName.Text;
            b.author = txtAuthor.Text;

            b.return_date = Convert.ToDateTime(dateTimeReturn.Text);
            return b;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Library b = objControlToClass as Library;
            if (b.title == "")
            {
                MessageBox.Show("Title name cannot be left blank");
                txtTitle.Focus();
                return false;
            }
            if (b.class1 == "")
            {
                MessageBox.Show("Class name cannot be left blank");
                txtClass.Focus();
                return false;
            }
            if (b.name == "")
            {
                MessageBox.Show("Student name cannot be left blank");
                txtName.Focus();
                return false;
            }

            return true;
        }

        protected override string SaveAsNew()
        {
            Library b = objControlToClass as Library;
            return Connection.SetData("Insert into et_library(title, class1, issue_date, name, author, return_date )" + "" +
                    " values ('" + b.title + "', '" + b.class1 + "','" + b.issue_date.ToString("yyyy-MM-dd") + "','" + b.name + "', '" + b.author + "','" + b.return_date.ToString("yyyy-MM-dd") + "') ");
        }

        protected override string Update()
        {
             Library b = objControlToClass as Library;
            return Connection.SetData("Update et_library Set title = '" + b.title + "', class1 = '" + b.class1 + "', issue_date = '" + b.issue_date.ToString("yyyy-MM-dd") + "', name = '" + b.name + "', author = '" + b.author + "' , return_date = '" + b.return_date.ToString("yyyy-MM-dd") + "' where id = " + FormId);
        }

        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from et_library where ID = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            txtTitle.Text = Convert.ToString(dr["title"]);
            txtClass.Text = Convert.ToString(dr["class1"]);
            dateTimePickerBooks.Text = Convert.ToString(dr["issue_date"]);
            txtName.Text = Convert.ToString(dr["name"]);
            txtAuthor.Text = Convert.ToString(dr["author"]);
            dateTimeReturn.Text = Convert.ToString(dr["return_date"]);
        }
        protected override string Delete()
        {
            return Connection.SetData("Delete from et_library where id = " + FormId);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}