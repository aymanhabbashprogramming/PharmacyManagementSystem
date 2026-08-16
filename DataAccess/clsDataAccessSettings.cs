using System.Configuration;

namespace PharmacyApp.DataAccess
{
    public static class clsDataAccessSettings
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["PharmacyDB"].ConnectionString;
            }
        }
    }
}