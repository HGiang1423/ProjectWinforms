using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TTAccountBUS
    {
        TTAccountDAL dal = new TTAccountDAL();
        public List<AccountDTO> ReadAreaList()
        {
            List<AccountDTO> lstCus = dal.ReadAreaList();
            return lstCus;
        }
        public void NewAccount(AccountDTO cus)
        {
            dal.NewAccount(cus);
        }
        public void DeleteAccount(AccountDTO cus)
        {
            dal.DeleteAccount(cus);
        }
        public void EditAccount(AccountDTO cus)
        {
            dal.EditAccount(cus);
        }
    }
}
