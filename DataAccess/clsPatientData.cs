using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp.DataAccess
{
    public class clsPatientData
    {
        public struct stPatientInfo
        {
            public int PatientID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public bool IsActive { get; set; }
        }

        public static int AddNewPatient(stPatientInfo patientInfo)
        {
            int newPatientID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Patient (FirstName, LastName, Phone, IsActive)
                                 VALUES (@FirstName, @LastName, @Phone, @IsActive);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(patientInfo.FirstName) ? (object)DBNull.Value : patientInfo.FirstName.Trim());
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(patientInfo.LastName) ? (object)DBNull.Value : patientInfo.LastName.Trim());
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(patientInfo.Phone) ? (object)DBNull.Value : patientInfo.Phone.Trim());
                    command.Parameters.AddWithValue("@IsActive", patientInfo.IsActive);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newPatientID = insertedID;
                    }
                }
            }

            return newPatientID;
        }
        public static bool IsPhoneExists(string phone, int excludePatientID = -1)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 1 FROM Patient 
                                 WHERE Phone = @Phone AND PatientID <> @ExcludePatientID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone.Trim());
                    command.Parameters.AddWithValue("@ExcludePatientID", excludePatientID);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isFound = true;
                    }
                }
            }

            return isFound;
        }

        public static stPatientInfo GetPatientByPhone(string phone)
        {
            stPatientInfo patient = new stPatientInfo { PatientID = -1 };

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT PatientID, FirstName, LastName, Phone, IsActive 
                         FROM Patient 
                         WHERE Phone = @Phone";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Phone", phone.Trim());

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patient.PatientID = Convert.ToInt32(reader["PatientID"]);
                            patient.FirstName = reader["FirstName"].ToString();
                            patient.LastName = reader["LastName"].ToString();
                            patient.Phone = reader["Phone"].ToString();
                            patient.IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
            }

            return patient;
        }

        public static bool UpdatePatientInfo(stPatientInfo patientInfo)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Patient 
                         SET FirstName = @FirstName,
                             LastName = @LastName,
                             Phone = @Phone,
                             IsActive = @IsActive
                         WHERE PatientID = @PatientID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", patientInfo.PatientID);
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(patientInfo.FirstName) ? (object)DBNull.Value : patientInfo.FirstName.Trim());
                    command.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(patientInfo.LastName) ? (object)DBNull.Value : patientInfo.LastName.Trim());
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(patientInfo.Phone) ? (object)DBNull.Value : patientInfo.Phone.Trim());
                    command.Parameters.AddWithValue("@IsActive", patientInfo.IsActive);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }

        public static List<string> GetAllPhones()
        {
            List<string> phonesList = new List<string>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Phone FROM Patient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Phone"] != DBNull.Value)
                            {
                                phonesList.Add(reader["Phone"].ToString());
                            }
                        }
                    }
                }
            }

            return phonesList;
        }
        public static List<stPatientInfo> GetAllPatients()
        {
            List<stPatientInfo> patientsList = new List<stPatientInfo>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT PatientID, FirstName, LastName, Phone, IsActive FROM Patient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stPatientInfo patient = new stPatientInfo
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };

                            patientsList.Add(patient);
                        }
                    }
                }
            }

            return patientsList;
        }

    }
}