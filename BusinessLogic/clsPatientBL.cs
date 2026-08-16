using System.Collections.Generic;
using PharmacyApp.DataAccess;
using static PharmacyApp.DataAccess.clsPatientData;

namespace PharmacyApp.Business
{
    public class clsPatientBL
    {
        public static int AddNewPatient(stPatientInfo patientInfo)
        {
            return clsPatientData.AddNewPatient(patientInfo);
        }

        public static bool IsPhoneExists(string phone, int excludePatientID = -1)
        {
            return clsPatientData.IsPhoneExists(phone, excludePatientID);
        }

        public static stPatientInfo GetPatientByPhone(string phone)
        {
            return clsPatientData.GetPatientByPhone(phone);
        }

        public static bool UpdatePatientInfo(stPatientInfo patientInfo)
        {
            return clsPatientData.UpdatePatientInfo(patientInfo);
        }

        public static List<string> GetAllPhones()
        {
            return clsPatientData.GetAllPhones();
        }

        public static List<stPatientInfo> GetAllPatients()
        {
            return clsPatientData.GetAllPatients();
        }


    }
}