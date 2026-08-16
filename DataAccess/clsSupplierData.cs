using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.DataAccess
{
    public class clsSupplierData
    {
        public struct stSupplierInfo
        {
            public int SupplierID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public bool IsActive { get; set; }
        }
        public static int AddNewSupplier(stSupplierInfo supplierInfo)
        {
            int newSupplierID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Supplier (FirstName, LastName, Phone, Email, IsActive)
                                 VALUES (@FirstName, @LastName, @Phone, @Email, @IsActive);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(supplierInfo.FirstName) ? (object)DBNull.Value : supplierInfo.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(supplierInfo.LastName) ? (object)DBNull.Value : supplierInfo.LastName);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(supplierInfo.Phone) ? (object)DBNull.Value : supplierInfo.Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(supplierInfo.Email) ? (object)DBNull.Value : supplierInfo.Email);
                    command.Parameters.AddWithValue("@IsActive", supplierInfo.IsActive);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newSupplierID = insertedID;
                    }
                }
            }

            return newSupplierID;
        }
        public static bool IsPhoneExists(string phone, int excludeSupplierID = -1)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 1 FROM Supplier 
                         WHERE Phone = @Phone AND SupplierID <> @ExcludeSupplierID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@ExcludeSupplierID", excludeSupplierID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    isFound = (result != null);
                }
            }

            return isFound;
        }
        public static bool IsEmailExists(string email, int excludeSupplierID = -1)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 1 FROM Supplier 
                         WHERE Email = @Email AND SupplierID <> @ExcludeSupplierID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ExcludeSupplierID", excludeSupplierID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    isFound = (result != null);
                }
            }

            return isFound;
        }
        public static stSupplierInfo GetSupplierByEmail(string email)
        {
            stSupplierInfo supplierInfo = new stSupplierInfo();
            supplierInfo.SupplierID = -1; // القيمة الافتراضية للتدليل على عدم الوجود

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT SupplierID, FirstName, LastName, Phone, Email, IsActive 
                         FROM Supplier 
                         WHERE Email = @Email;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplierInfo.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                            supplierInfo.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
                            supplierInfo.LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
                            supplierInfo.Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : string.Empty;
                            supplierInfo.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                            supplierInfo.IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
            }

            return supplierInfo;
        }
        public static bool UpdateSupplierInfo(stSupplierInfo supplierInfo)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Supplier 
                         SET FirstName = @FirstName,
                             LastName = @LastName,
                             Phone = @Phone,
                             Email = @Email,
                             IsActive = @IsActive
                         WHERE SupplierID = @SupplierID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierInfo.SupplierID);
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(supplierInfo.FirstName) ? (object)DBNull.Value : supplierInfo.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(supplierInfo.LastName) ? (object)DBNull.Value : supplierInfo.LastName);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(supplierInfo.Phone) ? (object)DBNull.Value : supplierInfo.Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(supplierInfo.Email) ? (object)DBNull.Value : supplierInfo.Email);
                    command.Parameters.AddWithValue("@IsActive", supplierInfo.IsActive);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return (rowsAffected > 0);
        }
        public static List<string> GetAllEmails()
        {
            List<string> emailList = new List<string>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT Email FROM Supplier;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Email"] != DBNull.Value)
                            {
                                emailList.Add(reader["Email"].ToString());
                            }
                        }
                    }
                }
            }

            return emailList;
        }
        public static List<stSupplierInfo> GetAllSuppliers()
        {
            List<stSupplierInfo> suppliersList = new List<stSupplierInfo>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT SupplierID, FirstName, LastName, Phone, Email, IsActive FROM Supplier";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stSupplierInfo supplier = new stSupplierInfo
                            {
                                SupplierID = Convert.ToInt32(reader["SupplierID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };

                            suppliersList.Add(supplier);
                        }
                    }
                }
            }

            return suppliersList;
        }

        public static List<string> GetAllPhones()
        {
            List<string> phones = new List<string>();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Phone FROM Supplier ORDER BY CAST(Phone AS INT)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            phones.Add(reader["Phone"].ToString());
                        }
                    }
                }
            }

            return phones;
        }

        public static stSupplierInfo GetSupplierByPhone(string phone)
        {
            stSupplierInfo info = new stSupplierInfo();
            info.SupplierID = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Supplier WHERE Phone = @Phone";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            info.SupplierID = (int)reader["SupplierID"];
                            info.FirstName = reader["FirstName"].ToString();
                            info.LastName = reader["LastName"].ToString();
                            info.Phone = reader["Phone"].ToString();
                            info.Email = reader["Email"].ToString();
                            info.IsActive = (bool)reader["IsActive"];
                        }
                    }
                }
            }

            return info;
        }

    }
}