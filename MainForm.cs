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
    public partial class MainForm : Form
    {
        private bool isCollapsed;
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelExamSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelExamSubmenu.Visible == true)
            {
                panelExamSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            StudentForm frm = new StudentForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            ClassForm frm = new ClassForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            TeacherForm frm = new TeacherForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            AttendanceForm frm = new AttendanceForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnContact_Click_1(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            Contact_UsForm frm = new Contact_UsForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            FeesForm frm = new FeesForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();

 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            LibraryForm frm = new LibraryForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            ReportForm frm = new ReportForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            DashBoard frm = new DashBoard();
            frm.Show();

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            AddBookForm frm = new AddBookForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();

        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            showSubMenu(panelExamSubmenu);
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            Add_questionform frm = new Add_questionform();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
            hideSubMenu();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            UpdateQuestionform frm = new UpdateQuestionform();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
            hideSubMenu();
        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            View_DeleteQuestionForm frm = new View_DeleteQuestionForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            LoginForm frm = new LoginForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        /* private void btnLogin_Click(object sender, EventArgs e)
         {
             LoginForm frm = new LoginForm();
             frm.MdiParent = GeneralFunction.mdiForm;
             frm.Show();
         }*/
    }
}
