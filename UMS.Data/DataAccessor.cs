using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Common;

namespace UMS.Data
{
    public class DataAccessor
    {
        private UMSDbContext _context = new UMSDbContext();
        public bool ValidateUser(Login loginData)
        {
            Login user=_context.User.Select(x => x.UserName == loginData.UserName && x.Password == loginData.Password) as Login;
            if (user != null)
            {  

                return true;
            }
            return false;
        }
    }
}
