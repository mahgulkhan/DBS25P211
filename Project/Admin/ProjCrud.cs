using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    class ProjCrud
    {
        int project_id { get; set; }
        string title { get; set; }
        string description { get; set; }

        public ProjCrud(int Project_id, string Title, string Description)
        {
            project_id = Project_id;
            title = Title;
            description = Description;
        }

        public void AddProject()
        {
            string query = $"INSERT INTO Projects (title, description) VALUES ('{title}', '{description}')";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        
        public void UpdateProject()
        {
            string query = $"UPDATE Projects SET title = '{title}', description = '{description}' WHERE project_id = {project_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        public void DeleteProject()
        {
            string query = $"DELETE FROM Projects WHERE project_id = {project_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
