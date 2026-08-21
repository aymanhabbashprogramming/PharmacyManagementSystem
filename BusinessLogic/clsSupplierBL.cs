using System.Collections.Generic;
using static PharmacyApp.DataAccess.clsSupplierData;
using PharmacyApp.DataAccess;

namespace PharmacyApp.Business
{
    public class clsSupplierBL
    {
        public static int AddNewSupplier(stSupplierInfo supplierInfo)
        {
            return clsSupplierData.AddNewSupplier(supplierInfo);
        }
        public static bool IsPhoneExists(string phone, int excludeSupplierID = -1)
        {
            return clsSupplierData.IsPhoneExists(phone, excludeSupplierID);
        }
        public static bool IsEmailExists(string email, int excludeSupplierID = -1)
        {
            return clsSupplierData.IsEmailExists(email, excludeSupplierID);
        }
        public static stSupplierInfo GetSupplierByEmail(string email)
        {
            return clsSupplierData.GetSupplierByEmail(email);
        }
        public static bool UpdateSupplierInfo(stSupplierInfo supplierInfo)
        {
            return clsSupplierData.UpdateSupplierInfo(supplierInfo);
        }
        public static List<string> GetAllEmails()
        {
            return clsSupplierData.GetAllEmails();
        }
        public static List<stSupplierInfo> GetAllSuppliers()
        {
            return clsSupplierData.GetAllSuppliers();
        }
        public static List<string> GetAllPhones()
        {
            return clsSupplierData.GetAllPhones();
        }
        public static stSupplierInfo GetSupplierByPhone(string phone)
        {
            return clsSupplierData.GetSupplierByPhone(phone);
        }

    }
}