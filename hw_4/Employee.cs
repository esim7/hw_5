using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Employee
    {
        public DataTable Employees { get; set; }

        public Employee()
        {
            Employees = new DataTable("Employees");
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

            DataColumn position = new DataColumn("position", typeof(string));
            position.Caption = "position";
            position.AllowDBNull = false;
            position.MaxLength = 50;

            Employees.Columns.Add(id);
            Employees.Columns.Add(fullName);
            Employees.Columns.Add(position);

            Employees.PrimaryKey = new DataColumn[] { Employees.Columns["id"] };
        }

    }
}
