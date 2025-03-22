using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Faculty
{
    class ReqCrud
    {
        public int request_id { get; set; }
        public int faculty_id { get; set; }
        public int item_id { get; set; }
        public int quantity { get; set; }
        public int status_id { get; set; }
        public string request_date { get; set; }

        public ReqCrud(int Request_id, int Faculty_id, int Item_id, int Quantity, int Status_id, string Request_date)
        {
            request_id = Request_id;
            faculty_id = Faculty_id;
            item_id = Item_id;
            quantity = Quantity;
            status_id = Status_id;
            request_date = Request_date;
        }

        public void AddRequest()
        {
            string query = $"INSERT INTO Faculty_requests (faculty_id, item_id, quantity, status_id, request_date) VALUES ({faculty_id}, {item_id}, {quantity}, {status_id}, '{request_date}')";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateRequest()
        {
            string query = $"UPDATE Faculty_requests SET faculty_id = {faculty_id}, item_id = {item_id}, quantity = {quantity}, status_id = {status_id}, request_date = '{request_date}' WHERE request_id = {request_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void DeleteRequest()
        {
            string query = $"DELETE FROM Faculty_requests WHERE request_id = {request_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
