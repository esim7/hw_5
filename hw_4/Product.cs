using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Product
    {
        public DataTable Products { get; set; }

        public Product()
        {
            Products = new DataTable("Products");
            DataColumn id = new DataColumn("id", typeof(int));
            id.Caption = "id";
            id.AllowDBNull = false;
            id.Unique = true;
            id.AutoIncrement = true;
            id.AutoIncrementSeed = 1;
            id.AutoIncrementStep = 1;

            DataColumn productName = new DataColumn("productName", typeof(string));
            productName.Caption = "productName";
            productName.AllowDBNull = false;
            productName.MaxLength = 50;

            DataColumn description = new DataColumn("description", typeof(string));
            description.Caption = "description";
            description.AllowDBNull = false;
            description.MaxLength = 50;

            Products.Columns.Add(id);
            Products.Columns.Add(productName);
            Products.Columns.Add(description);

            Products.PrimaryKey = new DataColumn[] { Products.Columns["id"] };
        }
    }
}
