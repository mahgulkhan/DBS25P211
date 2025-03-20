using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    class SemCrud
    {
        public int sem_id { get; set; }
        public string sem_term { get; set; }
        public int sem_year { get; set; }

        public SemCrud(int Sem_id, string Sem_term, int Sem_year)
        {
            sem_id = Sem_id;
            sem_term = Sem_term;
            sem_year = Sem_year;
        }
        
        public void AddSemester()
        {
            string query = $"INSERT INTO Semesters (sem_term, sem_year) VALUES ('{sem_term}', '{sem_year}')";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateSemester()
        {
            string query = $"UPDATE Semesters SET sem_term = '{sem_term}', sem_year = '{sem_year}' WHERE sem_id = {sem_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        public void DeleteSemester()
        {
            string query = $"DELETE FROM Semesters WHERE sem_id = {sem_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }

    }
}
