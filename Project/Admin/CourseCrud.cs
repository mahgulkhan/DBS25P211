using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    class CourseCrud
    {
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string course_type{ get; set;}
        public int credit_hours { get; set; }
        public int contact_hours { get; set; }

        public CourseCrud(int Course_id,string Course_name, string Course_type, int Credit_hours, int Contact_hours)
        {
            course_id = Course_id;
            course_name = Course_name;
            course_type = Course_type;
            credit_hours = Credit_hours;
            contact_hours = Contact_hours;
        }
        public void AddCourrse()
        {
            string query = $"INSERT INTO Courses (Course_name, Course_type, Credit_hours, Contact_hours) VALUES ('{course_name}', '{course_type}', {credit_hours}, {contact_hours})";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        
        public void UpdateCourrse() 
        { 
            string query = $"UPDATE Courses SET Course_name = '{course_name}', Course_type = '{course_type}', Credit_hours = {credit_hours}, Contact_hours = {contact_hours} WHERE Course_id = '{course_id}'";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void DeleteCourrse() 
        {
            string query = $"DELETE FROM Courses WHERE Course_id = '{course_id}'";
            var conn = DatabaseHelper.Instance.Update(query); 
        }

    }
}
