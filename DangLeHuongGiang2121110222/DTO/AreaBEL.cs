﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AreaBEL
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public List<CustomerBEL> Customer { get; set; }
        public List<TeacherBEL> Teacher { get; set; }
    }
}
