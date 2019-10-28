using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Customer
    {
        public DataTable Customers { get; set; }

        public Customer()
        {
            Customers = new DataTable("Customers");
            DataColumn id = new DataColumn("id", typeof(int));
            id.Caption = "id";
            id.AllowDBNull = false;
            id.Unique = true;
            id.AutoIncrement = true;
            id.AutoIncrementSeed = 1;
            id.AutoIncrementStep = 1;
            DataColumn fullName = new DataColumn("fullName", typeof(string));
            fullName.Caption = "fullName";
            fullName.AllowDBNull = false;
            fullName.MaxLength = 50;

            DataColumn phoneNumber = new DataColumn("phoneNumber", typeof(string));
            phoneNumber.Caption = "phoneNumber";
            phoneNumber.AllowDBNull = false;
            phoneNumber.MaxLength = 50;

            Customers.Columns.Add(id);
            Customers.Columns.Add(fullName);
            Customers.Columns.Add(phoneNumber);

            Customers.PrimaryKey = new DataColumn[] { Customers.Columns["id"] };
        }
    }
}
