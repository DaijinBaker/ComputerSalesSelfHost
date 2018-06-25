using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace ComputerSalesSelfHost
{
    public class ComputerSalesController : ApiController
    {
        //getting brand names for frmMains list box
        public List<string> GetBrandNames()
        {
            DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT Name FROM tbl_brand", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        //Getting brand information to display for frmBrand
        public clsBrand GetBrand(string Name)
        {
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(1);
                par.Add("Name", Name);
                DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT * FROM tbl_brand WHERE Name = @Name", par);
                if (lcResult.Rows.Count > 0)
                    return new clsBrand()
                    {
                        Name = (string)lcResult.Rows[0]["Name"],
                        Type = (string)lcResult.Rows[0]["Type"],
                        ComputerList = GetBrandsComputers(Name)
                    };
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException());
                return null;
            }
        }

        //Getting all computers associated with the brand
        private List<clsAllComputers> GetBrandsComputers(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT * FROM tbl_computer WHERE BrandName = @Name", par);
            List<clsAllComputers> lcComputers = new List<clsAllComputers>();
            foreach (DataRow dr in lcResult.Rows)
                lcComputers.Add(dataRow2AllComputers(dr));
            return lcComputers;

        }

        //Converting data variables from sql data type to the c# data types
        private clsAllComputers dataRow2AllComputers(DataRow prDataRow)
        {
            return new clsAllComputers()
            {
                ComputerID = Convert.ToInt32(prDataRow["ComputerID"]),
                Name = Convert.ToString(prDataRow["Name"]),
                Price = Convert.ToDecimal(prDataRow["Price"]),
                LastModified = Convert.ToDateTime(prDataRow["LastModified"]),
                Quantity = Convert.ToInt32(prDataRow["Quantity"]),
                Type = Convert.ToChar(prDataRow["Type"]),
                Ram = Convert.ToString(prDataRow["Ram"]),
                HDD = Convert.ToString(prDataRow["HDD"]),
                Graphics = Convert.ToString(prDataRow["Graphics"]),
                Color = Convert.ToString(prDataRow["Color"]),
                TowerType = Convert.ToString(prDataRow["TowerType"]),
                BrandName = Convert.ToString(prDataRow["BrandName"])
            };
        }

        //Updating the database if any changes are done to a computer
        public string UpdateComputer(clsAllComputers prComputers)
        {
            try
            {
                int lcRecCount = clsDbConnectioncs.Execute("UPDATE tbl_computer SET " +
                    "Name = @Name, Price = @Price, LastModified = @LastModified, Quantity = @Quantity, Type = @Type, Ram = @Ram, " +
                    "HDD = @HDD, Graphics = @Graphics, Color = @Color, TowerType = @TowerType",
                    prepareComputerParameters(prComputers));
                if (lcRecCount == 1)
                    return "One Computer Updated";
                else
                    return "Unexepected Computer insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        //inserting a new computer into the database
        public string InsertComputer(clsAllComputers prComputers)
        {
            try
            {
                int lcRecCount = clsDbConnectioncs.Execute("INSERT INTO tbl_computer " +
                    "(Name, Price, LastModified, Quantity, Type, Ram, HDD, Graphics, Color, TowerType, BrandName)" +
                    "VALUES (@Name, @Price, @LastModified, @Quantity, @Type, @Ram, @HDD, @Graphics, @Color, @TowerType, @BrandName)", 
                    prepareComputerParameters(prComputers));
                if (lcRecCount == 1)
                    return "One Computer inserted";
                else
                    return "Unexepected Computer insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        
        private Dictionary<string, object> prepareComputerParameters(clsAllComputers prComputers)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(12);
            //par.Add("ComputerID", prComputers.ComputerID);
            par.Add("Name", prComputers.Name);
            par.Add("Price", prComputers.Price);
            par.Add("LastModified", prComputers.LastModified);
            par.Add("Quantity", prComputers.Quantity);
            par.Add("Type", prComputers.Type);
            par.Add("Ram", prComputers.Ram);
            par.Add("HDD", prComputers.HDD);
            par.Add("Graphics", prComputers.Graphics);
            par.Add("Color", prComputers.Color);
            par.Add("TowerType", prComputers.TowerType);
            par.Add("BrandName", prComputers.BrandName);

            return par;
        }

        public string InsertBrand(clsBrand prBrand)
        {
            try
            {
                int lcRecCount = clsDbConnectioncs.Execute(
                    "INSERT INTO tbl_brand (Name, Type) VALUES (@Name, @Type)",
                    prepareBrandParameters(prBrand));
                if (lcRecCount == 1)
                    return "One Brand Inserted";
                else
                    return "Unexpected artist count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteComputer(string ComputerName, string BrandName)
        {
            try
            {

                Dictionary<string, object> par = new Dictionary<string, object>(2);
                par.Add("Name", ComputerName);
                par.Add("BrandName", BrandName);
                int lcRecCount = clsDbConnectioncs.Execute(
                    "DELETE FROM tbl_computer WHERE Name=@Name AND BrandName=@BrandName", par);
                if (lcRecCount == 1)
                    return "One Computer deleted";
                else
                    return "Unexpected computer delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareBrandParameters(clsBrand prBrand)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(2);
            par.Add("Name", prBrand.Name);
            par.Add("Type", prBrand.Type);

            return par;
        }

        //Order 

        public List<string> GetOrderList()
        {
            DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT CustomerName FROM tbl_order", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsOrder GetOrder(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT * FROM tbl_order WHERE CustomerName = @Name", par);
            if (lcResult.Rows.Count > 0)
                return new clsOrder()
                {
                    CustomerName = (string)lcResult.Rows[0]["Name"],
                    OrderList = GetOrderDetails(Name)
                };
            else
                return null;
        }

        private List<clsOrder> GetOrderDetails(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult = clsDbConnectioncs.GetDataTable("SELECT * FROM tbl_Order WHERE CustomerName = @Name", par);
            List<clsOrder> lcOrder = new List<clsOrder>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrder.Add(DataRow2Orders(dr));
            return lcOrder;
        }

        private clsOrder DataRow2Orders(DataRow prDataRow)
        {
            return new clsOrder()
            {
                CustomerName = Convert.ToString(prDataRow["Name"]),
                CustomerPhone = Convert.ToString(prDataRow["Phone"]),
                CustomerAddress = Convert.ToString(prDataRow["Address"]),
                OrderID = Convert.ToInt32(prDataRow["OrderID"]),
                PriceAtOrder = Convert.ToDecimal(prDataRow["PriceAtOrder"]),
                OrderDateTime = Convert.ToDateTime(prDataRow["OrderDateTime"]),
                OrderQuantity = Convert.ToInt32(prDataRow["OrderQuantity"]),
                ComputerID = Convert.ToInt32(prDataRow["ComputerID"])
            };
        }

        public string InsertOrder(clsOrder prOrder)
        {
            try
            {
                int lcRecCount = clsDbConnectioncs.Execute("INSERT INTO tbl_order " +
                    "(CustomerName, PriceAtOrder, OrderDateTime, OrderQuantity, CustomerPhone, CustomerAddress, ComputerID)" +
                    "VALUES (@CustomerName, @PriceAtOrder, @OrderDateTime, @OrderQuantity, @CustomerPrice, @CustomerAddress, @ComputerID)",
                    prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                    return "One Order inserted";
                else
                    return "Unexepected Order insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(12);
            //par.Add("ComputerID", prComputers.ComputerID);
            par.Add("CustomerName", prOrder.CustomerName);
            par.Add("PriceAtOrder", prOrder.PriceAtOrder);
            par.Add("OrderDateTime", prOrder.OrderDateTime);
            par.Add("OrderQuantity", prOrder.OrderQuantity);
            par.Add("CustomerPhone", prOrder.CustomerPhone);
            par.Add("CustomerAddress", prOrder.CustomerAddress);
            par.Add("ComputerID", prOrder.ComputerID);
            return par;
        }
    }
}
