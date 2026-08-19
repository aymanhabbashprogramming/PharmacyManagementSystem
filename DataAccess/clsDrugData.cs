using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PharmacyApp.DataAccess
{
    public static class clsDrugData
    {
        public struct stDrugCategoryInfo
        {
            public int DrugCategoryID { get; set; }
            public string CategoryName { get; set; }
        }
        public static int AddNewCategory(string categoryName)
        {
            int newCategoryID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO DrugCategory (CategoryName) 
                                 VALUES (@categoryName);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryName", categoryName);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newCategoryID = insertedID;
                    }
                }
            }

            return newCategoryID;
        }
        public static List<stDrugCategoryInfo> GetAllCategories()
        {
            List<stDrugCategoryInfo> categoriesList = new List<stDrugCategoryInfo>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT DrugCategoryID, CategoryName FROM DrugCategory";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stDrugCategoryInfo category = new stDrugCategoryInfo
                            {
                                DrugCategoryID = Convert.ToInt32(reader["DrugCategoryID"]),
                                CategoryName = reader["CategoryName"].ToString()
                            };

                            categoriesList.Add(category);
                        }
                    }
                }
            }

            return categoriesList;
        }
        public static bool IsDrugNameExists(string drugName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT 1 FROM Drug WHERE LTRIM(RTRIM(DrugName)) = LTRIM(RTRIM(@drugName))";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@drugName", drugName);

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
        public struct stDrugInfo
        {
            public int DrugID { get; set; }
            public int DrugCategoryID { get; set; }
            public string DrugName { get; set; }
            public bool IsRestricted { get; set; }
            public string DailyDosage { get; set; }
            public int? RefillIntervalDays { get; set; }
        }
        public static int AddNewDrug(stDrugInfo drugInfo)
        {
            int newDrugID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Drug (DrugCategoryID, DrugName, IsRestricted, DailyDosage, RefillIntervalDays) 
                         VALUES (@DrugCategoryID, @DrugName, @IsRestricted, @DailyDosage, @RefillIntervalDays);
                         SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrugCategoryID", drugInfo.DrugCategoryID);
                    command.Parameters.AddWithValue("@DrugName", drugInfo.DrugName);
                    command.Parameters.AddWithValue("@IsRestricted", drugInfo.IsRestricted);
                    command.Parameters.AddWithValue("@DailyDosage", (object)drugInfo.DailyDosage ?? DBNull.Value);
                    command.Parameters.AddWithValue("@RefillIntervalDays", (object)drugInfo.RefillIntervalDays ?? DBNull.Value);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newDrugID = insertedID;
                    }
                }
            }

            return newDrugID;
        }
        public static bool AddNewDrugConflict(int drugID, int conflictingDrugID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO DrugConflict (DrugID, ConflictingDrugID) 
                         VALUES (@DrugID, @ConflictingDrugID);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrugID", drugID);
                    command.Parameters.AddWithValue("@ConflictingDrugID", conflictingDrugID);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return (rowsAffected > 0);
        }
        public static List<stDrugInfo> GetAllDrugs()
        {
            List<stDrugInfo> drugsList = new List<stDrugInfo>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT DrugID, DrugCategoryID, DrugName, IsRestricted, DailyDosage, RefillIntervalDays FROM Drug";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stDrugInfo drug = new stDrugInfo
                            {
                                DrugID = Convert.ToInt32(reader["DrugID"]),
                                DrugCategoryID = Convert.ToInt32(reader["DrugCategoryID"]),
                                DrugName = reader["DrugName"].ToString(),
                                IsRestricted = Convert.ToBoolean(reader["IsRestricted"]),
                                DailyDosage = reader["DailyDosage"] == DBNull.Value ? null : reader["DailyDosage"].ToString(),
                                RefillIntervalDays = reader["RefillIntervalDays"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["RefillIntervalDays"])
                            };

                            drugsList.Add(drug);
                        }
                    }
                }
            }

            return drugsList;
        }
        public struct stPurchaseInvoiceInfo
        {
            public int PurchaseInvoiceID { get; set; }
            public int SupplierID { get; set; }
            public int PharmacistID { get; set; }
            public DateTime InvoiceDate { get; set; }
            public decimal TotalAmount { get; set; }
        }
        public struct stPurchaseInvoiceDetailInfo
        {
            public int PurchaseInvoiceDetailID { get; set; }
            public int PurchaseInvoiceID { get; set; }
            public int DrugID { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPurchasePrice { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime ExpiryDate { get; set; }
        }
        public static int AddNewPurchaseInvoice(stPurchaseInvoiceInfo invoiceInfo)
        {
            int newInvoiceID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO PurchaseInvoice (SupplierID, PharmacistID, InvoiceDate, TotalAmount) 
                         VALUES (@SupplierID, @PharmacistID, @InvoiceDate, @TotalAmount);
                         SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", invoiceInfo.SupplierID);
                    command.Parameters.AddWithValue("@PharmacistID", invoiceInfo.PharmacistID);
                    command.Parameters.AddWithValue("@InvoiceDate", invoiceInfo.InvoiceDate);
                    command.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newInvoiceID = insertedID;
                    }
                }
            }

            return newInvoiceID;
        }
        public static bool AddNewPurchaseInvoiceDetail(stPurchaseInvoiceDetailInfo detailInfo)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO PurchaseInvoiceDetail (PurchaseInvoiceID, DrugID, Quantity, UnitPurchasePrice, TotalPrice, ExpiryDate) 
                         VALUES (@PurchaseInvoiceID, @DrugID, @Quantity, @UnitPurchasePrice, @TotalPrice, @ExpiryDate);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PurchaseInvoiceID", detailInfo.PurchaseInvoiceID);
                    command.Parameters.AddWithValue("@DrugID", detailInfo.DrugID);
                    command.Parameters.AddWithValue("@Quantity", detailInfo.Quantity);
                    command.Parameters.AddWithValue("@UnitPurchasePrice", detailInfo.UnitPurchasePrice);
                    command.Parameters.AddWithValue("@TotalPrice", detailInfo.TotalPrice);
                    command.Parameters.AddWithValue("@ExpiryDate", detailInfo.ExpiryDate);

                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return (rowsAffected > 0);
        }

        public static bool SaveNewDrugPurchase(
    stPurchaseInvoiceInfo invoiceInfo,
    List<(stDrugInfo DrugInfo, stPurchaseInvoiceDetailInfo DetailInfo, List<int> ConflictingDrugIDs)> purchaseItems)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. إدراج فاتورة الشراء واسترجاع الـ PurchaseInvoiceID
                        string insertInvoiceQuery = @"INSERT INTO PurchaseInvoice (SupplierID, PharmacistID, InvoiceDate, TotalAmount) 
                                              VALUES (@SupplierID, @PharmacistID, @InvoiceDate, @TotalAmount);
                                              SELECT SCOPE_IDENTITY();";

                        int purchaseInvoiceID = -1;

                        using (SqlCommand cmdInvoice = new SqlCommand(insertInvoiceQuery, connection, transaction))
                        {
                            cmdInvoice.Parameters.AddWithValue("@SupplierID", invoiceInfo.SupplierID);
                            cmdInvoice.Parameters.AddWithValue("@PharmacistID", invoiceInfo.PharmacistID);
                            cmdInvoice.Parameters.AddWithValue("@InvoiceDate", invoiceInfo.InvoiceDate);
                            cmdInvoice.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);

                            object result = cmdInvoice.ExecuteScalar();

                            if (result == null || !int.TryParse(result.ToString(), out purchaseInvoiceID))
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }

                        // 2. التكرار على جميع الأدوية والتفاصيل والتعارضات المطلوبة
                        foreach (var item in purchaseItems)
                        {
                            // أ. إدراج الدواء الجديد واسترجاع الـ DrugID
                            string insertDrugQuery = @"INSERT INTO Drug (DrugCategoryID, DrugName, IsRestricted, DailyDosage, RefillIntervalDays) 
                                               VALUES (@DrugCategoryID, @DrugName, @IsRestricted, @DailyDosage, @RefillIntervalDays);
                                               SELECT SCOPE_IDENTITY();";

                            int newDrugID = -1;

                            using (SqlCommand cmdDrug = new SqlCommand(insertDrugQuery, connection, transaction))
                            {
                                cmdDrug.Parameters.AddWithValue("@DrugCategoryID", item.DrugInfo.DrugCategoryID);
                                cmdDrug.Parameters.AddWithValue("@DrugName", item.DrugInfo.DrugName);
                                cmdDrug.Parameters.AddWithValue("@IsRestricted", item.DrugInfo.IsRestricted);
                                cmdDrug.Parameters.AddWithValue("@DailyDosage", (object)item.DrugInfo.DailyDosage ?? DBNull.Value);
                                cmdDrug.Parameters.AddWithValue("@RefillIntervalDays", (object)item.DrugInfo.RefillIntervalDays ?? DBNull.Value);

                                object drugResult = cmdDrug.ExecuteScalar();

                                if (drugResult == null || !int.TryParse(drugResult.ToString(), out newDrugID))
                                {
                                    transaction.Rollback();
                                    return false;
                                }
                            }

                            // ب. إدراج تفاصيل الفاتورة وتثبيت الربط مع PurchaseInvoiceID و DrugID
                            string insertDetailQuery = @"INSERT INTO PurchaseInvoiceDetail (PurchaseInvoiceID, DrugID, Quantity, UnitPurchasePrice, TotalPrice, ExpiryDate) 
                                                 VALUES (@PurchaseInvoiceID, @DrugID, @Quantity, @UnitPurchasePrice, @TotalPrice, @ExpiryDate);";

                            using (SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, connection, transaction))
                            {
                                cmdDetail.Parameters.AddWithValue("@PurchaseInvoiceID", purchaseInvoiceID);
                                cmdDetail.Parameters.AddWithValue("@DrugID", newDrugID);
                                cmdDetail.Parameters.AddWithValue("@Quantity", item.DetailInfo.Quantity);
                                cmdDetail.Parameters.AddWithValue("@UnitPurchasePrice", item.DetailInfo.UnitPurchasePrice);
                                cmdDetail.Parameters.AddWithValue("@TotalPrice", item.DetailInfo.TotalPrice);
                                cmdDetail.Parameters.AddWithValue("@ExpiryDate", item.DetailInfo.ExpiryDate);

                                cmdDetail.ExecuteNonQuery();
                            }

                            // ج. إدراج التعارضات الدوائية لهذا الدواء إن وجدت
                            if (item.ConflictingDrugIDs != null && item.ConflictingDrugIDs.Count > 0)
                            {
                                string insertConflictQuery = @"INSERT INTO DrugConflict (DrugID, ConflictingDrugID) 
                                                       VALUES (@DrugID, @ConflictingDrugID);";

                                foreach (int conflictingDrugID in item.ConflictingDrugIDs)
                                {
                                    using (SqlCommand cmdConflict = new SqlCommand(insertConflictQuery, connection, transaction))
                                    {
                                        cmdConflict.Parameters.AddWithValue("@DrugID", newDrugID);
                                        cmdConflict.Parameters.AddWithValue("@ConflictingDrugID", conflictingDrugID);

                                        cmdConflict.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        // 3. تأكيد العملية في حال نجاح كل الخطوات
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        // إلغاء كل ما تم تنفيذه وإعادة رمي الاستثناء لواجهة المستخدم
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static string GetCategoryNameByID(int categoryID)
        {
            string categoryName = "";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT CategoryName 
                         FROM DrugCategory 
                         WHERE DrugCategoryID = @CategoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        categoryName = result.ToString();
                    }
                }
            }

            return categoryName;
        }
        public static stDrugInfo GetDrugByName(string drugName)
        {
            stDrugInfo info = new stDrugInfo();
            info.DrugID = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT DrugID, DrugName, DrugCategoryID, IsRestricted, 
                         DailyDosage, RefillIntervalDays 
                         FROM Drug 
                         WHERE LTRIM(RTRIM(DrugName)) = LTRIM(RTRIM(@DrugName))";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DrugName", drugName);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            info.DrugID = (int)reader["DrugID"];
                            info.DrugName = reader["DrugName"].ToString();
                            info.DrugCategoryID = (int)reader["DrugCategoryID"];
                            info.IsRestricted = (bool)reader["IsRestricted"];
                            info.DailyDosage = reader["DailyDosage"] != DBNull.Value ? reader["DailyDosage"].ToString() : string.Empty;
                            info.RefillIntervalDays = reader["RefillIntervalDays"] != DBNull.Value ? (int?)reader["RefillIntervalDays"] : null;
                        }
                    }
                }
            }

            return info;
        }

        public static int GetCurrentStockByDrugID(int drugID)
        {
            int currentStock = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                            ISNULL((SELECT SUM(Quantity) FROM PurchaseInvoiceDetail WHERE DrugID = @DrugID), 0)
                            -
                            ISNULL((SELECT SUM(sdb.Quantity) 
                                    FROM SaleDetailBatch sdb
                                    INNER JOIN PurchaseInvoiceDetail pid ON sdb.PurchaseInvoiceDetailID = pid.PurchaseInvoiceDetailID
                                    WHERE pid.DrugID = @DrugID), 0)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DrugID", drugID);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        currentStock = Convert.ToInt32(result);
                    }
                }
            }

            return currentStock;
        }

        public static bool SaveNewStockPurchase(
    stPurchaseInvoiceInfo invoiceInfo,
    List<stPurchaseInvoiceDetailInfo> details)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. إدراج فاتورة الشراء واسترجاع PurchaseInvoiceID
                        string insertInvoiceQuery = @"INSERT INTO PurchaseInvoice (SupplierID, PharmacistID, InvoiceDate, TotalAmount) 
                                      VALUES (@SupplierID, @PharmacistID, @InvoiceDate, @TotalAmount);
                                      SELECT SCOPE_IDENTITY();";

                        int purchaseInvoiceID = -1;

                        using (SqlCommand cmdInvoice = new SqlCommand(insertInvoiceQuery, connection, transaction))
                        {
                            cmdInvoice.Parameters.AddWithValue("@SupplierID", invoiceInfo.SupplierID);
                            cmdInvoice.Parameters.AddWithValue("@PharmacistID", invoiceInfo.PharmacistID);
                            cmdInvoice.Parameters.AddWithValue("@InvoiceDate", invoiceInfo.InvoiceDate);
                            cmdInvoice.Parameters.AddWithValue("@TotalAmount", invoiceInfo.TotalAmount);

                            object result = cmdInvoice.ExecuteScalar();

                            if (result == null || !int.TryParse(result.ToString(), out purchaseInvoiceID))
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }

                        // 2. إدراج تفاصيل الفاتورة لكل دفعة (الدواء موجود مسبقاً)
                        string insertDetailQuery = @"INSERT INTO PurchaseInvoiceDetail (PurchaseInvoiceID, DrugID, Quantity, UnitPurchasePrice, TotalPrice, ExpiryDate) 
                                     VALUES (@PurchaseInvoiceID, @DrugID, @Quantity, @UnitPurchasePrice, @TotalPrice, @ExpiryDate);";

                        foreach (var detail in details)
                        {
                            using (SqlCommand cmdDetail = new SqlCommand(insertDetailQuery, connection, transaction))
                            {
                                cmdDetail.Parameters.AddWithValue("@PurchaseInvoiceID", purchaseInvoiceID);
                                cmdDetail.Parameters.AddWithValue("@DrugID", detail.DrugID);
                                cmdDetail.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                cmdDetail.Parameters.AddWithValue("@UnitPurchasePrice", detail.UnitPurchasePrice);
                                cmdDetail.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                                cmdDetail.Parameters.AddWithValue("@ExpiryDate", detail.ExpiryDate);

                                cmdDetail.ExecuteNonQuery();
                            }
                        }

                        // 3. تأكيد العملية
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public struct stDrugBatchInfo
        {
            public int PurchaseInvoiceDetailID { get; set; }
            public int DrugID { get; set; }
            public string DrugName { get; set; }
            public int Quantity { get; set; }
            public bool IsRestricted { get; set; }
            public bool HasConflict { get; set; }
            public decimal UnitPurchasePrice { get; set; } // إضافة سعر شراء الوحدة
        }
        public static List<stDrugBatchInfo> GetAllDrugBatches()
        {
            List<stDrugBatchInfo> list = new List<stDrugBatchInfo>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        SELECT 
            PurchaseInvoiceDetail.PurchaseInvoiceDetailID,
            PurchaseInvoiceDetail.DrugID,
            Drug.DrugName,
            PurchaseInvoiceDetail.UnitPurchasePrice,
            (PurchaseInvoiceDetail.Quantity - ISNULL((SELECT SUM(SaleDetailBatch.Quantity) 
                                                     FROM SaleDetailBatch 
                                                     WHERE SaleDetailBatch.PurchaseInvoiceDetailID = PurchaseInvoiceDetail.PurchaseInvoiceDetailID), 0)) AS RemainingQuantity,
            Drug.IsRestricted,
            CASE 
                WHEN EXISTS (
                    SELECT 1 
                    FROM DrugConflict 
                    WHERE DrugConflict.DrugID = Drug.DrugID OR DrugConflict.ConflictingDrugID = Drug.DrugID
                ) THEN CAST(1 AS BIT)
                ELSE CAST(0 AS BIT)
            END AS HasConflict
        FROM PurchaseInvoiceDetail
        INNER JOIN Drug ON PurchaseInvoiceDetail.DrugID = Drug.DrugID
        WHERE (PurchaseInvoiceDetail.Quantity - ISNULL((SELECT SUM(SaleDetailBatch.Quantity) 
                                                        FROM SaleDetailBatch 
                                                        WHERE SaleDetailBatch.PurchaseInvoiceDetailID = PurchaseInvoiceDetail.PurchaseInvoiceDetailID), 0)) > 0;";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                stDrugBatchInfo batch = new stDrugBatchInfo
                {
                    PurchaseInvoiceDetailID = Convert.ToInt32(reader["PurchaseInvoiceDetailID"]),
                    DrugID = Convert.ToInt32(reader["DrugID"]),
                    DrugName = reader["DrugName"].ToString(),
                    Quantity = Convert.ToInt32(reader["RemainingQuantity"]),
                    IsRestricted = Convert.ToBoolean(reader["IsRestricted"]),
                    HasConflict = Convert.ToBoolean(reader["HasConflict"]),
                    UnitPurchasePrice = Convert.ToDecimal(reader["UnitPurchasePrice"]) // تعبئة السعر من القارئ
                };

                list.Add(batch);
            }

            reader.Close();
            connection.Close();

            return list;
        }
    
        
        public static List<stDrugInfo> GetConflictingDrugs(int drugID)
        {
            List<stDrugInfo> conflictingDrugsList = new List<stDrugInfo>();

            string query = @"
        SELECT Drug.* 
        FROM Drug 
        WHERE Drug.DrugID IN (
            SELECT DrugConflict.ConflictingDrugID 
            FROM DrugConflict 
            WHERE DrugConflict.DrugID = @DrugID

            UNION

            SELECT DrugConflict.DrugID 
            FROM DrugConflict 
            WHERE DrugConflict.ConflictingDrugID = @DrugID
        );";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrugID", drugID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stDrugInfo drug = new stDrugInfo
                            {
                                DrugID = Convert.ToInt32(reader["DrugID"]),
                                DrugName = reader["DrugName"].ToString(),
                                IsRestricted = Convert.ToBoolean(reader["IsRestricted"])
                            };

                            conflictingDrugsList.Add(drug);
                        }
                    }
                }
            }

            return conflictingDrugsList;
        }
        public static DateTime? GetLastDispensingDate(int patientID, int drugID)
        {
            DateTime? lastDispensingDate = null;

            string query = @"
        SELECT MAX(SaleInvoice.InvoiceDate) 
        FROM SaleInvoiceDetail 
        INNER JOIN SaleInvoice ON SaleInvoiceDetail.SaleInvoiceID = SaleInvoice.SaleInvoiceID 
        WHERE SaleInvoice.PatientID = @PatientID AND SaleInvoiceDetail.DrugID = @DrugID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.Parameters.AddWithValue("@DrugID", drugID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        lastDispensingDate = Convert.ToDateTime(result);
                    }
                }
            }

            return lastDispensingDate;
        }
        public struct stDispensingHistoryInfo
        {
            public DateTime InvoiceDate { get; set; }
            public int Quantity { get; set; }
        }
        public static List<stDispensingHistoryInfo> GetDispensingHistory(int patientID, int drugID)
        {
            List<stDispensingHistoryInfo> historyList = new List<stDispensingHistoryInfo>();

            string query = @"
        SELECT 
            SaleInvoice.InvoiceDate, 
            SaleInvoiceDetail.Quantity
        FROM SaleInvoiceDetail
        INNER JOIN SaleInvoice ON SaleInvoiceDetail.SaleInvoiceID = SaleInvoice.SaleInvoiceID
        WHERE SaleInvoice.PatientID = @PatientID AND SaleInvoiceDetail.DrugID = @DrugID
        ORDER BY SaleInvoice.InvoiceDate ASC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.Parameters.AddWithValue("@DrugID", drugID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stDispensingHistoryInfo historyItem = new stDispensingHistoryInfo
                            {
                                InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            };

                            historyList.Add(historyItem);
                        }
                    }
                }
            }

            return historyList;
        }
        public static bool SaveNewSale(
    int patientID,
    int pharmacistID,
    DateTime invoiceDate,
    List<(int PurchaseInvoiceDetailID, int DrugID, int Quantity, decimal UnitSellingPrice, decimal TotalPrice)> saleItems)
        {
            if (saleItems == null || saleItems.Count == 0)
                return false;

            decimal totalAmount = 0;
            foreach (var item in saleItems)
            {
                totalAmount += item.TotalPrice;
            }

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertInvoiceQuery = @"
                INSERT INTO SaleInvoice (PatientID, PharmacistID, InvoiceDate, TotalAmount)
                VALUES (@PatientID, @PharmacistID, @InvoiceDate, @TotalAmount);
                SELECT SCOPE_IDENTITY();";

                    int saleInvoiceID = 0;

                    using (SqlCommand invoiceCommand = new SqlCommand(insertInvoiceQuery, connection, transaction))
                    {
                        invoiceCommand.Parameters.AddWithValue("@PatientID", patientID);
                        invoiceCommand.Parameters.AddWithValue("@PharmacistID", pharmacistID);
                        invoiceCommand.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                        invoiceCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        object result = invoiceCommand.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out decimal insertedID))
                        {
                            saleInvoiceID = Convert.ToInt32(insertedID);
                        }
                    }

                    if (saleInvoiceID <= 0)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    string insertDetailQuery = @"
                INSERT INTO SaleInvoiceDetail (SaleInvoiceID, DrugID, Quantity, UnitSellingPrice, TotalPrice)
                VALUES (@SaleInvoiceID, @DrugID, @Quantity, @UnitSellingPrice, @TotalPrice);
                SELECT SCOPE_IDENTITY();";

                    string insertBatchQuery = @"
                INSERT INTO SaleDetailBatch (SaleInvoiceDetailID, PurchaseInvoiceDetailID, Quantity)
                VALUES (@SaleInvoiceDetailID, @PurchaseInvoiceDetailID, @Quantity);";

                    foreach (var item in saleItems)
                    {
                        int saleInvoiceDetailID = 0;
                        using (SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection, transaction))
                        {
                            detailCommand.Parameters.AddWithValue("@SaleInvoiceID", saleInvoiceID);
                            detailCommand.Parameters.AddWithValue("@DrugID", item.DrugID);
                            detailCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                            detailCommand.Parameters.AddWithValue("@UnitSellingPrice", item.UnitSellingPrice);
                            detailCommand.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);

                            object detailResult = detailCommand.ExecuteScalar();
                            if (detailResult != null && decimal.TryParse(detailResult.ToString(), out decimal insertedDetailID))
                            {
                                saleInvoiceDetailID = Convert.ToInt32(insertedDetailID);
                            }
                        }

                        if (saleInvoiceDetailID <= 0)
                        {
                            transaction.Rollback();
                            return false;
                        }

                        using (SqlCommand batchCommand = new SqlCommand(insertBatchQuery, connection, transaction))
                        {
                            batchCommand.Parameters.AddWithValue("@SaleInvoiceDetailID", saleInvoiceDetailID);
                            batchCommand.Parameters.AddWithValue("@PurchaseInvoiceDetailID", item.PurchaseInvoiceDetailID);
                            batchCommand.Parameters.AddWithValue("@Quantity", item.Quantity);

                            batchCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


    }
}