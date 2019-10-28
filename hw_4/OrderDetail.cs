using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class OrderDetail
    {
        public DataTable OrderDetails { get; set; }

        public OrderDetail()
        {
            OrderDetails = new DataTable("OrderDetails");
            DataColumn id = new DataColumn("id", typeof(int));
            id.Caption = "id";
            id.AllowDBNull = false;
            id.Unique = true;
            id.AutoIncrement = true;
            id.AutoIncrementSeed = 1;
            id.AutoIncrementStep = 1;

            DataColumn orderPrice = new DataColumn("orderPrice", typeof(double))
            {
                Caption = "orderPrice",
                AllowDBNull = false
            };
            DataColumn orderDate = new DataColumn("orderDate", typeof(DateTime))
            {
                Caption = "orderDate",
                AllowDBNull = false
            };
            DataColumn productId = new DataColumn("productId", typeof(int))
            {
                Caption = "productId",
                AllowDBNull = false,
            };
            DataColumn customersId = new DataColumn("customersId", typeof(int))
            {
                Caption = "customersId",
                AllowDBNull = false,
            };
            DataColumn employeesId = new DataColumn("employeesId", typeof(int))
            {
                Caption = "employeesId",
                AllowDBNull = false,
            };

            OrderDetails.Columns.Add(id);
            OrderDetails.Columns.Add(orderPrice);
            OrderDetails.Columns.Add(orderDate);
            OrderDetails.Columns.Add(productId);
            OrderDetails.Columns.Add(customersId);
            OrderDetails.Columns.Add(employeesId);

            OrderDetails.PrimaryKey = new DataColumn[] { OrderDetails.Columns["id"] };
        }
    }
}
