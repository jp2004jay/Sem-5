using AdminThemeBC.Models;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace AdminThemeBC.Areas.CoffeeShop.Controllers
{
    public class Helper
    {
        private string? _connectionString;
        SqlConnection connection;
        public Helper(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("ConnectionString");
            connection = new SqlConnection(_connectionString);
        }

        #region get all
        public DataTable GetAllThings(string storeProcedure)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storeProcedure;
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            connection.Close();
            return table;
        }
        #endregion

        #region fill dropdown
        public List<UserModel> GetUsers() 
        {
            List<UserModel> userList = new List<UserModel>();

            foreach (DataRow data in GetAllThings("SP_FindAllUsers").Rows)
            {
                UserModel userModel = new UserModel();
                userModel.UserID = Convert.ToInt32(data["UserID"]);
                userModel.UserName = data["UserName"].ToString();
                userList.Add(userModel);
            }
            return userList;
        }
        public List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();

            foreach (DataRow data in GetAllThings("SP_FindAllCustomers").Rows)
            {
                CustomerModel customerModel = new CustomerModel();
                customerModel.CustomerID = Convert.ToInt32(data["CustomerID"]);
                customerModel.CustomerName = data["CustomerName"].ToString();
                customerList.Add(customerModel);
            }
            return customerList;
        }
        public List<OrderModel> GetOrders()
        {
            List<OrderModel> orderList = new List<OrderModel>();

            foreach (DataRow data in GetAllThings("SP_FindAllOrders").Rows)
            {
                OrderModel orderModel = new OrderModel();
                orderModel.OrderID = Convert.ToInt32(data["OrderID"]);
                orderModel.OrderName = data["OrderName"].ToString();
                orderList.Add(orderModel);
            }
            return orderList;
        }
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> productList = new List<ProductModel>();

            foreach (DataRow data in GetAllThings("SP_FindAllProducts").Rows)
            {
                ProductModel productModel = new ProductModel();
                productModel.ProductID = Convert.ToInt32(data["ProductID"]);
                productModel.ProductName = data["ProductName"].ToString();
                productList.Add(productModel);
            }
            return productList;
        }
        #endregion

        #region delete
        public string DeleteItem(string procedureName, string itemIDName, int? itemIDValue)
        {
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedureName;
                command.Parameters.Add(itemIDName, SqlDbType.Int).Value = itemIDValue;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Ok";
        }
        #endregion

        #region get by id
        public DataTable GetByIDItem(string procedureName, string itemIDName, int? itemIDValue)
        { 
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Parameters.AddWithValue(itemIDName, itemIDValue);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            connection.Close();
            return table;
        }
        #endregion

        #region add edit
        public void AddEditBillHelper(BillModel bill)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (bill.BillID == 0)
            {
                command.CommandText = "SP_InsertBill";
            }
            else
            {
                command.CommandText = "SP_UpdateBill";
                command.Parameters.Add("@BillId", SqlDbType.Int).Value = bill.BillID;
            }

            command.Parameters.Add("@BillNumber", SqlDbType.VarChar).Value = bill.BillNumber;
            command.Parameters.Add("@BillDate", SqlDbType.DateTime).Value = bill.BillDate;
            command.Parameters.Add("@OrderId", SqlDbType.Int).Value = bill.OrderID;
            command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = bill.TotalAmount;
            command.Parameters.Add("@Discount", SqlDbType.Decimal).Value = (object)bill.Discount ?? DBNull.Value;
            command.Parameters.Add("@NetAmount", SqlDbType.Decimal).Value = bill.NetAmount;
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = bill.UserID;

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddEditCustomerHelper(CustomerModel customer)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (customer.CustomerID == 0)
            {
                command.CommandText = "SP_InsertCustomer";
            }
            else
            {
                command.CommandText = "SP_UpdateCustomer";
                command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customer.CustomerID;
            }

            command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customer.CustomerName;
            command.Parameters.Add("@HomeAddress", SqlDbType.VarChar).Value = customer.HomeAddress;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = customer.Email;
            command.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = customer.MobileNo;
            command.Parameters.Add("@GstNo", SqlDbType.VarChar).Value = customer.GSTNo;
            command.Parameters.Add("@CityName", SqlDbType.VarChar).Value = customer.CityName;
            command.Parameters.Add("@PinCode", SqlDbType.VarChar).Value = customer.PinCode;
            command.Parameters.Add("@NetAmount", SqlDbType.Decimal).Value = customer.NetAmount;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = customer.UserID;

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddEditOrderHelper(OrderModel order)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (order.OrderID == 0)
            {
                command.CommandText = "SP_InsertOrder";
            }
            else
            {
                command.CommandText = "SP_UpdateOrder";
                command.Parameters.Add("@OrderId", SqlDbType.Int).Value = order.OrderID;
            }

            command.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = order.OrderDate;
            command.Parameters.Add("@OrderName", SqlDbType.VarChar).Value = order.OrderName;
            command.Parameters.Add("@CustomerId", SqlDbType.Int).Value = order.CustomerID;
            command.Parameters.Add("@PaymentMode", SqlDbType.VarChar).Value = order.PaymentMode;
            command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = (object)order.TotalAmount ?? DBNull.Value;
            command.Parameters.Add("@ShippingAddress", SqlDbType.VarChar).Value = order.ShippingAddress;
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = order.UserID;

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddEditOrderDetailHelper(OrderDetailModel orderDetail)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (orderDetail.OrderDetailID == 0)
            {
                command.CommandText = "SP_InsertOrderDetail";
            }
            else
            {
                command.CommandText = "SP_UpdateOrderDetail";
                command.Parameters.Add("@OrderDetailId", SqlDbType.Int).Value = orderDetail.OrderDetailID;
            }

            command.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderDetail.OrderID;
            command.Parameters.Add("@ProductId", SqlDbType.Int).Value = orderDetail.ProductID;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = orderDetail.Quantity;
            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = orderDetail.Amount;
            command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = orderDetail.TotalAmount;
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = orderDetail.UserID;

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddEditProductHelper(ProductModel product)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (product.ProductID == 0)
            {
                command.CommandText = "SP_InsertProduct";
            }
            else
            {
                command.CommandText = "SP_UpdateProduct";
                command.Parameters.Add("@ProductID", SqlDbType.Int).Value = product.ProductID;
            }

            command.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = product.ProductName;
            command.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = product.ProductCode;
            command.Parameters.Add("@ProductPrice", SqlDbType.Decimal).Value = product.ProductPrice;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = product.Description;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = product.UserID;

            command.ExecuteNonQuery();
            connection.Close();
            return;
        }
        public void AddEditUserHelper(UserModel user)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            if (user.UserID == 0)
            {
                command.CommandText = "SP_InsertUser";
            }
            else
            {
                command.CommandText = "SP_UpdateUser";
                command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.UserID;
            }

            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user.UserName;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            command.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = user.MobileNo;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = user.Address;
            command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;

            command.ExecuteNonQuery();
            connection.Close();
        }
        #endregion
    }
}
