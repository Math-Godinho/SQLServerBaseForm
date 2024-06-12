#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.ComponentModel;
using System.CodeDom;

namespace SQLDataForm.BaseModel
{
   class BaseClass
    {
        private static string _conS = @"Data Source = DESKTOP-LK6HI9G\SQLEXPRESS; Initial Catalog = ProductDB; Integrated Security = SSPI;";
        private static SqlDataAdapter _da;
        public static DataTable _dt;

        public static void TestConnection()

        {
            try
            {
                SqlConnection con = new(_conS);
                con.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Connection ERROR:{ex.Message}");
            }
        }
        public static void Initialize()
        {
            _da = new();
            _dt = new();
            _dt.Columns.Add("ProductName");
            _dt.Columns.Add("Price");
            _dt.Columns.Add("Supplier");

            using(SqlConnection con = new(_conS))
            {
                con.Open();
                _da.SelectCommand = new("SELECT * FROM PRODUCT", con);
                try
                {
                    _da.Fill(_dt);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show($"SQLERROR:{ex.Message}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"C# ERROR:{ex.Message}");
                }
            }
        }
        public static void Insert(string Name, float Price, string Supplier)
        {
            using(SqlConnection _con = new(_conS))
            {

                _con.Open();

                var row = _dt.NewRow();
                row["ProductName"] = Name;
                row["Price"] = Price;
                row["Supplier"] = Supplier;

                //Add the new row 'row' to the table
                _dt.Rows.Add(row);
                //
                _da.InsertCommand = new SqlCommand("INSERT INTO PRODUCT VALUES (@Name,@Price,@Supplier)",_con);
                _da.InsertCommand.Parameters.AddWithValue("@Name", Name);
                _da.InsertCommand.Parameters.AddWithValue("@Price", Price);
                _da.InsertCommand.Parameters.AddWithValue("@Supplier", Supplier);

                try
                {
                    
                    //Insert Data
                    _da.Update(_dt);
                    //
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SqlException:{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"C#Exception:{ex.Message}");
                }
            }
        }
        public static void Delete(string Name, float Price, string Supplier)
        {
            using (SqlConnection _con = new(_conS))
            {
                _con.Open();

                //Filter rows by the collection DataRow
                DataRow[] rows = _dt.Select($"ProductName='{Name}'");
                //

                //Delete all rows where ProductName match the Name parameter
                foreach (DataRow row in rows)
                    row.Delete();
                //

               
                //Delete PRODUCTS matching the Parameters
                _da.DeleteCommand = new SqlCommand("DELETE FROM PRODUCT WHERE ProductName=@Name AND Price = @Price AND Supplier=@Supplier", _con);
                _da.DeleteCommand.Parameters.AddWithValue("@Name", Name);
                _da.DeleteCommand.Parameters.AddWithValue("@Price", Price);
                _da.DeleteCommand.Parameters.AddWithValue("@Supplier", Supplier);
                //

                try
                {      
                    
                    //Insert Data
                    _da.Update(_dt);
                    //
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SqlException:{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"C#Exception:{ex.Message}");
                }
            }
        }
        public static void Update(string Name, float Price, string Supplier)
        {
            using (SqlConnection con = new(_conS))
            {
                con.Open();
                DataRow[] collection = _dt.Select($"ProductName='{Name}'");
                foreach(DataRow row in collection)
                {
                    row["Price"] = Price;
                    row["Supplier"] = Supplier;
                }



                _da.UpdateCommand = new("UPDATE PRODUCT SET Price=@Price,Supplier=@Supplier WHERE ProductName=@Name", con);
                _da.UpdateCommand.Parameters.AddWithValue("@Name", Name);
                _da.UpdateCommand.Parameters.AddWithValue("@Price", Price);
                _da.UpdateCommand.Parameters.AddWithValue("@Supplier", Supplier);
                try
                {

                    //Insert Data
                    _da.Update(_dt);
                    //
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SqlException:{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"C#Exception:{ex.Message}");
                }

            }
        }
        public static void Filter(string Name)
        {
            using(SqlConnection con = new(_conS))
            {
               
                con.Open();
                _da.SelectCommand = new("SELECT * FROM PRODUCT WHERE ProductName=@Name",con);
                _da.SelectCommand.Parameters.AddWithValue("@Name", Name);

                try
                {
                    SqlDataReader reader = _da.SelectCommand.ExecuteReader();
                    while (reader.Read())
                       
                    {
                     
                            string? name = reader["ProductName"].ToString();
                            string? price = reader["Price"].ToString();
                            string? supplier = reader["Supplier"].ToString();
                        MessageBox.Show($"ProductName:{name}\n Price:{price} \n Supplies:{supplier}");

                    }
                   
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SqlException:{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"C#Exception:{ex.Message}");
                }

            }
        }
    }
}
