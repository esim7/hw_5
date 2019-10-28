using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-RM1NBDJ;Database=shop;Trusted_Connection=True;";

            DataSet shop = new DataSet();
            Order order = new Order();
            Customer customer = new Customer();
            Employee employee = new Employee();
            Product product = new Product();
            OrderDetail orderDetail = new OrderDetail();

            ForeignKeyConstraint OrderInOrderDetails = new ForeignKeyConstraint(orderDetail.OrderDetails.Columns["id"], order.Orders.Columns["orderDetailsId"]);
            ForeignKeyConstraint OrderDetailsInProduct = new ForeignKeyConstraint(product.Products.Columns["id"], orderDetail.OrderDetails.Columns["productId"]);
            ForeignKeyConstraint OrderDetailsInCustomers = new ForeignKeyConstraint(customer.Customers.Columns["id"], orderDetail.OrderDetails.Columns["customersId"]);
            ForeignKeyConstraint OrderDetailsInEmployees = new ForeignKeyConstraint(employee.Employees.Columns["id"], orderDetail.OrderDetails.Columns["employeesId"]);

            shop.Tables.Add(order.Orders);
            shop.Tables.Add(customer.Customers);
            shop.Tables.Add(employee.Employees);
            shop.Tables.Add(product.Products);
            shop.Tables.Add(orderDetail.OrderDetails);
        }
    }
}
