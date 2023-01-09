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
    public partial class View_DeleteQuestionForm : Form
    {
        public View_DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void View_DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            cmbSet.Items.Clear();
            cmbSet.Items.Add("All Questions");
            DataSet ds = Connection.GetData("Select distinct qset from et_questions");
            for(int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                cmbSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSet.SelectedIndex != 0)
            {
                DataSet ds = Connection.GetData("Select id, qno, question, optionA, optionB, optionC, optionD, ans from et_questions where qset = '" + cmbSet.Text + "' ");
                DataGridQuestion.DataSource = ds.Tables[0];
            } 
            else
            {
                DataSet ds = Connection.GetData("Select id, qno, question, optionA, optionB, optionC, optionD, ans from et_questions");
                DataGridQuestion.DataSource = ds.Tables[0];
            }
        }

        int id, questionNo;

        

        private void DataGridQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(DataGridQuestion.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNo = int.Parse(DataGridQuestion.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch 
            {

            }
        }

        private void btnSync1_Click(object sender, EventArgs e)
        {
            View_DeleteQuestionForm_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?", "Delete Conformation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                DataSet ds = Connection.GetData("Delete from et_questions where id = '" + id + "' and qno = '" + questionNo + "' ");
                MessageBox.Show("Question Deleted");
                View_DeleteQuestionForm_Load(this,null); 
            }
        }
    }
} 
 