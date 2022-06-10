using StudentManagementWinform.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StudentManagementWinform.Logic
{
    public class SubjectStatus
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int StatusNumber { get; set; }
        public string StatusString
        {
            get
            {
                if (StatusNumber == 0) return "In Progress";
                else if (StatusNumber == 1) return "Not Passed";
                else return "Passed";
            }
            set
            {
                StatusString = value;
            }
        }
        public string color
        {
            get
            {
                if (StatusNumber == 0) return "gray";
                else if (StatusNumber == 1) return "red";
                else return "green";
            }
            set
            {
                StatusString = value;
            }
        }

        public SubjectStatus(string subjectID, string studentID, int statusNumber)
        {
            SubjectID = subjectID;
            SubjectName = studentID;
            StatusNumber = statusNumber;
        }
    }
    public class SubjectStatusList
    {
        public static List<SubjectStatus> GetSubjectStatus(String StudentID)
        {
            List<SubjectStatus> StatusList = new List<SubjectStatus>();
            string query = "SELECT t.SubjectID, s.SubjectName, t.SubjectStatus FROM StudentSubjectStatus t INNER JOIN [Subject] s ON t.SubjectID = s.SubjectID \n" +
                "WHERE t.StudentID = '" + StudentID + "'";
            DataTable sublst = DAO.Instance.GetDataBySQL(query);
            foreach (DataRow dr in sublst.Rows)
            {
                StatusList.Add(new SubjectStatus(dr["SubjectID"].ToString(), dr["SubjectName"].ToString(), Convert.ToInt32(dr["SubjectStatus"])));
            }
            return StatusList;
        }
    }
}
