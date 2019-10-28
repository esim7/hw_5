using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Order
    {
        public DataTable Orders { get; set; }

        public Order()
        {
            Orders = new DataTable("Orders");
            DataColumn id = new DataColumn("id", typeof(int));
            id.Caption = "id";
            id.AllowDBNull = false;
            id.Unique = true;
            id.AutoIncrement = true;
            id.AutoIncrementSeed = 1;
            id.AutoIncrementStep = 1;
            DataColumn orderDetailsId = new DataColumn("orderDetailsId", typeof(int))
            {
                Caption = "orderDetailsId",
                AllowDBNull = false,
            };
            Orders.Columns.Add(id);
            Orders.Columns.Add(orderDetailsId);
            Orders.PrimaryKey = new DataColumn[] { Orders.Columns["id"] };
        }
    }
}
