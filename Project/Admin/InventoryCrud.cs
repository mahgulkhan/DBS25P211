using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    class InventoryCrud
    {
        public int consumable_id { get; set; }
        public string consumable_name { get; set; }

        public InventoryCrud(int Consumable_id, string Consumable_name)
        {
            consumable_id = Consumable_id;
            consumable_name = Consumable_name;
        }
        public void AddConsumable()
        {
            string query = $"INSERT INTO Consumables (item_name) VALUES ('{consumable_name}')";
            var conn = DatabaseHelper.Instance.Update(query);
        }

        public void UpdateConsumable()
        {
            string query = $"UPDATE Consumables SET item_name = '{consumable_name}' WHERE consumable_id = {consumable_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
        public void DeleteConsumable()
        {
            string query = $"DELETE FROM Consumables WHERE consumable_id = {consumable_id}";
            var conn = DatabaseHelper.Instance.Update(query);
        }
    }
}
