using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Creating by sir using for mdi for child connection Tricks
using System.Windows.Forms;

namespace Student_Project
{
    public enum MenuObject
    {
        None = 0,
        Student = 1,
        Class = 2,
        Teacher = 3,
        Library = 4,
        Fees = 5,
        Attendance = 6,
        Contact = 7,
        Report = 8,
        AddBook = 9,
    }
    internal enum ReportType
    {
        None,
        StudentReport,
        TeacherReport,
        FeesReport,
        AttendanceReport
    }

    internal class ReportFilter
    {
        internal DateTime from_date;
        internal DateTime to_date;
        internal string name_like;
    }

    internal static class GeneralFunction
    {
        internal static Form mdiForm = null;
    }

    internal class Student
    {
        //internal int id;
        internal DateTime reg_date;
        internal DateTime dob;
        internal String gender;
        internal String father_name;
        internal String fees;
        internal String address;
        internal String name;
        internal String mobile_no;
        internal string religion;
        internal int classID;
        internal String mother_name;
        internal String image;

    }
    internal class Teacher
    {
        internal DateTime dob;
        internal DateTime doj;
        internal String gender;
        internal String father_name;
        internal String qualification;
        internal String salary;
        internal String address;
        internal String name;
        internal String mobile_no;
        internal String subject;
        internal String mother_name;
        internal String image;
        // internal String age;
    }

    internal class ClassInfo
    {
        internal String class_name;
        internal String section_name;
    }
    internal class Attendance
    {
        internal DateTime date;
        internal String status;
        internal int studentID;
        internal int classID;
    }

    internal class Library
    {
        internal String title;
        internal String class1;
        internal DateTime issue_date;
        internal String name;
        internal String author;
        internal DateTime return_date;
    }

    internal class Fees
    {
        internal int studentID;
        internal DateTime date;
        internal int amount;
        internal int classID;
    }
    internal class AddBook
    {
        internal String title;
        internal String author;
    }
}
   


