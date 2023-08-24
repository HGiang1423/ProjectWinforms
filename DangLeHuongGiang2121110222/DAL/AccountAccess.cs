using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AccountAccess: DatabaseAccess
    {
        public string CheckLogic(AccountDTO taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
        
    }
}
