﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class AreaBAL
    {
        AreaDAL dal = new AreaDAL();
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    }
}
