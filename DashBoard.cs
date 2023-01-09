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
    public partial class DashBoard : UserControl
    {
        internal int FormId = 0;
        public DashBoard()
        {
            InitializeComponent();
        }
        private int ImageNumber = 1;
        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber > 6)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"D:\Align Books Project\Student_Project\Images\" + ImageNumber + ".jpg ");
            LoadChecked();
        }
        private void LoadPreviousImages()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 6;
            }
            pictureBox1.ImageLocation = string.Format(@"D:\Align Books Project\Student_Project\Images\" + ImageNumber + ".jpg ");
            LoadChecked();
        }
        private void LoadChecked()
        {
            if (ImageNumber == 1) { cb1.Checked = true; }
            else if (ImageNumber == 2) { cb2.Checked = true; }
            else if (ImageNumber == 3) { cb3.Checked = true; }
            else if (ImageNumber == 4) { cb4.Checked = true; }
            else if (ImageNumber == 5) { cb5.Checked = true; }
            else if (ImageNumber == 6) { cb6.Checked = true; }
        }
        private void ChangedCheck()
        {
            timer1.Start();
            if (cb1.Checked == true) { ImageNumber = 1; }
            else if (cb2.Checked == true) { ImageNumber = 2; }
            else if (cb3.Checked == true) { ImageNumber = 3; }
            else if (cb4.Checked == true) { ImageNumber = 4; }
            else if (cb5.Checked == true) { ImageNumber = 5; }
            else if (cb6.Checked == true) { ImageNumber = 6; }
            pictureBox1.ImageLocation = string.Format(@"D:\Align Books Project\Student_Project\Images\" + ImageNumber + ".jpg ");
        }


        private void lblTotalStudents_Click(object sender, EventArgs e)
        {
            //DataSet ds = Connection.GetData("Select count(*) from mst_student where id = " + FormId);
            //DataSet ds = Connection.GetData("Select count(*) from mst_student group by id");
            //lblTotalStudents = ExecuteScaler();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
        
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            cb1.Checked = true;
            pictureBox1.ImageLocation = string.Format(@"D:\Align Books Project\Student_Project\Images\" + ImageNumber + ".jpg ");

            FillChart();
            DataSet ds = Connection.GetData("Select Count(*) from mst_student");
            Int32 rows_count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            lblTotalStudents.Text = rows_count.ToString();

            DataSet ds1 = Connection.GetData("Select Count(*) from mst_teacher");
            Int32 rows_count1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);
            lblTotalTeacher.Text = rows_count1.ToString();

            DataSet ds2 = Connection.GetData("Select Count(*) from mst_class");
            Int32 rows_count2 = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
            lblTotalClass.Text = rows_count2.ToString();

            DataSet ds3 = Connection.GetData("Select Count(*) from et_fees");
            Int32 rows_count3 = Convert.ToInt32(ds3.Tables[0].Rows[0][0]);
            lblTotalFees.Text = rows_count3.ToString();

            DataSet ds4 = Connection.GetData("Select Count(*) from et_library");
            Int32 rows_count4 = Convert.ToInt32(ds4.Tables[0].Rows[0][0]);
            lblTotalBooks.Text = rows_count4.ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void FillChart()
        {
            DataSet ds = Connection.GetData("select fees_month,fees_amount from fees_graph");
            chart1.DataSource = ds;
            chart1.Series["Fees"].XValueMember = "fees_month";
            chart1.Series["Fees"].YValueMembers = "fees_amount";
            chart1.Titles.Add("fees_graph");
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            chart1.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            chart1.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            chart1.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btnCandle_Click(object sender, EventArgs e)
        {
            chart1.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            chart1.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImages();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImages();
        }
    }
}
