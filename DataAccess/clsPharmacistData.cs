using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static PharmacyApp.DataAccess.clsPharmacistData;

namespace PharmacyApp.DataAccess
{
    public static class clsPharmacistData
    {
        public static bool CheckLogin(string username, string password)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT PharmacistID FROM Pharmacist WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    isFound = (result != null);
                }
            }

            return isFound;
        }

        public struct stPharmacistInfo
        {
            public int PharmacistID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public bool IsActive { get; set; }
        }
        public static int AddNewPharmacist(stPharmacistInfo pharmacistInfo)
        {
            int pharmacistID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Pharmacist (FirstName, LastName, Username, Password, Phone, Email, IsActive)
                         VALUES (@FirstName, @LastName, @Username, @Password, @Phone, @Email, @IsActive);
                         SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(pharmacistInfo.FirstName) ? (object)DBNull.Value : pharmacistInfo.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(pharmacistInfo.LastName) ? (object)DBNull.Value : pharmacistInfo.LastName);
                    command.Parameters.AddWithValue("@Username", pharmacistInfo.Username);
                    command.Parameters.AddWithValue("@Password", pharmacistInfo.Password);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(pharmacistInfo.Phone) ? (object)DBNull.Value : pharmacistInfo.Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(pharmacistInfo.Email) ? (object)DBNull.Value : pharmacistInfo.Email);

                    // إضافة الباراميتر IsActive
                    command.Parameters.AddWithValue("@IsActive", pharmacistInfo.IsActive);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        pharmacistID = insertedID;
                    }
                }
            }

            return pharmacistID;
        }
        public static bool IsUsernameExists(string username, int excludePharmacistID = -1)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Found = 1 FROM Pharmacist WHERE Username = @username AND PharmacistID <> @excludePharmacistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@excludePharmacistID", excludePharmacistID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result != null);
                }
            }
        }
        public static bool IsPhoneExists(string phone, int excludePharmacistID = -1)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Found = 1 FROM Pharmacist WHERE Phone = @phone AND PharmacistID <> @excludePharmacistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@excludePharmacistID", excludePharmacistID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result != null);
                }
            }
        }
        public static bool IsEmailExists(string email, int excludePharmacistID = -1)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Found = 1 FROM Pharmacist WHERE Email = @email AND PharmacistID <> @excludePharmacistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@excludePharmacistID", excludePharmacistID);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result != null);
                }
            }
        }
        public static List<string> GetAllUsernames()
        {
            List<string> usernamesList = new List<string>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Username FROM Pharmacist ORDER BY Username ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usernamesList.Add(reader["Username"].ToString());
                        }
                    }
                }
            }

            return usernamesList;
        }
        public static stPharmacistInfo GetPharmacistByUsername(string username)
        {
            stPharmacistInfo pharmacistInfo = new stPharmacistInfo
            {
                PharmacistID = -1,
                FirstName = "",
                LastName = "",
                Username = "",
                Password = "",
                Phone = "",
                Email = "",
                IsActive = false
            };

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Pharmacist WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pharmacistInfo.PharmacistID = (int)reader["PharmacistID"];
                            pharmacistInfo.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : "";
                            pharmacistInfo.LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : "";
                            pharmacistInfo.Username = reader["Username"].ToString();
                            pharmacistInfo.Password = reader["Password"].ToString();
                            pharmacistInfo.Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : "";
                            pharmacistInfo.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";

                            // قراءة قيمة العمود IsActive
                            pharmacistInfo.IsActive = (bool)reader["IsActive"];
                        }
                    }
                }
            }

            return pharmacistInfo;
        }
        public static bool UpdatePharmacistInfo(stPharmacistInfo pharmacistInfo)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Pharmacist
                         SET FirstName = @FirstName,
                             LastName = @LastName,
                             Username = @Username,
                             Password = @Password,
                             Phone = @Phone,
                             Email = @Email,
                             IsActive = @IsActive
                         WHERE PharmacistID = @PharmacistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PharmacistID", pharmacistInfo.PharmacistID);
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(pharmacistInfo.FirstName) ? (object)DBNull.Value : pharmacistInfo.FirstName);
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(pharmacistInfo.LastName) ? (object)DBNull.Value : pharmacistInfo.LastName);
                    command.Parameters.AddWithValue("@Username", pharmacistInfo.Username);
                    command.Parameters.AddWithValue("@Password", pharmacistInfo.Password);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(pharmacistInfo.Phone) ? (object)DBNull.Value : pharmacistInfo.Phone);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(pharmacistInfo.Email) ? (object)DBNull.Value : pharmacistInfo.Email);
                    command.Parameters.AddWithValue("@IsActive", pharmacistInfo.IsActive);

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }
        public static List<stPharmacistInfo> GetAllPharmacists()
        {
            List<stPharmacistInfo> pharmacistsList = new List<stPharmacistInfo>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT PharmacistID, FirstName, LastName, Username, Password, Phone, Email, IsActive FROM Pharmacist";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stPharmacistInfo pharmacist = new stPharmacistInfo
                            {
                                PharmacistID = Convert.ToInt32(reader["PharmacistID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };

                            pharmacistsList.Add(pharmacist);
                        }
                    }
                }
            }

            return pharmacistsList;
        }



        public static stPharmacistInfo GetPharmacistByID(int pharmacistID)
        {
            stPharmacistInfo pharmacist = new stPharmacistInfo();
            pharmacist.PharmacistID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT PharmacistID, FirstName, LastName, Username, Password, Phone, Email 
                         FROM Pharmacist 
                         WHERE PharmacistID = @PharmacistID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PharmacistID", pharmacistID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pharmacist.PharmacistID = Convert.ToInt32(reader["PharmacistID"]);
                            pharmacist.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : "";
                            pharmacist.LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : "";
                            pharmacist.Username = reader["Username"].ToString();
                            pharmacist.Password = reader["Password"].ToString();
                            pharmacist.Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : "";
                            pharmacist.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                        }
                    }
                }
            }

            return pharmacist;
        }
    }



}