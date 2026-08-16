using PharmacyApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PharmacyApp.DataAccess.clsDrugData;

namespace Pharmacy.BusinessLogic
{
    internal class clsDrugBL
    {
        public static int AddNewCategory(string categoryName)
        {
            return clsDrugData.AddNewCategory(categoryName);
        }
        public static List<stDrugCategoryInfo> GetAllCategories()
        {
            return clsDrugData.GetAllCategories();
        }
        public static bool IsDrugNameExists(string drugName)
        {
            return clsDrugData.IsDrugNameExists(drugName);
        }
        public static int AddNewDrug(stDrugInfo drugInfo)
        {
            return clsDrugData.AddNewDrug(drugInfo);
        }
        public static bool AddNewDrugConflict(int drugID, int conflictingDrugID)
        {
            return clsDrugData.AddNewDrugConflict(drugID, conflictingDrugID);
        }
        public static List<stDrugInfo> GetAllDrugs()
        {
            return clsDrugData.GetAllDrugs();
        }
        public static int AddNewPurchaseInvoice(stPurchaseInvoiceInfo invoiceInfo)
        {
            return clsDrugData.AddNewPurchaseInvoice(invoiceInfo);
        }
        public static bool AddNewPurchaseInvoiceDetail(stPurchaseInvoiceDetailInfo detailInfo)
        {
            return clsDrugData.AddNewPurchaseInvoiceDetail(detailInfo);
        }
        public static bool SaveNewDrugPurchase(
    stPurchaseInvoiceInfo invoiceInfo,
    List<(stDrugInfo DrugInfo, stPurchaseInvoiceDetailInfo DetailInfo, List<int> ConflictingDrugIDs)> purchaseItems)
        {
            return clsDrugData.SaveNewDrugPurchase(invoiceInfo, purchaseItems);
        }

        public static string GetCategoryNameByID(int categoryID)
        {
            return clsDrugData.GetCategoryNameByID(categoryID);
        }

        public static string ValidatePurchaseInvoice(stPurchaseInvoiceInfo invoice,List<stPurchaseInvoiceDetailInfo> details)
        {
            if (invoice.SupplierID <= 0)
                return "Lütfen bir tedarikçi seçiniz.";

            if (invoice.PharmacistID <= 0)
                return "Eczacı girişi yapılmadı.";

            foreach (var d in details)
            {
                if (d.Quantity <= 0)
                    return "Miktar sıfırdan büyük olmalıdır.";

                if (d.UnitPurchasePrice <= 0)
                    return "Birim alış fiyatı sıfırdan büyük olmalıdır.";

                if (d.ExpiryDate.Date <= invoice.InvoiceDate.Date)
                    return "Son kullanma tarihi fatura tarihinden sonra olmalıdır.";
            }

            return null; 
        }

        public static stDrugInfo GetDrugByName(string drugName)
        {
            return clsDrugData.GetDrugByName(drugName);
        }

        public static int GetCurrentStockByDrugID(int drugID)
        {
            return clsDrugData.GetCurrentStockByDrugID(drugID);
        }

        public static bool SaveNewStockPurchase(stPurchaseInvoiceInfo invoiceInfo, List<stPurchaseInvoiceDetailInfo> details)
        {
            return clsDrugData.SaveNewStockPurchase(invoiceInfo, details);
        }

        //----------------------**********************--------------------------------
        public static List<stDrugBatchInfo> GetAllDrugBatches()
        {
            return clsDrugData.GetAllDrugBatches();
        }

        public static List<stDrugInfo> GetConflictingDrugs(int drugID)
        {
            return clsDrugData.GetConflictingDrugs(drugID);
        }

        public static DateTime? GetLastDispensingDate(int patientID, int drugID)
        {
            return clsDrugData.GetLastDispensingDate(patientID, drugID);
        }

        public static List<stDispensingHistoryInfo> GetDispensingHistory(int patientID, int drugID)
        {
            return clsDrugData.GetDispensingHistory(patientID, drugID);
        }

        public static bool SaveNewSale(
            int patientID,
            int pharmacistID,
            DateTime invoiceDate,
            List<(int PurchaseInvoiceDetailID, int DrugID, int Quantity, decimal UnitSellingPrice, decimal TotalPrice)> saleItems)
        {
            return clsDrugData.SaveNewSale(patientID, pharmacistID, invoiceDate, saleItems);
        }

    }
}
