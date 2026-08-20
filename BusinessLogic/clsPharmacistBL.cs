using PharmacyApp.DataAccess;
using System.Collections.Generic;
using static PharmacyApp.DataAccess.clsPharmacistData;

namespace Pharmacy.BusinessLogic
{
    public static class clsPharmacistBL
    {
        public static bool CheckLogin(string username, string password)
        {
            return clsPharmacistData.CheckLogin(username, password);
        }
        public static int AddNewPharmacist(stPharmacistInfo pharmacistInfo)
        {
            if (string.IsNullOrWhiteSpace(pharmacistInfo.Username) || string.IsNullOrWhiteSpace(pharmacistInfo.Password))
            {
                return -1;
            }

            return clsPharmacistData.AddNewPharmacist(pharmacistInfo);
        }
        public static bool IsUsernameExists(string username, int excludePharmacistID = -1)
        {
            return clsPharmacistData.IsUsernameExists(username, excludePharmacistID);
        }
        public static bool IsPhoneExists(string phone, int excludePharmacistID = -1 )
        {
            return clsPharmacistData.IsPhoneExists(phone, excludePharmacistID);
        }
        public static bool IsEmailExists(string email, int excludePharmacistID = -1)
        {
            return clsPharmacistData.IsEmailExists(email, excludePharmacistID);
        }
        public static List<string> GetAllUsernames()
        {
            return clsPharmacistData.GetAllUsernames();
        }
        public static stPharmacistInfo GetPharmacistByUsername(string username)
        {
            return clsPharmacistData.GetPharmacistByUsername(username);
        }
        public static bool UpdatePharmacistInfo(stPharmacistInfo pharmacistInfo)
        {
            return clsPharmacistData.UpdatePharmacistInfo(pharmacistInfo);
        }
        public static List<stPharmacistInfo> GetAllPharmacists()
        {
            return clsPharmacistData.GetAllPharmacists();
        }
        public static stPharmacistInfo GetPharmacistByID(int pharmacistID)
        {
            return clsPharmacistData.GetPharmacistByID(pharmacistID);
        }

    }
}