using StudentManagementWinform.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StudentManagementWinform.Logic
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public bool StudentGender { get; set; }
        public string StudentGenderString
        {
            get
            {
                if (StudentGender)
                {
                    return "Nam";
                }else
                {
                    return "Nữ";
                }
            }
        }
        public DateTime StudentDOB { get; set; }
        public string StudentEmail { get; set; }
        public string StudentLogin { get; set; }
        public string StudentPassword { get; set; }
        public Student()
        {
        }

        public Student(string studentID, string studentName, bool studentGender, DateTime studentDOB, string studentEmail)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentGender = studentGender;
            StudentDOB = studentDOB;
            StudentEmail = studentEmail;
        }

        public Student(string studentID, string studentName, bool studentGender, DateTime studentDOB, string studentEmail, string studentLogin, string studentPassword)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentGender = studentGender;
            StudentDOB = studentDOB;
            StudentEmail = studentEmail;
            StudentLogin = studentLogin;
            StudentPassword = studentPassword;
        }
    }
    class StudentList
    {
        public static List<Student> GetStudentList()
        {
            List<Student> StdList = new List<Student>();
            DataTable stdt = StudentDAO.Instance.getAllStudent();
            foreach(DataRow dr in stdt.Rows)
            {
                StdList.Add(new Student(dr["StudentID"].ToString(), dr["StudentName"].ToString(), Convert.ToBoolean(dr["StudentGender"]),Convert.ToDateTime(dr["StudentDOB"]), dr["StudentEmail"].ToString()));
            }
            return StdList;
        }
    }
    class StudentListSearch
    {
        public static List<Student> GetStudentList(string StudentID)
        {
            List<Student> StdList = new List<Student>();
            DataTable stdt = StudentDAO.Instance.SearchStudent(StudentID);
            foreach (DataRow dr in stdt.Rows)
            {
                StdList.Add(new Student(dr["StudentID"].ToString(), dr["StudentName"].ToString(), Convert.ToBoolean(dr["StudentGender"]), Convert.ToDateTime(dr["StudentDOB"]), dr["StudentEmail"].ToString()));
            }
            return StdList;
        }
    }
    class SortByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }
    class SortByID : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StudentID.CompareTo(y.StudentID);
        }
    }
}
