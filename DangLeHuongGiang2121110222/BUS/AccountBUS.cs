using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        AccountAccess tkAccess = new AccountAccess();
        public string CheckLogic(AccountDTO taikhoan)
        {
            // Kiểm tra nghiệp vụ
            if (taikhoan.TaiKhoan == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.MatKhau == "")
            {
                return "requeid_password";
            }

            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }
        
    }
}
