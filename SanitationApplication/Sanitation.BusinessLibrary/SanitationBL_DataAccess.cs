using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanitation.BusinessServices;
using System.Data;
using System.Data.SqlClient;

namespace Sanitation.BusinessLibrary
{
    public class SanitationBL_DataAccess
    {
        Sanitation.DataModel.SanitationEntities _db = new DataModel.SanitationEntities(); 
        public string Insert(string username,string password)
        {
            UserRegistration objuserregistration = new UserRegistration();
            objuserregistration.EmailID = username;
            objuserregistration.PhoneNumber = "9177536619";
            objuserregistration.UserID = 1;
            objuserregistration.RoleID = 1;
            objuserregistration.AddressOne = "Hyd";
            objuserregistration.AddressTwo = "Ban";
            _db.UserRegistrations.Add(objuserregistration);
            return username;

        }
    }
}
