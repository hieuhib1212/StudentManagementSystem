using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StudentManagementWinform.DataAccess
{
    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }

        public Subject(string subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
        }

    }
    class SubjectList
    {
        public static List<Subject> GetSubjectList()
        {
            List<Subject> SubjectList = new List<Subject>();
            DataTable sublst = SubjectDAO.Instance.GetAllSubject();
            foreach (DataRow dr in sublst.Rows)
            {
                SubjectList.Add(new Subject(dr["SubjectID"].ToString(), dr["SubjectName"].ToString()));
            }
            return SubjectList;
        }
        public static List<Subject> GetSubjectListByStudentID(string StudentID)
        {
            List<Subject> SubjectList = new List<Subject>();
            DataTable sublst = SubjectDAO.Instance.GetSubjectByStudentID(StudentID);
            foreach (DataRow dr in sublst.Rows)
            {
                SubjectList.Add(new Subject(dr["SubjectID"].ToString(), dr["SubjectName"].ToString()));

            }
            return SubjectList;
        }
    }
    
}
