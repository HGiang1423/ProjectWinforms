using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TTArea
    {
        TTAreaDAL dal = new TTAreaDAL();
        public List<AccountDTO> ReadAreaList()
        {
            List<AccountDTO> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    }
}
